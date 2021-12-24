using LFSAPanel.Core.Engine;
using LFSAPanel.Models.AccauntDetails;
using LFSAPanel.Models.AllServersDetailsList;
using LFSAPanel.Models.Resourses;
using LFSAPanel.Models.ServerConsoleDetails;
using LFSAPanel.Models.ServerDetails;
using LFSAPanel.Models.ServerNetwork;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace LFSAPanel.Core.System
{
    public class ServerInfoManager
    {
        private static ServerInfoManager _instance;
        private ServerInfoManager()
        {
            _infoInit = new InfoInitialiser();
            _WSRemouter = new WebSocketRemouter();
            _bearer = Constants.Bearer;
            _host = "auth.worldhosts.ru";
            _currentServer = Preferences.Get("CurrentServer", string.Empty);
        }
        public static ServerInfoManager GetInstance()
        {
            if (_instance == null)
                _instance = new ServerInfoManager();
            return _instance;
        }


        private InfoInitialiser _infoInit;
        private WebSocketRemouter _WSRemouter;

        private AllServersDetailsList _allServersDetailsList;
        private ServerDetails _serverDetails;
        private WebsocketInfo _WSInfo;
        private AccauntDetails _accauntDetails;
        private Network _network;
        private Resources _resources;

        private string _bearer;
        private string _currentServer;
        private string _host;
        
        public ref AllServersDetailsList GetAllServersDetailsList()
        {
            _allServersDetailsList = _infoInit.GetData<AllServersDetailsList>($"https://{_host}/api/client", ref _bearer);
            return ref _allServersDetailsList;
        }

        public ref ServerDetails GetServerDetails()
        {
            _serverDetails = _infoInit.GetData<ServerDetails>($"https://{_host}/api/client/servers/{_currentServer}", ref _bearer);
            return ref _serverDetails;
        }

        public ref WebsocketInfo GetWebsocketInfo()
        {
            _WSInfo = _infoInit.GetData<WebsocketInfo>($"https://{_host}/api/client/servers/{_currentServer}/websocket", ref _bearer);
            return ref _WSInfo;
        }

        public ref AccauntDetails GetAccauntDetails()
        {           
            return ref _accauntDetails;
        }
        public void UpdateAccauntDetails()
        {
            _accauntDetails = _infoInit.GetData<AccauntDetails>($"https://{_host}/api/client/account", ref _bearer);
        }

        public ref Network GetNetwork()
        {
            _network = _infoInit.GetData<Network>($"https://{_host}/api/client/servers/{_currentServer}/network/allocations", ref _bearer);
            return ref _network;
        }

        public ref Resources GetResources()
        {
            _resources = _infoInit.GetData<Resources>($"https://{_host}/api/client/servers/{_currentServer}/resources", ref _bearer);
            return ref _resources;
        }



    }
}
