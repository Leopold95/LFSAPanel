using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace LFSAPanel.Core.Engine
{
    public class Curl
    {
        protected async Task<string> GetRequest(string url, string bearer)
        {
            string res = "";
            try
            {
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("Accept", "application/json");
                client.DefaultRequestHeaders.Add("Authorization", bearer);
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                res = await response.Content.ReadAsStringAsync();
            }
            catch (Exception exp)
            {
                Console.WriteLine("Ошибка в curl get запросе: " + exp.Message);
                Console.WriteLine("Результат заполса: " + res);
            }
            return res;
        }

        protected async Task PostRequest(string url, string bearer, string data)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("Authorization", bearer);
            HttpResponseMessage response = await client.PostAsync(url, new StringContent(data));
            response.EnsureSuccessStatusCode();
        }
    }
}
