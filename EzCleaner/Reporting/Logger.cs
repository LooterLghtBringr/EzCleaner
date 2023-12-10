using System.Text;

namespace EzCleaner.Reporting
{
    internal class Logger
    {
        private static readonly string _logFileName = "EzCleanerResult.txt";
        private static readonly string _logFilePath = "C:\\temp\\";
        private StringBuilder logMessage;
        public string? Argument { get; set; }

        public Logger()
        {
            logMessage = new StringBuilder();
        }

        public Logger(string argument)
        {
            logMessage = new StringBuilder();
            Argument = argument;
        }

        public StringBuilder AppendNewCleanerRunLine()
        {
            return logMessage.AppendLine($"{DateTime.Now} EzCleaner Run:");
        }

        public StringBuilder AppendCommandLine()
        {
            return logMessage.AppendLine(Argument);
        }

        public StringBuilder AppendExitCodeLine(int exitCode)
        {
            return logMessage.AppendLine($"Command {Argument} has exit code {exitCode}");
        }

        public StringBuilder AppendExceptionMessage(string exceptionMessage)
        {
            return logMessage.AppendLine($"Error executing command {Argument}: {exceptionMessage}");
        }

        public void SaveLoggerFile()
        {
            Console.WriteLine("Log File " + _logFileName + " is saved under " + _logFilePath);
            File.AppendAllText(_logFilePath + _logFileName, logMessage.ToString());
            Console.WriteLine("Press any key to leave the application...");
            Console.ReadKey();
        }
    }
}
