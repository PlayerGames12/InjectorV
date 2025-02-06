using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace InjectorV
{
    public static class ProcessHelper
    {
        public static List<Process> GetProcessesByName(string processName)
        {
            return Process.GetProcessesByName(processName).ToList();
        }

        public static List<Process> GetRunningProcesses()
        {
            return Process.GetProcesses().OrderBy(p => p.ProcessName).ToList();
        }

        public static List<Process> FilterProcesses(List<Process> processes, string filterText, bool showOnlyWithWindows)
        {
            if (string.IsNullOrEmpty(filterText) && !showOnlyWithWindows)
            {
                return processes;
            }

            IEnumerable<Process> filtered = processes;

            if (!string.IsNullOrEmpty(filterText))
            {
                filtered = filtered.Where(p =>
                    p.ProcessName.IndexOf(filterText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    p.Id.ToString().IndexOf(filterText, StringComparison.OrdinalIgnoreCase) >= 0
                );
            }

            if (showOnlyWithWindows)
            {
                filtered = filtered.Where(p => !string.IsNullOrEmpty(p.MainWindowTitle));
            }

            return filtered.ToList();
        }

        public static List<Process> FilterOutSystemProcesses(List<Process> processes)
        {
            List<string> processesToExclude = new List<string>() { "svchost", "System", "Registry" };

            return processes.Where(p => !processesToExclude.Contains(p.ProcessName, StringComparer.OrdinalIgnoreCase)).ToList();
        }
    }
}