using LFSAPanel.Core.System;
using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Text;
using System.Threading;

namespace LFSAPanel.Core.Engine
{
    public class WebSocketRemouter
    {
        private ClientWebSocket _ws;
        public bool IsConnected { get; private set; }


        WebSocketReceiveResult res;

        public WebSocketRemouter()
        {
            _ws = new ClientWebSocket();
            _ws.Options.SetRequestHeader("Origin", "https://auth.worldhosts.ru");
        }


        public void Connect(string wsUrl)
        {
            try
            {
                _ws.ConnectAsync(new Uri("wss://mc1.worldhosts.fun:9999/api/servers/f8abdf29-1fd9-448d-9d3c-ecd1f999deba/ws"), CancellationToken.None).Wait();
                IsConnected = true;
            }
            catch (Exception ex)
            {
                IsConnected = false;
                Console.WriteLine(ex.Message);
            }          
        }

        

        public string ReceiveMessage()
        {
            byte[] buffer = new byte[1024];
            res = _ws.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None).Result;
            return Encoding.UTF8.GetString(buffer, 0, res.Count);
        }

        public void SendConsoleCommand(string command)
        {
            _ws.SendAsync(new ArraySegment<byte>(Encoding.ASCII.GetBytes("{\"event\":\"send command\",\"args\":[\"" + command + "\"]}")), WebSocketMessageType.Text, true, CancellationToken.None).Wait();
        }
        public void SendToken(string token)
        {
            _ws.SendAsync(new ArraySegment<byte>(Encoding.ASCII.GetBytes("{\"event\":\"auth\",\"args\":[\"" + token + "\"]}")), WebSocketMessageType.Text, true, CancellationToken.None).Wait();
        }
        public void SendPowerActin(PowerStates state)
        {
            switch (state)
            {
                case PowerStates.Start:                  
                    Send("start");
                    break;

                case PowerStates.Stop:
                    Send("stop");
                    break;

                case PowerStates.Restart:
                    Send("restart");
                    break;

                case PowerStates.Kill:
                    Send("kill");
                    break;
            }
            void Send(string s)
            {
                _ws.SendAsync(new ArraySegment<byte>(Encoding.ASCII.GetBytes("{\"event\":\"set state\",\"args\":[\"" + s + "\"]}")), WebSocketMessageType.Text, true, CancellationToken.None).Wait();

            }
        }

        public void RequestStats()
        {
            _ws.SendAsync(new ArraySegment<byte>(Encoding.ASCII.GetBytes("{\"event\":\"send stats\",\"args\":[null]}")), WebSocketMessageType.Text, true, CancellationToken.None).Wait();
        }
        public void RequestLogs()
        {
            _ws.SendAsync(new ArraySegment<byte>(Encoding.ASCII.GetBytes("{\"event\":\"send logs\",\"args\":[null]}")), WebSocketMessageType.Text, true, CancellationToken.None).Wait();
        }
    }
}
