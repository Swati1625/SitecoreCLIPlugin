using Sitecore.Devex.Client.Cli.Extensibility.Subcommands;
using CLI.DevEX.Extensibility.Custom.Tasks;
using System;
using System.Threading.Tasks;

namespace CLI.DevEX.Extensibility.Custom.Commands
{
    public class PrintCommand : SubcommandBase<PrintTask, PrintTaskOptions>
    {
        public PrintCommand(IServiceProvider container) : base("Print", "Print test message",  container)
        {
            AddOption(PrintArgOptions.Message);
        }

        protected override async Task<int> Handle(PrintTask task, PrintTaskOptions args)
        {
            args.Validate();
            await task.Execute(args).ConfigureAwait(false);
            return 0;
        }
    }
}
