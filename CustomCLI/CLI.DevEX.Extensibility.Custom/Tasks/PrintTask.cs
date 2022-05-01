using Spectre.Console;
using System.Threading.Tasks;

namespace CLI.DevEX.Extensibility.Custom.Tasks
{
    public class PrintTask
    {
        public async Task Execute(PrintTaskOptions options)
        {
            await PrintMessage(options);

        }
        private async Task PrintMessage(PrintTaskOptions options)
        {
            AnsiConsole.Write(new FigletText(options.Message).LeftAligned().Color(Color.Red));
        }
    }
}
