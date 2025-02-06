using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace InjectorV
{
    public static class ArchitectureHelper
    {
        [DllImport("kernel32.dll", SetLastError = true, CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool IsWow64Process([In] IntPtr hProcess, [Out] out bool lpSystemInfo);


        public static bool Is64BitProcess(Process process)
        {
            if (!Environment.Is64BitOperatingSystem)
            {
                return false;
            }

            bool retVal;
            if (!IsWow64Process(process.Handle, out retVal))
            {
                return false;
            }

            return !retVal;
        }
    }
}