using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Magic_Destroyers
{
    public static class PlayersInfo
    {
        // fields
        public static string playerInfoDirectory;

        public static int[,] fullInfo;
        public static int[] scores;
        public static int[] levels;

        // method
        public static void Initialize()
        {
            playerInfoDirectory = Directory.GetCurrentDirectory()+ @"\PlayerInfo";
            fullInfo = new int[2, 6];
            scores = new int[6];
            levels = new int[6];
        }
        public static void Save()
        {

        }
        public static void UpdateFullInfo()
        {

        }
        public static void RetrieveFullInfo()
        {

        }
        public static void PrintFullInfo()
        { }
        public static void EraseFullInfo()
        { }
        public static void UpdateScores()
        { }
        public static void RetrieveScores()
        { }
        public static void PrintScores()
        { }
        public static void EraseScores()
        {

        }
        public static void UpdateLevels()
        { }
        public static void RetrieveLevels()
        { }
        public static void PrintLevels()
        { }
        public static void EraseLevels()
        { }
    }
}
