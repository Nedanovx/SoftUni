using CommandPattern.Core.Contracts;
using System;
using System.Linq;
using System.Reflection;

namespace CommandPattern.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            string[] arguments = args.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string commandName = arguments[0];
            string[] commandArgs = arguments.Skip(1).ToArray();

            Type commandType = Assembly.GetEntryAssembly().GetTypes().FirstOrDefault(x=>x.Name == $"{commandName}Command");

            ICommand cmdInstance = Activator.CreateInstance(commandType) as ICommand;

            return cmdInstance.Execute(commandArgs);
        }
    }
}
