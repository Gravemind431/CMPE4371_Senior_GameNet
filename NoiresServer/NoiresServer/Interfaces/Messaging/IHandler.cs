using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoiresServer.Implementation.Messaging;

namespace NoiresServer.Interfaces.Messaging
{
    public interface IHandler<T>
    {
        MessageType Type { get; }
        byte Code { get; }
        int? SubCode { get; }
        bool HandleMessage(IMessage message, T peer);
    }
}
