using System;
using System.Collections.Generic;

namespace PeepingTomZ.Ipc.From {
    [Serializable]
    public class AllTargetersMessage : IFromMessage {
        public List<(Targeter targeter, bool currentlyTargeting)> Targeters { get; }

        public AllTargetersMessage(List<(Targeter, bool)> targeters) {
            this.Targeters = targeters;
        }
    }
}
