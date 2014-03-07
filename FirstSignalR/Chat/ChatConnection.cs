using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstSignalR.Chat
{
    public class ChatConnection : PersistentConnection
    {
        protected override System.Threading.Tasks.Task OnReceived(IRequest request, string connectionId, string data)
        {
            if(data.StartsWith("send:"))
            return Connection.Broadcast(data);
            else
                if (data.StartsWith("echo:"))
                {
                    return Connection.Send(connectionId, data);
                }
            return Connection.Send(connectionId, "unknown ");
               //return base.OnReceived(request, connectionId, data);
        }
    }
}