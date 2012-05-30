using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace patchapps.CommandPattern.Commands
{
    public class InvalidCommand: ICommand
    {
        public string Name { get; set; }

        public void Execute()
        {
            Console.WriteLine("Couldn't find command: " + Name);
        }
    }
}
