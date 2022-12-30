using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsoleApp
{
    internal static class PlayerDisplayer
    {
        public static void Write(PlayerCharacter player)
        {
            Console.WriteLine(player.PlayerName);
            //Here we are using -1 as a value to represent the DaysSinceLastLogin as a null so -1 is a Magic Number.
            //if(player.DaysSinceLastLogin== -1)
            //{
            //    Console.WriteLine("No value for DaysSinceLastLogin");
            //}
            //else
            //{
            //    Console.WriteLine(player.DaysSinceLastLogin);
            //}
            ////Here we are using MinValue property as a value to represent the DaysSinceLastLogin as a null
            ////so MinValue property is a Magic Number.

            //if (player.DateOfBirth == DateTime.MinValue)
            //{
            //    Console.WriteLine("No Date of Birth specified");
            //}
            //else
            //{
            //    Console.WriteLine(player.DateOfBirth);
            //}
            if (player.DaysSinceLastLogin == null)
            {
                Console.WriteLine("No value for DaysSinceLastLogin");
            }
            else
            {
                Console.WriteLine(player.DaysSinceLastLogin);
            }
            if (player.DateOfBirth == null)
            {
                Console.WriteLine("No Date of Birth specified");
            }
            else
            {
                Console.WriteLine(player.DateOfBirth);
            }
            if(player.IsPlayerNew is null)
            {
                Console.WriteLine("Player's new status is Unknown...");
            }
            else if(player.IsPlayerNew == true)
            {
                Console.WriteLine("Player is new to game");
            }
            else
            {
                Console.WriteLine("Player is old for the game");
            }
        }
    }
}
