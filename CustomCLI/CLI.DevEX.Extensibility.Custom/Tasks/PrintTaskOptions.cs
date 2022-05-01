using Sitecore.DevEx.Client.Tasks;

namespace CLI.DevEX.Extensibility.Custom.Tasks
{
    public class PrintTaskOptions : TaskOptionsBase
    {
        public string Message { get; set; }
        public override void Validate()
        {
            Require(nameof(Message));
        }
    }
}
