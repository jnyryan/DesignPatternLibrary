using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace patchapps.CommandPattern.Commands
{
    public class RunAllTestsCommand : ICommand, ICommandFactory
    {
        public void Execute()
        {
            // Do some work in here
            Console.WriteLine("Running all tests");
        }

        public string CommandName
        {
            get { return "alltests"; }
        }

        public string Description
        {
            get { return "Run all tests"; }
        }

        public ICommand MakeCommand(string[] args)
        {
            return new RunAllTestsCommand();
        }
    }
}
