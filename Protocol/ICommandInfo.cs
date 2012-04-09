﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperSocket.ClientEngine.Protocol
{
    public interface ICommandInfo
    {
        string Key { get; }
    }

    public interface ICommandInfo<TCommandData> : ICommandInfo
    {
        TCommandData Data { get; }
    }
}
