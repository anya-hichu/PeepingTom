﻿using System;

namespace PeepingTomZ.Ipc.From {
    [Serializable]
    public class StoppedTargetingMessage : IFromMessage {
        public Targeter Targeter { get; }

        public StoppedTargetingMessage(Targeter targeter) {
            this.Targeter = targeter;
        }
    }
}
