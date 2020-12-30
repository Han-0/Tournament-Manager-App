using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public static class TournamentLogic
    {
        // Order our list Randomly of teams
        // check if it is big enough, if not, add in byes
        // create our first round of matchups
        // create every round after that - 8 matchups - 4 matchups - 2 matchups - 1 matchup
        public static void createRounds(Tournament model)
        {
            List<TeamModel> randomizedTeams = randomizeOrder(model.EnteredTeams);
            int rounds = FindNumberOfRounds(randomizedTeams.Count);
            int byes = NumberofByes(rounds, randomizedTeams.Count);

            model.Rounds.Add(createFirstRound(byes, randomizedTeams));

            createOtherRounds(model, rounds);
        }

        private static void createOtherRounds(Tournament model, int rounds)
        {
            int round = 2;
            List<Matchup> previousRound = model.Rounds[0];
            List<Matchup> currRound = new List<Matchup>();
            Matchup currMatchup = new Matchup();

            while (round <= rounds)
            {
                foreach (Matchup match in previousRound)
                {
                    currMatchup.Entries.Add(new MatchupEntry { ParentMatchup = match });

                    if (currMatchup.Entries.Count > 1)
                    {
                        currMatchup.MatchupRound = round;
                        currRound.Add(currMatchup);
                        currMatchup = new Matchup();
                    }
                }

                model.Rounds.Add(currRound);
                previousRound = currRound;

                currRound = new List<Matchup>();
                round += 1;
            }
        }

        private static List<Matchup> createFirstRound(int byes, List<TeamModel> teams)
        {
            List<Matchup> output = new List<Matchup>();
            Matchup curr = new Matchup();

            foreach (TeamModel team in teams)
            {
                curr.Entries.Add(new MatchupEntry { TeamCompeting = team });

                if (byes > 0 || curr.Entries.Count > 1)
                {
                    curr.MatchupRound = 1;
                    output.Add(curr);
                    curr = new Matchup();

                    if (byes > 0)
                    {
                        byes -= 1;
                    }
                }
            }
            return output;
        }

        private static int NumberofByes(int rounds, int numOfTeams)
        {
            int output = 0;
            int totalTeams = 1;

            for (int i = 1; i <= rounds; i++)
            {
                totalTeams *= 2;
            }

            output = totalTeams - numOfTeams;

            return output;
        }

        private static int FindNumberOfRounds(int teamCount)
        {
            int output = 1;
            int val = 2;

            while (val < teamCount)
            {
                output += 1;
                val *= 2;
            }

            return output;
        }

        private static List<TeamModel> randomizeOrder(List<TeamModel> teams)
        {
            return teams.OrderBy(x => Guid.NewGuid()).ToList();
        }
    }
}
