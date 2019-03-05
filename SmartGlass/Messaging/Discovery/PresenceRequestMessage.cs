using SmartGlass.Common;

namespace SmartGlass.Messaging.Discovery
{
    /// <summary>
    /// Presence request message.
    /// Send from client to multicast / broadcast.
    /// Active consoles will respond with PresenceResponse.
    /// </summary>
    [MessageType(MessageType.PresenceRequest)]
    internal class PresenceRequestMessage : MessageBase<DiscoveryMessageHeader>
    {
        public uint Flags { get; set; }
        public DeviceType DeviceType { get; set; } = DeviceType.WindowsStore;
        public ushort MinVersion { get; set; } = 0;
        public ushort MaxVersion { get; set; } = 2;

        protected override void DeserializePayload(BEReader reader)
        {
            Flags = reader.ReadUInt32();
            DeviceType = (DeviceType)reader.ReadUInt16();
            MinVersion = reader.ReadUInt16();
            MaxVersion = reader.ReadUInt16();
        }

        protected override void SerializePayload(BEWriter writer)
        {
            writer.Write(Flags);
            writer.Write((ushort)DeviceType);
            writer.Write(MinVersion);
            writer.Write(MaxVersion);
        }
    }
}
