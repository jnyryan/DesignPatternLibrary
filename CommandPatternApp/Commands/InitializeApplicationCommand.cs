using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace patchapps.CommandPattern.Commands
{
    public class InitializeApplicationCommand: ICommand , ICommandFactory
    {
        public void Execute()
        {
            // Do some work in here
            Console.WriteLine("Initializing the application");
        }

        public string CommandName
        {
            get { return "init"; }
        }

        public string Description
        {
            get { return "Initialize the Application"; }
        }

        public ICommand MakeCommand(string[] args)
        {
            return new InitializeApplicationCommand();
        }
    }
}
