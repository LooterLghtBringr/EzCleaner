namespace EzCleaner.Interfaces
{
    internal interface IToolHandler
    {
        void StartEzCleaner();

        void ExecuteCommands();

        int ExecuteCommand(string command, string argument);
    }
}
