using Synapse;

namespace Plugin
{
    public class EventHandlers
    {
        public EventHandlers(PluginClass plugin)
        {
            Server.Get.Events.Round.RoundStartEvent += OnStart;
            Server.Get.Events.Round.RoundEndEvent += OnEnd;
            Server.Get.Events.Map.LCZDecontaminationEvent += OnDecon;
            Server.Get.Events.Map.WarheadDetonationEvent += OnNuke;
            Server.Get.Events.Scp.Scp106.Scp106ContainmentEvent += On106Contain;
            Server.Get.Events.Player.PlayerEnterFemurEvent += OnFemurEnter;
        }

        private void OnStart()
        {
            SynapseController.Server.Map.SendBroadcast(PluginClass.Config.startTime, PluginClass.Config.startMessage, PluginClass.Config.startSendInstant);
        }

        private void OnEnd()
        {
            SynapseController.Server.Map.SendBroadcast(PluginClass.Config.endTime, PluginClass.Config.endMessage, PluginClass.Config.endSendInstant);
        }

        private void OnDecon(Synapse.Api.Events.SynapseEventArguments.LCZDecontaminationEventArgs ev)
        {
            SynapseController.Server.Map.SendBroadcast(PluginClass.Config.deconTime, PluginClass.Config.deconMessage, PluginClass.Config.deconSendInstant);
        }

        private void OnNuke()
        {
            SynapseController.Server.Map.SendBroadcast(PluginClass.Config.nukeTime, PluginClass.Config.nukeMessage, PluginClass.Config.nukeSendInstant);
        }

        private void On106Contain(Synapse.Api.Events.SynapseEventArguments.Scp106ContainmentEventArgs ev)
        {
            SynapseController.Server.Map.SendBroadcast(PluginClass.Config.oldManContainTime, PluginClass.Config.oldManContainMessage, PluginClass.Config.oldManContainSendInstant);
        }

        private void OnFemurEnter(Synapse.Api.Events.SynapseEventArguments.PlayerEnterFemurEventArgs ev)
        {
            SynapseController.Server.Map.SendBroadcast(PluginClass.Config.femurEnterTime, PluginClass.Config.femurEnterMessage, PluginClass.Config.femurEnterSendInstant);
        }
    }
}
