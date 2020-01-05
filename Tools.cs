using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Destroyers
{
    public static class Tools
    {
        public static void ColorfulWriteLine(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void TypeSpecificColorfulCW(string message, string type)
        {
            ConsoleColor color = ConsoleColor.White;

            switch(type)
            {
                case "Characters.Warrior":
                    color = ConsoleColor.Cyan;
                    break;
                case "Characters.Assassin":
                    color = ConsoleColor.Green;
                    break;
                case "Characters.Knight":
                    color = ConsoleColor.Yellow;
                    break;
                case "Characters.Mage":
                    color = ConsoleColor.Blue;
                    break;
                case "Characters.Druid":
                    color = ConsoleColor.DarkGreen;
                    break;
                case "Characters.Necromancer":
                    color = ConsoleColor.DarkMagenta;
                    break;
                default:
                    color = ConsoleColor.White;
                    break;
            }
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
