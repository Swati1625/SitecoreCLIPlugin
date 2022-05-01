using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.Devex.Client.Cli.Extensibility;
using Sitecore.Devex.Client.Cli.Extensibility.Subcommands;
using CLI.DevEX.Extensibility.Custom.Commands;
using System;
using System.Collections.Generic;

namespace CLI.DevEX.Extensibility.Custom
{
    public class RegisterExtension : ISitecoreCliExtension
    {
        public IEnumerable<ISubcommand> AddCommands(IServiceProvider container)
        {
            if (container == null)
            {
                throw new ArgumentNullException(nameof(container));
            }

            CustomCommand customCommand = new CustomCommand("Custom", "This is a custom command");

            PrintCommand printCommand = container.GetRequiredService<PrintCommand>();
            customCommand.AddCommand(printCommand);

            return new ISubcommand[] { customCommand };
        }

        public void AddConfiguration(IConfigurationBuilder configBuilder)
        {
        }

        public void AddServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<CustomCommand>().AddSingleton<PrintCommand>();
        }
    }
}
