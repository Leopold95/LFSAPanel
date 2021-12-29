using LFSAPanel.Core.Engine;
using LFSAPanel.Core.System;
using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace LFSAPanel.ViewModels
{
    public class ConsolePageViewModel : BindableObject
    {
        private Thread _thread;
        private ServerInfoManager _infoManager;
        private WebSocketRemouter _wsRemouter;

        //ClientWebSocket ws;
        private ClientWebSocket _ws;
        WebSocketReceiveResult res;
        byte[] buffer = new byte[1024];

        public ConsolePageViewModel()
        {
            _infoManager = ServerInfoManager.GetInstance();
            _wsRemouter = new WebSocketRemouter();
        }

        private string _serverName = "";
        public string ServerName { get => _serverName; set { _serverName = value; OnPropertyChanged(); } }

        private string _serverIpPort = "";
        public string ServerIpPort { get => _serverIpPort; set { _serverIpPort = value; OnPropertyChanged(); } }

        private string _serverTickeId = "";
        public string ServerTickeId { get => _serverTickeId; set { _serverTickeId = value; OnPropertyChanged(); } }

        private string _serverCpuUsage = "";
        public string ServerCpuUsage { get => _serverCpuUsage; set { _serverCpuUsage = value; OnPropertyChanged(); } }

        private string _serverMemoryUsage = "";
        public string ServerMemoryUsage { get => _serverMemoryUsage; set { _serverMemoryUsage = value; OnPropertyChanged(); } }

        private string _serverDiskUsage = "";
        public string ServerDiskUsage { get => _serverDiskUsage; set { _serverDiskUsage = value; OnPropertyChanged(); } }

        public void OnAppear()
        {
            _thread = new Thread(new ThreadStart(Do));
            _thread.Start();

            ServerName = "";
            ServerTickeId = "";
            ServerIpPort = "";
            ServerCpuUsage = "";
            ServerMemoryUsage = "";
            ServerDiskUsage = "";


            //_ws = new ClientWebSocket();
            //_ws.Options.SetRequestHeader("Origin", "https://auth.worldhosts.ru");

            //_ws.ConnectAsync(new Uri(_infoManager.GetWebsocketInfo().Data.Socket.Replace("\\", "")), CancellationToken.None).Wait();
            //res = _ws.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None).Result;
            //Console.WriteLine($"Recieved: {Encoding.UTF8.GetString(buffer, 0, res.Count)}");
        }

        public void OnDisappear()
        {
            _thread.Abort();
        }

        private void Do()
        {
            ServerName = _infoManager.GetServerDetails().Attributes.Name;

            ServerTickeId = Preferences.Get("CurrentServer", string.Empty);

            for (byte i = 0; i < _infoManager.GetNetwork().Data.Count; i++)
            {
                if (_infoManager.GetNetwork().Data[i].Attributes.IsDefault)
                {
                    ServerIpPort = _infoManager.GetNetwork().Data[i].Attributes.Ip.ToString() + ":" +
                        _infoManager.GetNetwork().Data[i].Attributes.Port.ToString();
                }
            }

            ClientWebSocket socket = new ClientWebSocket();
            Console.WriteLine("Connecting");
            socket.Options.SetRequestHeader("Origin", "https://auth.worldhosts.ru");
            socket.ConnectAsync(new Uri("wss://mc1.worldhosts.fun:9999/api/servers/f8abdf29-1fd9-448d-9d3c-ecd1f999deba/ws"), CancellationToken.None).Wait();


            //Console.WriteLine(_infoManager.GetWebsocketInfo().Data.Socket.Replace("\\", ""));
            //string s = _infoManager.GetWebsocketInfo().Data.Socket.Replace("\\", "");
            //_wsRemouter.Connect(s);
        }
    }
}
