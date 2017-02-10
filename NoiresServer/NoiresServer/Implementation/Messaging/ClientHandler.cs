using NoiresServer.Interfaces.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoiresServer.Implementation.Messaging
{
    public abstract class ClientHandler : IHandler<IClientPeer>
    {
        public abstract MessageType Type { get; }
        public abstract byte Code { get; }
        public abstract int? SubCode { get; }

        public bool HandlerMessage(IMessage message, IClientPeer peer)
        {
            OnHandleMessage(message, peer);
            return true;
        }

        protected abstract bool OnHandleMessage(IMessage message, IClientPeer peer);

         
    }
}
