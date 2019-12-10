using System;
using MingweiSamuel.Camille;
using MingweiSamuel.Camille.Enums;

namespace RiotAPIdemo
{
    class Program
    {
        static void Main(string[] args)
        {        
            string userinput;
            
            SummonerV4 summonerApi = new SummonerV4();
            Console.WriteLine("Enter a Leauge of Legends username: ");
            userinput = Console.ReadLine();
            var response = summonerApi.GetSummonerByName($"{userinput}");
            Console.WriteLine($"------From Riot's Servers-------\nName: {response.Name} \nLevel: {response.SummonerLevel}");
        }
    }
}
