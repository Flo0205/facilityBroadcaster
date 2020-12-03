using Synapse.Api.Plugin;

namespace Plugin
{
    [PluginInformation(
        Author = "Flo0205",
        Description = "Broadcasts custom messages for a configurable time at predefined times.",
        LoadPriority = int.MaxValue,
        Name = "facilityBroadcaster",
        SynapseMajor = 2,
        SynapseMinor = 0,
        SynapsePatch = 0,
        Version = "1.0.0"
        )]
    public class PluginClass : AbstractPlugin
    {
        [Synapse.Api.Plugin.Config(section = "facilityBroadcaster")]
        public static Config Config;
        public EventHandlers EventHandlers;

        public override void Load()
        {
            EventHandlers = new EventHandlers(this);
            SynapseController.Server.Logger.Info("facilityBroadcaster Load");
        }
    }
}
