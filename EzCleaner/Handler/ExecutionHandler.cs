using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzCleaner.Handler
{
    internal static class ExecutionHandler
    {
        public static void ExecuteDefaultCommands()
        {
            CleanCommandHandler cleanCommandHandler = new CleanCommandHandler();
            SecurityCommandHandler securityCommandHandler = new SecurityCommandHandler();
            cleanCommandHandler.StartCleanCommands();
            securityCommandHandler.StartSecurityScan();
        }

        public static void ExecuteCleanCommands()
        {
            CleanCommandHandler cleanCommandHandler = new CleanCommandHandler();
            cleanCommandHandler.StartCleanCommands();
        }

        public static void ExecuteCustomCommands(string[] arguments)
        {
            CleanCommandHandler cleanCommandHandler = new CleanCommandHandler(arguments);
            cleanCommandHandler.StartCleanCommands();
        }

        public static void ExecuteFastSecurityScan()
        {
            SecurityCommandHandler securityCommandHandler = new SecurityCommandHandler();
            securityCommandHandler.StartSecurityScan();
        }

        public static void ExecuteFullSecurityScan()
        {
            SecurityCommandHandler securityCommandHandler = new SecurityCommandHandler(false);
            securityCommandHandler.StartSecurityScan();
        }
    }
}
