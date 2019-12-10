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

    public class Champion-Mastery
    {
	[JsonProperty("chestGranted")]
	public Boolean chestGranted { get; set; }

	[JsonProperty("championLevel")]
	public int championLevel { get; set; }

	[JsonProperty("championPoints")]
	public int championPoints { get; set; }

	[JsonProperty("championId")]
	public long championId { get; set; }

	[JsonProperty("championPointsUntilNextLevel")]
	public long championPointsUntilNextLevel { get; set; }

	[JsonProperty("lastPlayTime")]
	public long lastPlayTime { get; set; }	

	[JsonProperty("tokensEarned")]
	public int tokensEarned { get; set; }

	[JsonProperty("championPointsSinceLastLevel")]
	public long championPointsSinceLastLevel { get; set; }

	[JsonProperty("summonerId")]
	public string summonerId { get; set; }
}
