﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoiresServer.Interfaces.Config
{
    public interface IServerType
    {
        string Name { get; set; }
        IServerType GetServerType(int serverType);
    }
}
