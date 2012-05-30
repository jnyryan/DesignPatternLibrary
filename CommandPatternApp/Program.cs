/*
 * 
 * 
 * 
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using patchapps.CommandPattern.Commands;

namespace patchapps.CommandPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("App:   MongoDbConsole");

                var availableCommands = GetAvailableCommands();

                if (args.Length == 0)
                {
                    PrintUsage(availableCommands);
                    return;
                }
                CommandParser.Run(args, availableCommands);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }

        static public void PrintUsage(IEnumerable<ICommandFactory> availableCommands)
        {
            Console.WriteLine("Usage: CommandPattern CommandName Arguments");
            Console.WriteLine("       e.g CommandPattern init");
            Console.WriteLine("           CommandPattern alltests");
            Console.WriteLine("           CommandPattern runtest 6");
            Console.WriteLine("");
            Console.WriteLine("Available Commands:");
            foreach (var availableCommand in availableCommands)
            {
                Console.WriteLine("   {0} - {1}",availableCommand.CommandName, availableCommand.Description);
            }
        }

        /// <summary>
        /// When a new command class is added, add it here to be included in the command list.
        /// </summary>
        /// <returns></returns>
        static IEnumerable<ICommandFactory> GetAvailableCommands()
        {
            return new ICommandFactory[]
                       {
                           new InitializeApplicationCommand(),
                           new RunAllTestsCommand(),
                           new RunTestCommand(),
                       };
        }


    }
}
