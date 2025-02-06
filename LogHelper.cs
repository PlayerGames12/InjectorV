using System;
using System.IO;

namespace InjectorV
{
    public static class LogHelper
    {
        private static string logFilePath = "injector.log";
        private static bool loggingEnabled = true;

        public static void Initialize(string filePath, bool enabled)
        {
            logFilePath = filePath;
            loggingEnabled = enabled;
        }


        public static void Log(string message)
        {
            if (loggingEnabled)
            {
                try
                {
                    string logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}{Environment.NewLine}";
                    File.AppendAllText(logFilePath, logEntry);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при записи в лог: {ex.Message}");
                }
            }
        }

        public static void LogError(string message, Exception ex)
        {
            Log($"ERROR: {message} - {ex.Message}{Environment.NewLine}{ex.StackTrace}");
        }
    }
}