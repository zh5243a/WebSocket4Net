﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SuperSocket.ClientEngine;

namespace WebSocket4Net.Command
{
    public class Pong : WebSocketCommandBase
    {
        public override void ExecuteCommand(WebSocket session, WebSocketCommandInfo commandInfo)
        {
            session.LastActiveTime = DateTime.Now;
        }

        public override string Name
        {
            get { return OpCode.Pong.ToString(); }
        }
    }
}