using System;
using System.Diagnostics;

namespace ReproBugSqlCmdDisablesAnsiSupport
{
    class Program
    {
        static void Main(string[] args)
        {
            // GOOD: This shows in the Console with colors
            Console.WriteLine("\u001b[41;1m\u001b[37;1mC. Augusto Proiete\u001b[0m");

            Process.Start("sqlcmd", "-???")?.WaitForExit();

            // BAD: ANSI support was disabled by SQLCMD and ANSI colors no longer work
            Console.WriteLine("\u001b[41;1m\u001b[37;1mC. Augusto Proiete\u001b[0m");
        }
    }
}
