using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CrazyEights.Classes
{
    static class Stats
    {
        static string path = "stats.txt";
        static int playerWon = 0;
        static int playerLost = 0;
        static int leastNumberOfCardsPlayed = 0;
        static int mostNumberOfCardsPlayed = 0;


        public static void UdpateStats(bool playerWonBool, int moveCount)
        {


            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    if (playerWonBool)
                    {
                        playerWon = 1;
                        playerLost = 0;
                    }
                    else
                    {
                        playerWon = 0;
                        playerLost = 1;
                    }

                    leastNumberOfCardsPlayed = mostNumberOfCardsPlayed = moveCount;

                    sw.WriteLine(playerWon);
                    sw.WriteLine(playerLost);
                    sw.WriteLine(leastNumberOfCardsPlayed);
                    sw.WriteLine(mostNumberOfCardsPlayed);

                }
                return;
            }



            string output = "";
            // Open the file to read from.
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    //Console.WriteLine(s);
                    output += s + ",";
                }
            }

            //Get the old records 
            string[] oldData = output.Split(',');
            int playerWon_old = int.Parse(oldData[0]);
            int playerLost_old = int.Parse(oldData[1]);
            int leastNumberOfCardsPlayed_old = int.Parse(oldData[2]);
            int mostNumberOfCardsPlayed_old = int.Parse(oldData[3]);

            //Update the records accordingly
            if (playerWonBool)
            {
                playerWon = playerWon_old + 1;
            }
            else
            {
                playerLost = playerLost_old + 1;
            }

            if (leastNumberOfCardsPlayed_old < moveCount)
            {
                leastNumberOfCardsPlayed = leastNumberOfCardsPlayed_old;
            }
            else
            {
                leastNumberOfCardsPlayed = moveCount;
            }

            if (mostNumberOfCardsPlayed_old > moveCount)
            {
                mostNumberOfCardsPlayed = mostNumberOfCardsPlayed_old;
            }
            else
            {
                mostNumberOfCardsPlayed = moveCount;
            }


            // Create a file to write to.
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine(playerWon);
                sw.WriteLine(playerLost);
                sw.WriteLine(leastNumberOfCardsPlayed);
                sw.WriteLine(mostNumberOfCardsPlayed);

            }
        }

        public static string GetStats()
        {
            string output = "";
            // Open the file to read from.
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    //Console.WriteLine(s);
                    output+=s+",";
                }
            }
            return output;
        }
    }
}
