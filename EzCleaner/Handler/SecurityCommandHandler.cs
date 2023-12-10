using System.Diagnostics;
using System.Text;
using EzCleaner.Interfaces;

namespace EzCleaner.Handler
{
    internal class SecurityCommandHandler : CommandHandler, IToolHandler
    {
        private string[] _defaultCommandsFast
        {
            get
            {
                return
                [
                    "/c mrt /q",
                    "/c \"C:\\Program Files\\Windows Defender\\MpCmdRun.exe\" -Scan -ScanType 1"
                ];
            }
        }

        private string[] _defaultCommandsFull
        {
            get
            {
                return
                [
                    "/c mrt /q /f",
                    "/c \"C:\\Program Files\\Windows Defender\\MpCmdRun.exe\" -Scan -ScanType 2"
                ];
            }
        }

        public SecurityCommandHandler()
        {
            arguments = _defaultCommandsFast;
        }

        public SecurityCommandHandler(bool fast)
        {
            arguments = fast ? _defaultCommandsFast : _defaultCommandsFull;
        }

        public void StartSecurityScan()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("------------------------------------------------");
            builder.AppendLine("Security scan has started");
            builder.AppendLine("------------------------------------------------");
            builder.AppendLine("Following clean commands will be executed:");
            Console.WriteLine(builder.ToString());
            StartEzCleaner();
        }
    }
}
