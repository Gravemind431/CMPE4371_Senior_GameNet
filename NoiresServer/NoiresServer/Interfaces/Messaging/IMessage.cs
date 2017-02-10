﻿using NoiresServer.Implementation.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoiresServer.Interfaces.Messaging
{
    public interface IMessage
    {
        MessageType Type { get; }
        byte Code { get; }
        int? SubCode { get; }
        Dictionary<byte, object> Parameters { get; }
    }
}
