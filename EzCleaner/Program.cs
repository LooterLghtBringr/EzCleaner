namespace EzCleaner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0 || args == null)
            {
                Console.WriteLine("No arguments have been passed, so the default clean commands and the fast security scan is executed...");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                ExecuteDefaultCommands();
            }
            else if (args.Length == 1)
            {
                var firstArgument = args.First();
                if (firstArgument.Equals("1"))
                {
                    ExecuteCleanCommands();
                }
                else if (firstArgument.Equals("2"))
                {
                    ExecuteSecurityScan();
                }
                else
                {
                    Console.WriteLine("The given argument was invalid. It has to be either 1 or 2 for tool selection...");
                    Console.WriteLine("Press any key to leave the application...");
                    Console.ReadKey();
                }
            }
            else
            {
                //TODO: execute the chosen tool with the given parameters
                //cleanCommandHandler = new CleanCommandHandler(args);
            }
        }

        private static void ExecuteDefaultCommands()
        {
            CleanCommandHandler cleanCommandHandler = new CleanCommandHandler();
            SecurityCommandHandler securityCommandHandler = new SecurityCommandHandler();
            cleanCommandHandler.StartCleanCommands();
            securityCommandHandler.StartSecurityScan();
        }

        private static void ExecuteCleanCommands()
        {
            CleanCommandHandler cleanCommandHandler = new CleanCommandHandler();
            cleanCommandHandler.StartCleanCommands();
        }

        private static void ExecuteSecurityScan()
        {
            SecurityCommandHandler securityCommandHandler = new SecurityCommandHandler();
            securityCommandHandler.StartSecurityScan();
        }
    }
}
