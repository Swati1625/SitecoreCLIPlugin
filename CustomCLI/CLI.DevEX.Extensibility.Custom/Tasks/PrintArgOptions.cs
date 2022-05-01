using System.CommandLine;

namespace CLI.DevEX.Extensibility.Custom.Tasks
{
    public class PrintArgOptions
    {
        public static readonly Option Message = new Option(new[] { 
            "--message", 
            "-m" },
            "Name to be displayed. Default: Swati Gupta")
        {
            Argument = new Argument<string>(() => "Swati Gupta")
        };
    }
}
