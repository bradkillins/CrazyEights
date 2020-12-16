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
        
        public static void UdpateStats(int playerWon, int playerLost, int leastNumberOfCardsPlayed, int mostNumberOfCardsPlayed)
        {
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
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
            playerWon += playerWon_old;
            playerLost += playerLost_old;

            if (leastNumberOfCardsPlayed_old < leastNumberOfCardsPlayed)
            {
                leastNumberOfCardsPlayed = leastNumberOfCardsPlayed_old;
            }

            if (mostNumberOfCardsPlayed_old > mostNumberOfCardsPlayed)
            {
                mostNumberOfCardsPlayed = mostNumberOfCardsPlayed_old;
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
