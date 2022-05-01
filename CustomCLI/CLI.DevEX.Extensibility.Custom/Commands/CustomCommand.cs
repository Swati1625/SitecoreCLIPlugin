using Sitecore.Devex.Client.Cli.Extensibility.Subcommands;
using System.CommandLine;

namespace CLI.DevEX.Extensibility.Custom.Commands
{
    public class CustomCommand: Command, ISubcommand
    {
        public CustomCommand(string name, string description = null)
     : base(name, description)
        {
        }
    }
}
