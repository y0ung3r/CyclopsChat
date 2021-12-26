﻿using System;
using Cyclops.Xmpp.Data;

namespace Cyclops.Core.CustomEventArgs
{
    public class ErrorEventArgs : EventArgs
    {
        public ErrorEventArgs(IEntityIdentifier from, string msg)
        {
            From = from;
            Message = msg;
        }

        public IEntityIdentifier From { get; private set; }
        public string Message { get; private set; }
    }
}
