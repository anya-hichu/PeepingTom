﻿using System;

namespace PeepingTomZ.Ipc.From {
    [Serializable]
    public class NewTargeterMessage : IFromMessage {
        public Targeter Targeter { get; }

        public NewTargeterMessage(Targeter targeter) {
            this.Targeter = targeter;
        }
    }
}
