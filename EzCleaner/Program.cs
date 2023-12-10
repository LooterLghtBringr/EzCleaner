using System.Runtime.CompilerServices;
using EzCleaner.Handler;
using EzCleaner.Utilities;

namespace EzCleaner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0 || args == null)
            {
                Console.WriteLine("No arguments have been passed, so the default clean commands and the fast security scan is executed...");
                Console.WriteLine("Would you like to start the run now? (y/n)");
                var execute = Console.ReadLine();
                if (execute.ToLower().Equals("y"))
                    ExecutionHandler.ExecuteDefaultCommands();
            }
            else if (args.Length == 1)
            {
                var firstArgument = args.First();
                if (firstArgument.Equals("1"))
                {
                    ExecutionHandler.ExecuteCleanCommands();
                }
                else if (firstArgument.Equals("2"))
                {
                    ExecutionHandler.ExecuteFastSecurityScan();
                }
                else if (firstArgument.Equals("?"))
                {
                    Help.Display();
                }
                else
                {
                    Console.WriteLine("The given argument was invalid. It has to be either 1 or 2 for tool selection...");
                    Console.WriteLine("Press any key to leave the application...");
                    Console.ReadKey();
                }
            }
            else if (args.Length == 2)
            {
                var firstArgument = args.First();
                var secondArgument = args[1];
                if (firstArgument.Equals("1"))
                {
                    var arguments = secondArgument.Split(new char[] { ',' });
                    ExecutionHandler.ExecuteCustomCommands(arguments);
                }
                else if (firstArgument.Equals("2")) 
                {
                    if (secondArgument.Equals("fast"))
                    {
                        ExecutionHandler.ExecuteFastSecurityScan();
                    }
                    else if(secondArgument.Equals("full"))
                    {
                        ExecutionHandler.ExecuteFullSecurityScan();
                    }
                    else
                    {
                        Console.WriteLine("The given argument was invalid. It has to be either 'fast' or 'full' for mode selection...");
                        Console.WriteLine("Press any key to leave the application...");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("The given argument was invalid. It has to be either 1 or 2 for tool selection...");
                    Console.WriteLine("Press any key to leave the application...");
                    Console.ReadKey();
                }
            }
        }
    }
}
