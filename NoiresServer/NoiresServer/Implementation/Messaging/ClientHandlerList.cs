using NoiresServer.Interfaces.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoiresServer.Implementation.Messaging
{
    public class ClientHandlerList : IHandlerList<IClientPeer>
    {
        private readonly Dictionary<int, IHandler<IClientPeer>> _requestSubCodeHandlerList;
        private readonly Dictionary<int, IHandler<IClientPeer>> _requestCodeHandlerList;

        public ClientHandlerList(IEnumberable<IHandler<IClientPeer>> handlers)
        {
            _requestSubCodeHandlerList = new Dictionary<int, IHandler<IClientPeer>>();
            _requestCodeHandlerList = new Dictionary<int, IHandler<IClientPeer>>();
  
            foreach(var handler in handlers)
            {
                RegisterHandler(handler);
            }
        }

        public bool RegisterHandler(IHandler<IClientPeer> handler)
        {

        }
    }
}
