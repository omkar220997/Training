﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var player = new PlayerCharacter();
            PlayerCharacter player = new PlayerCharacter();
            //player.PlayerName="Omkar Kadam";
           player.DaysSinceLastLogin = 22;
            int days = player?.DaysSinceLastLogin ?? -1;
            
            //player.DateOfBirth = new DateTime(1997, 11, 14);
            //player.IsPlayerNew= true;
            Console.WriteLine(days);
            //PlayerDisplayer.Write(player);
            Console.ReadLine();
        }
    }
}
