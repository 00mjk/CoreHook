﻿using System;
using System.Collections.Generic;
using System.Text;
using CoreHook.IPC.Platform;
using System.IO.Pipes;

namespace CoreHook.FileMonitor
{
    public class PipePlatform : IPipePlatform
    {
        private int _maxConnections = 254;

        public NamedPipeServerStream CreatePipeByName(string pipeName)
        {
            return new NamedPipeServerStream(
             pipeName,
             PipeDirection.InOut,
             _maxConnections,
             PipeTransmissionMode.Byte,
             PipeOptions.Asynchronous,
             65536,
             65536
             );
        }
    }
}
