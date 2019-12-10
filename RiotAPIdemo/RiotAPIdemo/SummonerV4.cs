using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Web;
using Newtonsoft.Json;

namespace RiotAPIdemo
{
    public class SummonerV4
    {
        public static readonly string ApiKey = "RGAPI-3cdfdd94-1900-459c-a5f5-23b13870dd6d";
        public static Uri APIBaseAddress = new Uri("https://na1.api.riotgames.com/lol/summoner/v4/summoners");
        public HttpClient client { get; set; }

        public SummonerV4()
        {
            client = new HttpClient
            {
                BaseAddress = APIBaseAddress
            };

        }

        public Summoner GetSummonerByName(string summonerName)
        {
            var uriBuilder = new UriBuilder($"{APIBaseAddress}/by-name/{summonerName}");
            var query = HttpUtility.ParseQueryString(uriBuilder.Query);
            query["api_key"] = ApiKey;
            uriBuilder.Query = query.ToString();
            string requestUri = uriBuilder.ToString();
            //Result call is a blocking call
            var response = client.GetAsync(requestUri).Result;
            if(response.IsSuccessStatusCode == false)
            {
                throw new Exception($"Request is fucked, yo. Response: {response.StatusCode}");
            }

            string jsonResponse = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<Summoner>(jsonResponse);
        }

        public async Task<Summoner> GetSummonerByNameAsync(string summonerName)
        {
            var uriBuilder = new UriBuilder($"{APIBaseAddress}/by-name/{summonerName}");
            var query = HttpUtility.ParseQueryString(uriBuilder.Query);
            query["api_key"] = ApiKey;
            uriBuilder.Query = query.ToString();
            string requestUri = uriBuilder.ToString();

            var response = await 


        }



    }
}
