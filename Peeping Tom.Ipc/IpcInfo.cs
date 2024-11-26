using Dalamud.Plugin;
using Dalamud.Plugin.Ipc;
using PeepingTomZ.Ipc.From;
using PeepingTomZ.Ipc.To;

namespace PeepingTomZ.Ipc {
    public static class IpcInfo {
        public const string FromRegistrationName = "PeepingTom.From";
        public const string ToRegistrationName = "PeepingTom.To";

        public static ICallGateProvider<IToMessage, object> GetProvider(IDalamudPluginInterface @interface) {
            return @interface.GetIpcProvider<IToMessage, object>(ToRegistrationName);
        }

        public static ICallGateSubscriber<IFromMessage, object> GetSubscriber(IDalamudPluginInterface @interface) {
            return @interface.GetIpcSubscriber<IFromMessage, object>(FromRegistrationName);
        }
    }
}
