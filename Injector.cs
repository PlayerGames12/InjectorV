using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace InjectorV
{
    public class Injector
    {
        [DllImport("kernel32.dll", SetLastError = true, CallingConvention = CallingConvention.StdCall)]
        static extern IntPtr OpenProcess(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

        [DllImport("kernel32.dll", SetLastError = true, CallingConvention = CallingConvention.StdCall)]
        static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

        [DllImport("kernel32.dll", SetLastError = true, CallingConvention = CallingConvention.StdCall)]
        static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out UIntPtr lpNumberOfBytesWritten);

        [DllImport("kernel32.dll", SetLastError = true, CallingConvention = CallingConvention.StdCall)]
        static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr GetProcAddress(IntPtr hModule, string lpProcName);

        [DllImport("kernel32.dll", SetLastError = true, CallingConvention = CallingConvention.StdCall)]
        static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern UInt32 WaitForSingleObject(IntPtr hHandle, UInt32 dwMilliseconds);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool FreeLibrary(IntPtr hModule);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr VirtualProtectEx(IntPtr hProcess, IntPtr lpAddress, UIntPtr dwSize, uint flNewProtect, out uint lpflOldProtect);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool VirtualFreeEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, uint dwFreeType);

        const int PROCESS_CREATE_THREAD = 0x0002;
        const int PROCESS_QUERY_INFORMATION = 0x0400;
        const int PROCESS_VM_OPERATION = 0x0008;
        const int PROCESS_VM_WRITE = 0x0020;
        const int PROCESS_VM_READ = 0x0010;

        const uint MEM_COMMIT = 0x00001000;
        const uint MEM_RESERVE = 0x00002000;
        const uint MEM_DECOMMIT = 0x00004000;
        const uint MEM_RELEASE = 0x00008000;

        const uint PAGE_READWRITE = 0x04;
        const uint PAGE_EXECUTE_READ = 0x20;
        const uint PAGE_EXECUTE_READWRITE = 0x40;
        const uint PAGE_EXECUTE = 0x10;
        const uint PAGE_NOACCESS = 0x01;

        const UInt32 INFINITE = 0xFFFFFFFF;
        const UInt32 WAIT_ABANDONED = 0x00000080;
        const UInt32 WAIT_OBJECT_0 = 0x00000000;
        const UInt32 WAIT_TIMEOUT = 0x00000102;
        const UInt32 WAIT_FAILED = 0xFFFFFFFF;


        public static bool InjectDLL(int processId, string dllPath, InjectionMethod method)
        {
            try
            {
                switch (method)
                {
                    case InjectionMethod.LoadLibrary:
                        return InjectWithLoadLibrary(processId, dllPath);
                    case InjectionMethod.ManualMap:
                        return InjectWithManualMap(processId, dllPath);
                    default:
                        LogHelper.Log("Ошибка: Неизвестный метод инжекции.");
                        return false;
                }
            }
            catch (Exception ex)
            {
                LogHelper.LogError("Ошибка при инжекции DLL:", ex);
                return false;
            }
        }

        private static bool InjectWithLoadLibrary(int processId, string dllPath)
        {
            LogHelper.Log($"Инжектирование DLL '{dllPath}' в процесс {processId} (LoadLibrary)");

            IntPtr hProcess = OpenProcess((uint)(PROCESS_CREATE_THREAD | PROCESS_QUERY_INFORMATION | PROCESS_VM_OPERATION | PROCESS_VM_WRITE | PROCESS_VM_READ), 0, (uint)processId);

            if (hProcess == IntPtr.Zero)
            {
                LogHelper.Log($"Ошибка: Не удалось открыть процесс. Код ошибки: {Marshal.GetLastWin32Error()}");
                return false;
            }

            IntPtr lpBaseAddress = VirtualAllocEx(hProcess, IntPtr.Zero, (uint)dllPath.Length + 1, MEM_COMMIT | MEM_RESERVE, PAGE_READWRITE);

            if (lpBaseAddress == IntPtr.Zero)
            {
                LogHelper.Log($"Ошибка: Не удалось выделить память в процессе. Код ошибки: {Marshal.GetLastWin32Error()}");
                return false;
            }

            UIntPtr bytesWritten;
            byte[] dllPathBytes = Encoding.ASCII.GetBytes(dllPath);

            if (!WriteProcessMemory(hProcess, lpBaseAddress, dllPathBytes, (uint)dllPathBytes.Length, out bytesWritten))
            {
                LogHelper.Log($"Ошибка: Не удалось записать в память процесса. Код ошибки: {Marshal.GetLastWin32Error()}");
                return false;
            }

            IntPtr kernel32Handle = GetModuleHandle("kernel32.dll");
            if (kernel32Handle == IntPtr.Zero)
            {
                LogHelper.Log($"Ошибка: Не удалось получить хэндл kernel32.dll. Код ошибки: {Marshal.GetLastWin32Error()}");
                return false;
            }

            IntPtr loadLibraryAddress = GetProcAddress(kernel32Handle, "LoadLibraryA");
            if (loadLibraryAddress == IntPtr.Zero)
            {
                LogHelper.Log($"Ошибка: Не удалось получить адрес LoadLibraryA. Код ошибки: {Marshal.GetLastWin32Error()}");
                return false;
            }


            IntPtr hThread = CreateRemoteThread(hProcess, IntPtr.Zero, 0, loadLibraryAddress, lpBaseAddress, 0, IntPtr.Zero);

            if (hThread == IntPtr.Zero)
            {
                LogHelper.Log($"Ошибка: Не удалось создать удаленный поток. Код ошибки: {Marshal.GetLastWin32Error()}");
                return false;
            }

            WaitForSingleObject(hThread, INFINITE);

            LogHelper.Log($"DLL '{dllPath}' успешно инжектирована в процесс {processId} (LoadLibrary)");
            return true;
        }

        private static bool InjectWithManualMap(int processId, string dllPath)
        {
            LogHelper.Log($"Инжектирование DLL '{dllPath}' в процесс {processId} (Manual Map)");
            return false;
        }


        public static bool EjectDLL(int processId, string moduleName)
        {
            LogHelper.Log($"Выгрузка DLL '{moduleName}' из процесса {processId}");

            IntPtr hProcess = OpenProcess((uint)(PROCESS_QUERY_INFORMATION | PROCESS_VM_OPERATION), 0, (uint)processId);

            if (hProcess == IntPtr.Zero)
            {
                LogHelper.Log($"Ошибка: Не удалось открыть процесс. Код ошибки: {Marshal.GetLastWin32Error()}");
                return false;
            }

            IntPtr hModule = GetModuleHandle(moduleName);
            if (hModule == IntPtr.Zero)
            {
                Process process = Process.GetProcessById(processId);
                if (process != null)
                {
                    foreach (ProcessModule module in process.Modules)
                    {
                        if (module.ModuleName.Equals(moduleName, StringComparison.OrdinalIgnoreCase))
                        {
                            hModule = module.BaseAddress;
                            break;
                        }
                    }
                }

                if (hModule == IntPtr.Zero)
                {
                    LogHelper.Log($"Ошибка: Модуль '{moduleName}' не найден в процессе.");
                    return false;
                }
            }



            bool result = FreeLibrary(hModule);
            if (!result)
            {
                LogHelper.Log($"Ошибка: Не удалось выгрузить модуль '{moduleName}'. Код ошибки: {Marshal.GetLastWin32Error()}");
            }
            else
            {
                LogHelper.Log($"Модуль '{moduleName}' успешно выгружен из процесса {processId}.");
            }
            return result;
        }
    }
}