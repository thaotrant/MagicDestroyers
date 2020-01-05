using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Characters;

namespace Magic_Destroyers
{
    public static class PlayersInfo
    {
        // fields
        private static string playerInfoDirectoryPath = @"Info\";
        private static string playerInfoFileName = "PlayersInfo.txt";
        private static DirectoryInfo playersInfoDir = new DirectoryInfo(playerInfoDirectoryPath);
        private static FileInfo playersInfoFile = new FileInfo(Path.Combine(playerInfoDirectoryPath,playerInfoFileName));
        public static List<string[]> fullInfo = new List<string[]>();

        //public static int[] scores;
        //public static int[] levels;

        // method
        public static void Initialize(List<Character> characters)
        {
            if(!playersInfoDir.Exists)
            {
                playersInfoDir.Create();
            }

            if(!playersInfoFile.Exists)
            {
                playersInfoFile.Create().Close();
                
                using(StreamWriter sw = playersInfoFile.CreateText())
                {
                    foreach(var character in characters)
                    {
                        sw.WriteLine($"{character.Name},{character.Score},{character.Level}");
                    }
                }
            }
            using (StreamReader sr = playersInfoFile.OpenText())
            {
                string line = string.Empty;
                while((line = sr.ReadLine()) != null)
                {
                    fullInfo.Add(line.Split(','));
                }
            }
            for (int i = 0; i < characters.Count; i++)
            {
                for (int j = 0; j < characters.Count; j++)
                {
                    if(characters[i].Name == fullInfo[j][0])
                    {
                        characters[i].Score = Convert.ToInt32(fullInfo[j][1]);
                        characters[i].Level = Convert.ToInt32(fullInfo[j][2]);
                    }
                }
            }
        }
        public static void Save(List<Character> characters)
        {
             using(StreamWriter sw = playersInfoFile.CreateText())
            {
                foreach(var character in characters)
                {
                    sw.WriteLine(string.Join(",", $"{character.Name},{character.Score},{character.Level}"));
                }
            }
        }
        public static void UpdateFullInfo(List<Character> characters)
        {
            for (int i = 0; i < fullInfo.Count; i++)
            {
                fullInfo[i] = ($"{characters[i].Name},{characters[i].Score},{characters[i].Level}").Split(',');
            }
        }
       
        public static void PrintFullInfo()
        {
            foreach(var character in fullInfo)
            {
                Console.WriteLine($"Name: {character[0]}, Score: {character[1]}, Level: {character[1]}");
            }
        }
        public static void Reset(List<Character> characters)
        {
            foreach (var character in characters)
            {
                character.Score = 0;
                character.Level = 1;
            }
            fullInfo.Clear();
            playersInfoFile.Delete();
        }
        public static void RetrieveFullInfo()
        {
        }
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
