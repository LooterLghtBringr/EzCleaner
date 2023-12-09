using System.Diagnostics;
using System.Text;

namespace EzCleaner
{
    internal class CommandHandler : IToolHandler
    {
        private readonly string _command = "cmd.exe";
        protected string[]? arguments;

        public void StartEzCleaner()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine(string.Join('\n', arguments));
            builder.AppendLine("------------------------------------------------");
            builder.Append("Would you like to start the run now? (y/n)");
            Console.WriteLine(builder.ToString());
            var execute = Console.ReadLine();

            try
            {
                if (execute.ToLower().Equals("y"))
                    ExecuteCommands();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void ExecuteCommands()
        {
            Logger? logger = new Logger();

            foreach (string argument in arguments)
            {
                logger.Argument = argument;
                logger.AppendNewCleanerRunLine();

                try
                {
                    int exitCode = ExecuteCommand(_command, argument);
                    logger.AppendExitCodeLine(exitCode);
                }
                catch (Exception ex)
                {
                    logger.AppendExceptionMessage(ex.Message);
                }
            }

            if (logger != null)
                logger.SaveLoggerFile();
        }

        public int ExecuteCommand(string command, string argument)
        {
            using (Process process = new Process())
            {
                ProcessStartInfo processStartInfo = new ProcessStartInfo
                {
                    FileName = command,
                    Arguments = argument,
                };

                process.StartInfo = processStartInfo;
                process.Start();
                Console.WriteLine("Scanning...");
                process.WaitForExit();

                return process.ExitCode;
            }
        }
    }
}
