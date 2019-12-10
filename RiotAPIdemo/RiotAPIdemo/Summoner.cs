using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;


namespace RiotAPIdemo
{
    public class Summoner
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("accountId")]
        public string AccountID { get; set; }

        [JsonProperty("puuid")]
        public string Puuid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("revisionDate")]
        public long RevisionDate { get; set; }

        [JsonProperty("profileIconId")]
        public int ProfileIconID { get; set; }

        [JsonProperty("summonerLevel")]
        public long SummonerLevel { get; set; }



    }
}
