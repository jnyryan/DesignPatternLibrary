using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace patchapps.CommandPattern.Commands
{
    public interface ICommand
    {
        void Execute();
    }

    public interface ICommandFactory
    {
        String CommandName { get; }
        String Description { get; }
        ICommand MakeCommand(string[] args);
    }

    public class CommandParser
    {
        private readonly IEnumerable<ICommandFactory> _availableCommands;

        public CommandParser(IEnumerable<ICommandFactory> availableCommands)
        {
            this._availableCommands = availableCommands;
        }

        static internal void Run(string[] args, IEnumerable<ICommandFactory> availableCommands)
        {
            var parser = new CommandParser(availableCommands);
            var command = parser.ParseCommand(args);
            command.Execute();
        }

        internal ICommand ParseCommand(String[] args)
        {            
            var requestedCommandName = args[0];
            var command = FindRequestedCommand(requestedCommandName);
            if(null == command)
                return new InvalidCommand{Name = requestedCommandName};
            return command.MakeCommand(args);
        }

        ICommandFactory FindRequestedCommand(String commandName)
        {
            return _availableCommands.FirstOrDefault(c => c.CommandName == commandName);
        }
    }
}
