using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace NBAStats
{
    public class GameFixtures
    {
        public static Dictionary<string, Dictionary<string, int>> info = new Dictionary<string, Dictionary<string, int>>();
        static void Main(string[] args)
        {
            List<List<string>> nbaGames = new List<List<string>>();
            nbaGames.Add(new List<string> { "Los Angeles Clippers", "104", "Dallas Mavericks", "88" });
            nbaGames.Add(new List<string> { "New York Knicks", "101", "Atlanta Hawks", "112" });
            nbaGames.Add(new List<string> { "Indiana Pacers", "103", "Memphis Grizzlies", "112" });
            nbaGames.Add(new List<string> { "Los Angeles Lakers", "111", "Minnesota Timberwolves", "112" });
            nbaGames.Add(new List<string> { "Phoenix Suns", "95", "Dallas Mavericks", "111" });
            nbaGames.Add(new List<string> { "Portland Trail Blazers", "112", "New Orleans Pelicans", "94" });
            nbaGames.Add(new List<string> { "Sacramento Kings", "104", "Los Angeles Clippers", "111" });
            nbaGames.Add(new List<string> { "Houston Rockets", "85", "Denver Nuggets", "105" });
            nbaGames.Add(new List<string> { "Memphis Grizzlies", "76", "Cleveland Cavaliers", "106" });
            nbaGames.Add(new List<string> { "Milwaukee Bucks", "97", "New York Knicks", "122" });
            nbaGames.Add(new List<string> { "Oklahoma City Thunder", "112", "San Antonio Spurs", "106" });
            nbaGames.Add(new List<string> { "Boston Celtics", "112", "Philadelphia 76ers", "95" });
            nbaGames.Add(new List<string> { "Brooklyn Nets", "100", "Chicago Bulls", "115" });
            nbaGames.Add(new List<string> { "Detroit Pistons", "92", "Utah Jazz", "87" });
            nbaGames.Add(new List<string> { "Miami Heat", "104", "Charlotte Hornets", "94" });
            nbaGames.Add(new List<string> { "Toronto Raptors", "106", "Indiana Pacers", "99" });
            nbaGames.Add(new List<string> { "Orlando Magic", "87", "Washington Wizards", "88" });
            nbaGames.Add(new List<string> { "Golden State Warriors", "111", "New Orleans Pelicans", "95" });
            nbaGames.Add(new List<string> { "Atlanta Hawks", "94", "Detroit Pistons", "106" });
            nbaGames.Add(new List<string> { "Chicago Bulls", "97", "Cleveland Cavaliers", "95" });
            nbaGames.Add(new List<string> { "San Antonio Spurs", "111", "Houston Rockets", "86" });
            nbaGames.Add(new List<string> { "Chicago Bulls", "103", "Dallas Mavericks", "102" });
            nbaGames.Add(new List<string> { "Minnesota Timberwolves", "112", "Milwaukee Bucks", "108" });
            nbaGames.Add(new List<string> { "New Orleans Pelicans", "93", "Miami Heat", "90" });
            nbaGames.Add(new List<string> { "Boston Celtics", "81", "Philadelphia 76ers", "65" });
            nbaGames.Add(new List<string> { "Detroit Pistons", "115", "Atlanta Hawks", "87" });
            nbaGames.Add(new List<string> { "Toronto Raptors", "92", "Washington Wizards", "82" });
            nbaGames.Add(new List<string> { "Orlando Magic", "86", "Memphis Grizzlies", "76" });
            nbaGames.Add(new List<string> { "Los Angeles Clippers", "115", "Portland Trail Blazers", "109" });
            nbaGames.Add(new List<string> { "Los Angeles Lakers", "97", "Golden State Warriors", "136" });
            nbaGames.Add(new List<string> { "Utah Jazz", "98", "Denver Nuggets", "78" });
            nbaGames.Add(new List<string> { "Boston Celtics", "99", "New York Knicks", "85" });
            nbaGames.Add(new List<string> { "Indiana Pacers", "98", "Charlotte Hornets", "86" });
            nbaGames.Add(new List<string> { "Dallas Mavericks", "87", "Phoenix Suns", "99" });
            nbaGames.Add(new List<string> { "Atlanta Hawks", "81", "Memphis Grizzlies", "82" });
            nbaGames.Add(new List<string> { "Miami Heat", "110", "Washington Wizards", "105" });
            nbaGames.Add(new List<string> { "Detroit Pistons", "94", "Charlotte Hornets", "99" });
            nbaGames.Add(new List<string> { "Orlando Magic", "110", "New Orleans Pelicans", "107" });
            nbaGames.Add(new List<string> { "Los Angeles Clippers", "130", "Golden State Warriors", "95" });
            nbaGames.Add(new List<string> { "Utah Jazz", "102", "Oklahoma City Thunder", "113" });
            nbaGames.Add(new List<string> { "San Antonio Spurs", "84", "Phoenix Suns", "104" });
            nbaGames.Add(new List<string> { "Chicago Bulls", "103", "Indiana Pacers", "94" });
            nbaGames.Add(new List<string> { "Milwaukee Bucks", "106", "Minnesota Timberwolves", "88" });
            nbaGames.Add(new List<string> { "Los Angeles Lakers", "104", "Portland Trail Blazers", "102" });
            nbaGames.Add(new List<string> { "Houston Rockets", "120", "New Orleans Pelicans", "100" });
            nbaGames.Add(new List<string> { "Boston Celtics", "111", "Brooklyn Nets", "105" });
            nbaGames.Add(new List<string> { "Charlotte Hornets", "94", "Chicago Bulls", "86" });
            nbaGames.Add(new List<string> { "Cleveland Cavaliers", "103", "Dallas Mavericks", "97" });

            foreach (List<string> list in nbaGames)
            {
                var homeTeam = list[0];
                var homeScore = Int32.Parse(list[1]);
                var homePoint = 0;

                var awayTeam = list[2];
                var awayScore = Int32.Parse(list[3]);
                var awayPoint = 0;

                if (homeScore > awayScore)
                {
                    homePoint = 3;
                }

                else if (homeScore < awayScore)
                {
                    awayPoint = 3;
                }

                SetTeamScoreAndPoint(homeTeam, homeScore, homePoint);
                SetTeamScoreAndPoint(awayTeam, awayScore, awayPoint);
            }

            foreach (string key in info.Keys)
            {

                if (!info.TryGetValue(key, out var insideDict))
                {
                    continue;
                }

                var message = $"{key} has scored {insideDict["score"]} points with {insideDict["points"]} points in ranking";
                Console.WriteLine(message);
            }
        }
        public static void SetTeamScoreAndPoint(string team, int teamScore, int teamPoint)
        {
            if (!info.ContainsKey(team)) { 
                info.Add(team, new Dictionary<string, int>()
                {
                    {
                        "points",teamPoint
                    },
                    {
                        "score",teamScore
                    }
                });
            }

            else
            {
                if (info.TryGetValue(team, out var stats))
                {
                    stats["points"] += teamPoint;
                    stats["score"] += teamScore;
                }
            }
        }
    }
}