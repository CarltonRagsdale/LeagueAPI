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
        public static readonly string ApiKey = "RGAPI-b7c38ffa-68f1-47f1-90ab-8558259cc098";
        public static Uri APIBaseAddress = new Uri("https://na1.api.riotgames.com/lol/summoner/v4/summoners");
	public static Uri APIBaseAddress2 = new Uri("https://na1.api.riotgames.com/lol/champion-mastery/v4/champion-masteries");
        public HttpClient client { get; set; }

        public SummonerV4()
        {
            client = new HttpClient
            {
                BaseAddress = APIBaseAddress
            };

        }

	public Champion-Mastery getChampionMastery(string encryptedSummonerID, long championId)
	{
		var uriBuilder = new UriBuilder($"{APIBaseAddress2}/by-summoner/{encryptedSummonerId}/by-champion/{championId}");
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
            return JsonConvert.DeserializeObject<Champion-Mastery>(jsonResponse);

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
