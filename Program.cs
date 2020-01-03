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
                //1. Take a random Melee
                //2. Taek a random Spell

                //3. Melee attack Spell
                //3.1 check if he died then remove him from the melee
                //3.2 if dead, take another character from the team

                //4. Spell attack Melle
                //4.1 check if he died then remove him from the melee
                //4.2 if dead, take another character from the team

            // 5. if no characters are alive either of the teams, game over = true
            }

        }
    }
}
