namespace EzCleaner.Utilities
{
    internal static class Help
    {
        public static void Display()
        {
            Console.WriteLine("Help information");
            Console.WriteLine("");

            Console.WriteLine("Usage:");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("");

            Console.WriteLine("EzCleaner.exe");
            Console.WriteLine("     Runs the EzCleaner cleaning with the default commands and the security scan in fast mode");
            Console.WriteLine("EzCleaner.exe 1");
            Console.WriteLine("     Runs the EzCleaner cleaning tool with the default commands");
            Console.WriteLine("EzCleaner.exe 2");
            Console.WriteLine("     Runs the EzCleaner security scan in fast mode");
            Console.WriteLine("EzCleaner.exe ?");
            Console.WriteLine("     Displays the help page for the EzCleaner");
            Console.WriteLine("");

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Cleaning");
            Console.WriteLine("");

            Console.WriteLine("EzCleaner.exe 1 [argument,argument,argument,...]");
            Console.WriteLine("");

            Console.WriteLine(@"EzCleaner.exe 1 ipconfig/flushDNS,%temp%\*.* /s /q");
            Console.WriteLine("     Runs the EzCleaner cleaning with custom commands");
            Console.WriteLine("");

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Security Scan");
            Console.WriteLine("");

            Console.WriteLine("EzCleaner.exe 2 [option]");
            Console.WriteLine("");

            Console.WriteLine("EzCleaner.exe 2 fast");
            Console.WriteLine("     Runs the EzCleaner security scan in fast mode");
            Console.WriteLine("EzCleaner.exe 2 full");
            Console.WriteLine("     Runs the EzCleaner security scan in full mode");

            Console.ReadKey();
        }
    }
}
