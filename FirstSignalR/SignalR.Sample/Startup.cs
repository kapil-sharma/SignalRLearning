﻿using FirstSignalR.Chat;
using Microsoft.Owin;
using Owin;
[assembly: OwinStartup(typeof(Microsoft.AspNet.SignalR.StockTicker.Startup), "ConfigureSignalR")]
namespace Microsoft.AspNet.SignalR.StockTicker
{
    public static class Startup
    {
        public static void ConfigureSignalR(IAppBuilder app)
        {
            // For more information on how to configure your application using OWIN startup, visit http://go.microsoft.com/fwlink/?LinkID=316888
             app.MapSignalR();
             app.MapConnection<ChatConnection>("/chatapp", new ConnectionConfiguration { });
        }
    }
}