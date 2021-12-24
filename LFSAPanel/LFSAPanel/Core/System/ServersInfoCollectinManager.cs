//using LFSAPanel.Core.Engine;
//using LFSAPanel.Models;
//using LFSAPanel.Models.AccauntDetails;
//using LFSAPanel.Models.AllServersDetailsList;
//using LFSAPanel.Models.Resourses;
//using LFSAPanel.Models.ServerConsoleDetails;
//using LFSAPanel.Models.ServerDetails;
//using LFSAPanel.Models.ServerNetwork;
//using Newtonsoft.Json;
//using System;
//using System.Collections.Generic;
//using System.Collections.ObjectModel;
//using System.Text;
//using Xamarin.Essentials;
//using Xamarin.Forms;

//namespace LFSAPanel.Core.System
//{
//    public class ServersInfoCollectinManager
//    {
//        private static ServersInfoCollectinManager _instance;
//        private ServersInfoCollectinManager() 
//        {
//            _curl = new Curl();
//            _curredServerIdentifier = Preferences.Get("CurrentServer", string.Empty);
//        }
//        public static ServersInfoCollectinManager GetInstance()
//        {
//            if (_instance == null) _instance = new ServersInfoCollectinManager();
//            return _instance;
//        }

//        private Curl _curl;
//        private string _curredServerIdentifier;

//        #region AllServersDetailsList
//        AllServersDetailsList _allServersDetailsList;
//        public AllServersDetailsList GetAllServersDetailsList()
//        {
//            return _allServersDetailsList ?? throw new Exception("Server Details List not updated");
//        }

//        public void UpdateAllServersDetailsList()
//        {
//            _allServersDetailsList = JsonConvert.DeserializeObject<AllServersDetailsList>(_curl.GetRequest(
//                "https://auth.worldhosts.ru/api/client", "Bearer " + Constants.Bearer
//                ).Result);
//        }
//        #endregion

//        #region ServerDetails
//        public ServerDetails GetServerDetails()
//        {
//            ServerDetails serverDetails = JsonConvert.DeserializeObject<ServerDetails>(_curl.GetRequest(
//                "https://auth.worldhosts.ru/api/client/servers/" + _curredServerIdentifier, "Bearer " + Constants.Bearer
//                ).Result);

//            return serverDetails;
//        }
//        #endregion

//        #region UsedResourses
//        public UsedResourses GetAllUsedResourses()
//        {
//            UsedResourses usedResourses = JsonConvert.DeserializeObject<UsedResourses>(_curl.GetRequest(
//                "https://auth.worldhosts.ru/api/client/servers/" + _curredServerIdentifier + "/resources", "Bearer " + Constants.Bearer
//                ).Result);

//            return usedResourses;
//        }
//        #endregion

//        #region Network
//        public Network GetNetwork()
//        {
//            Network net = JsonConvert.DeserializeObject<Network>(_curl.GetRequest(
//                "https://auth.worldhosts.ru/api/client/servers/" + _curredServerIdentifier + "/network/allocations", "Bearer " + Constants.Bearer
//                ).Result);

//            return net;
//        }
//        #endregion

//        #region ConsoleDetails
//        public WebsocketInfo GetWebsocketInfo()
//        {
//            WebsocketInfo consoleDetails = JsonConvert.DeserializeObject<WebsocketInfo>(_curl.GetRequest(
//                "https://auth.worldhosts.ru/api/client/servers/" + _curredServerIdentifier + "/websocket", "Bearer " + Constants.Bearer
//                ).Result);

//            return consoleDetails;
//        }
//        #endregion

//        #region AccauntDetails

//        public AccauntDetails GetAccauntDetails()
//        {
//            AccauntDetails accauntDetails = JsonConvert.DeserializeObject<AccauntDetails>(_curl.GetRequest(
//                "https://auth.worldhosts.ru/api/client/account", "Bearer " + Constants.Bearer
//                ).Result);

//            return accauntDetails;
//        }
//        #endregion
//    }
//}
