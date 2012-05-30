using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace patchapps.CommandPattern.Commands
{
    public class RunTestCommand : ICommand, ICommandFactory
    {
        public int TestNumber { get; set; }

        public void Execute()
        {
            // Do some work in here
            Console.WriteLine("Running test number " + TestNumber);
        }

        public string CommandName
        {
            get { return "runtest"; }
        }

        public string Description
        {
            get { return "Run individual test"; }
        }

        public ICommand MakeCommand(string[] args)
        {
            return new RunTestCommand()
            {
                TestNumber = int.Parse(args[1]),
            };
        }
    }
}
