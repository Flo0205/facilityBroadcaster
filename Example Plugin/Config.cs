using Synapse.Config;
using System.ComponentModel;

namespace Plugin
{
    public class Config : IConfigSection
    {
        //OnStart
        [Description("OnRoundStart: How long should the message be shown?")]
        public ushort startTime = 5;
        [Description("OnRoundStart: What is the message?")]
        public string startMessage = "";
        [Description("OnRoundStart: Should it be send instantly?")]
        public bool startSendInstant = false;

        //OnEnd
        [Description("OnRoundEnd: How long should the message be shown?")]
        public ushort endTime = 5;
        [Description("OnRoundEnd: What is the message?")]
        public string endMessage = "";
        [Description("OnRoundEnd: Should it be send instantly?")]
        public bool endSendInstant = false;

        //OnDecon
        [Description("OnLCZDecontamination: How long should the message be shown?")]
        public ushort deconTime = 5;
        [Description("OnLCZDecontamination: What is the message?")]
        public string deconMessage = "";
        [Description("OnLCZDecontamination: Should it be send instantly?")]
        public bool deconSendInstant = false;

        //OnNuke
        [Description("OnWarheadDetonation: How long should the message be shown?")]
        public ushort nukeTime = 5;
        [Description("OnWarheadDetonation: What is the message?")]
        public string nukeMessage = "";
        [Description("OnWarheadDetonation: Should it be send instantly?")]
        public bool nukeSendInstant = false;

        //On106Contain
        [Description("OnScp106Containment: How long should the message be shown?")]
        public ushort oldManContainTime = 5;
        [Description("OnScp106Containment: What is the message?")]
        public string oldManContainMessage = "";
        [Description("OnScp106Containment: Should it be send instantly?")]
        public bool oldManContainSendInstant = false;

        //OnFemurEnter
        [Description("OnPlayerEnterFemur: How long should the message be shown?")]
        public ushort femurEnterTime = 5;
        [Description("OnPlayerEnterFemur: What is the message?")]
        public string femurEnterMessage = "";
        [Description("OnPlayerEnterFemur: Should it be send instantly?")]
        public bool femurEnterSendInstant = false;
    }
}
