using System;
using System.IO;
using System.Windows.Forms;

namespace CarRentalApp.Core.Utils
{
    public static class StringExtensions
    {
        public static bool Contains(this string source, string toCheck, StringComparison comp)
        {
            return source?.IndexOf(toCheck, comp) >= 0;
        }
    }
    public class AppLogger
    {
        private static readonly string FilePath = AppDomain.CurrentDomain.BaseDirectory
                                                   + Application.ProductName+"SqlLog.log";
        public static void LogSqlInFile(string logInfo)
        {
            
            File.AppendAllText(FilePath, logInfo);
        }
    }
}
