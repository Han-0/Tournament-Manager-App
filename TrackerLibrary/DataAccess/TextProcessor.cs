using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// *load text file
// *convert text to a List<PrizeModel>
// find the max id
// add the new record with the new id (max+1)
// convert the prizes to a List<string>
// save List<string> text file

namespace TrackerLibrary.TextHelpers
{
    public static class TextProcessor
    {
        public static string FullFilePath(this string fileName)
        {
            return $"{ConfigurationManager.AppSettings["filePath"] }\\{ fileName }";
        }

        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }

        public static List<Prize> ConvertToPrizeModels(this List<string> lines)
        {
            List<Prize> output = new List<Prize>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                Prize p = new Prize();
                p.Id = int.Parse(cols[0]);
                p.PlaceNum = int.Parse(cols[1]);
                p.PlaceName = cols[2];
                p.PrizeAmount = decimal.Parse(cols[3]);
                p.prizePercentage = double.Parse(cols[4]);
                output.Add(p);
            }
            return output;
        }

        public static List<TeamModel> ConvertToTeamModels(this List<string> lines, string peopleFileName)
        {
            //id, team name, list of ids separated by the pipe
            //3,<Team name>, 1|3|5
            List<TeamModel> output = new List<TeamModel>();
            List<Person> people = peopleFileName.FullFilePath().LoadFile().ConvertToPersonModels();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                TeamModel t = new TeamModel();
                t.Id = int.Parse(cols[0]);
                t.TeamName = cols[1];

                string[] personIds = cols[2].Split('|');

                foreach (string id in personIds)
                {
                    t.TeamMembers.Add(people.Where(x => x.Id == int.Parse(id)).First());
                }
                output.Add(t);
            }
            return output;
        }

        public static List<Tournament> ConvertToTournamentModels(this List<string> lines
                                                                , string teamFileName
                                                                , string peopleFileName
                                                                , string prizesFileName)
        {
            //id,tournamentName,EntryFee,(id|id|id - entered teams),(id|id|id - prizes),(Rounds - id^id^id|id^id^id|id^id^id)
            List<Tournament> output = new List<Tournament>();
            List<TeamModel> teams = teamFileName.FullFilePath().LoadFile().ConvertToTeamModels(peopleFileName);
            List<Prize> prizes = prizesFileName.FullFilePath().LoadFile().ConvertToPrizeModels();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                Tournament tm = new Tournament();
                tm.Id = int.Parse(cols[0]);
                tm.tournamentName = cols[1];
                tm.EntryFee = decimal.Parse(cols[2]);

                string[] teamIds = cols[3].Split('|');
                foreach (string id in teamIds)
                {
                    tm.EnteredTeams.Add(teams.Where(x => x.Id == int.Parse(id)).First());
                }
                string[] prizeIds = cols[4].Split('|');
                foreach (string id in prizeIds)
                {
                    tm.Prizes.Add(prizes.Where(x => x.Id == int.Parse(id)).First());
                }

                //TODO - capture rounds information

                output.Add(tm);
            }

            return output;
        }

        public static List<Person> ConvertToPersonModels(this List<string> lines)
        {
            List<Person> output = new List<Person>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                Person p = new Person();
                p.Id = int.Parse(cols[0]);
                p.FirstName = cols[1];
                p.LastName = cols[2];
                p.EmailAddress = cols[3];
                p.CellphoneNum = cols[4];
                output.Add(p);
            }
            return output;
        }

        public static void SaveToTournamentFile(this List<Tournament> models, string fileName)
        {
            List<string> lines = new List<string>();
            foreach (Tournament tm in models)
            {
                lines.Add($@"{tm.Id},
                             {tm.tournamentName},
                             {tm.EntryFee},
                             {convertTeamListToString(tm.EnteredTeams)},
                             {convertPrizeListToString(tm.Prizes)},
                             {convertRoundListToString(tm.Rounds)}");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static void SaveToPrizeFile(this List<Prize> models, string fileName)
        {
            List<string> lines = new List<string>();
            foreach (Prize p in models)
            {
                lines.Add($"{p.Id},{p.PlaceNum},{p.PlaceName},{p.PrizeAmount},{p.prizePercentage}");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static void SaveToPeopleFile(this List<Person> models, string fileName)
        {
            List<string> lines = new List<string>();
            foreach (Person p in models)
            {
                lines.Add($"{p.Id},{p.FirstName},{p.LastName},{p.EmailAddress},{p.CellphoneNum}");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static void SaveToTeamFile(this List<TeamModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (TeamModel t in models)
            {
                lines.Add($"{ t.Id },{ t.TeamName },{ convertPeopleListToString(t.TeamMembers) }");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        private static string convertRoundListToString(List<List<Matchup>> rounds)
        {
            //Rounds - id ^ id ^ id | id ^ id ^ id | id ^ id ^ id
            string output = "";
            if (rounds.Count == 0)
            {
                return "";
            }

            foreach (List<Matchup> r in rounds)
            {
                output += $"{ convertMatchupListToString(r) }|";
            }

            output = output.Substring(0, output.Length - 1);
            return output;
        }

        private static string convertMatchupListToString(List<Matchup> matchups)
        {
            string output = "";
            if (matchups.Count == 0)
            {
                return "";
            }

            foreach (Matchup m in matchups)
            {
                output += $"{ m.Id }^";
            }

            output = output.Substring(0, output.Length - 1);
            return output;
        }

        private static string convertPrizeListToString(List<Prize> prizes)
        {
            string output = "";
            if (prizes.Count == 0)
            {
                return "";
            }

            foreach (Prize p in prizes)
            {
                output += $"{ p.Id }|";
            }

            output = output.Substring(0, output.Length - 1);
            return output;
        }

        private static string convertTeamListToString(List<TeamModel> teams)
        {
            string output = "";
            if (teams.Count == 0)
            {
                return "";
            }

            foreach (TeamModel t in teams)
            {
                output += $"{ t.Id }|";
            }

            output = output.Substring(0, output.Length - 1);
            return output;
        }

        private static string convertPeopleListToString(List<Person> people)
        {
            string output = "";
            if (people.Count == 0)
            {
                return "";
            }

            foreach (Person p in people)
            {
                output += $"{ p.Id }|";
            }

            output = output.Substring(0, output.Length - 1);
            return output;
        }
    }
}
