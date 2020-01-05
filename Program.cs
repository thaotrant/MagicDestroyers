using Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Destroyers
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gameOver = false;

            Random random = new Random();

            Melee currentMelee;
            Spellcaster currentSpellcaster;

            List<Character> characters = new List<Character>()
            {
                new Warrior(),
                new Warrior(),
                new Warrior(),
                //new Knight(),
                //new Assassin(),
                new Mage(),
                new Mage(),
                new Mage()
                //new Necromancer(),
                //new Druid()
            };
            List<Melee> meleeTeam = new List<Melee>();
            List<Spellcaster> spellTeam = new List<Spellcaster>();

            foreach (var character in characters)
            {
                if (character is Melee)
                {
                    meleeTeam.Add(character as Melee);
                }
                else if (character is Spellcaster)
                {
                    spellTeam.Add((Spellcaster)character);
                }
            }

            while(!gameOver)
            {
                currentMelee = meleeTeam[random.Next(0, meleeTeam.Count())];
                currentSpellcaster = spellTeam[random.Next(0, spellTeam.Count())];
                
                currentSpellcaster.TakeDamage(currentMelee.Attack(), currentMelee.Name, currentMelee.GetType().ToString());
                //Console.WriteLine(currentMelee.GetType().ToString());
                if (!currentSpellcaster.IsAlive)
                {
                    currentMelee.WonBattle();
                    spellTeam.Remove(currentSpellcaster);
                    if(spellTeam.Count == 0)
                    {                        
                        Tools.ColorfulWriteLine("Melee Team wins!", ConsoleColor.Red);
                        break;
                    }
                    else
                    {
                        currentSpellcaster = spellTeam[random.Next(0, spellTeam.Count())];
                    }                    
                }

                currentMelee.TakeDamage(currentSpellcaster.Attack(), currentSpellcaster.Name, currentSpellcaster.GetType().ToString());
                //Console.WriteLine(currentSpellcaster.GetType().ToString());
                if(!currentMelee.IsAlive)
                {
                    currentSpellcaster.WonBattle();
                    meleeTeam.Remove(currentMelee);
                    if(meleeTeam.Count == 0)
                    {
                        Tools.ColorfulWriteLine("Spellcaseter team wins!", ConsoleColor.Red);
                        break;
                    }
                    else
                    {
                        currentMelee = meleeTeam[random.Next(0, meleeTeam.Count())];
                    }
                }                 
            }
            PlayersInfo.Initialize(characters);
        }
    }
}
