using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzCleaner
{
    internal interface IToolHandler
    {
        void StartEzCleaner();

        void ExecuteCommands();

        int ExecuteCommand(string command, string argument);
    }
}
