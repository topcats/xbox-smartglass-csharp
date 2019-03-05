using System;
using System.Threading.Tasks;
using SmartGlass.Messaging.Session.Messages;

namespace SmartGlass.Channels
{
    /// <summary>
    /// Input TV Remote channel.
    /// Handles TV streaming from USB tuner.
    /// (Seems broken on console side right now, 2019-04-02)
    /// </summary>
    public class InputTVRemoteChannel : IDisposable
    {
        private readonly ChannelMessageTransport _transport;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SmartGlass.Channels.InputTVRemoteChannel"/> class.
        /// </summary>
        /// <param name="transport">Base transport.</param>
        internal InputTVRemoteChannel(ChannelMessageTransport transport)
        {
            _transport = transport;
        }

        public void Dispose()
        {
            _transport.Dispose();
        }
    }
}
