using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace LFSAPanel.Core.Engine
{
    public class InfoInitialiser : Curl
    {
        public T GetData<T>(string url, ref string bearer)
        {
            T s = JsonConvert.DeserializeObject<T>(GetRequest(url, bearer).Result);
            return s;
        }
        //public T PostData<T>(string json, string data)
        //{
        //    T s = JsonConvert.DeserializeObject<T>(PostData());
        //    return s;
        //}
    }
}
