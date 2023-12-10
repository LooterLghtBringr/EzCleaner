using System.Diagnostics;
using System.Text;
using EzCleaner.Interfaces;

namespace EzCleaner.Handler
{
    internal class CleanCommandHandler : CommandHandler, IToolHandler
    {

        private string[] _defaultCommands
        {
            get
            {
                return
                [
                    "/c del %temp%\\*.* /s /q",
                    "/c del C:\\Windows\\prefetch\\*.*/s/q",
                    "/c sfc /scannow",
                    "/c ipconfig/flushDNS",
                    "/c DISM /Online /Cleanup-Image /RestoreHealth",
                    "/c chkdsk",
                    "/c wsreset.exe"
                ];
            }
        }

        /// <summary>
        /// if default constructor is used a default commands list will be used
        /// </summary>
        public CleanCommandHandler()
        {
            arguments = _defaultCommands;
        }

        /// <summary>
        /// constructor with parameter where you can set your own list of arguments
        /// </summary>
        /// <param name="arguments">cmd commands to run</param>
        public CleanCommandHandler(string[] arguments)
        {
            this.arguments = arguments;
        }

        public void StartCleanCommands()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("------------------------------------------------");
            builder.AppendLine("Cleaning has started");
            builder.AppendLine("------------------------------------------------");
            builder.AppendLine("Following clean commands will be executed:");
            Console.WriteLine(builder.ToString());
            StartEzCleaner();
            CloseMicrosoftStoreProcesses();
        }

        private void CloseMicrosoftStoreProcesses()
        {
            var microsoftStoreProcesses = Process.GetProcessesByName("WinStore.App");
            foreach (var process in microsoftStoreProcesses)
            {
                process.Kill();
                process.WaitForExit();
            }
        }
    }
}
