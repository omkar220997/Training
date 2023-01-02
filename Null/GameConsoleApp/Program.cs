using System;
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
            //PlayerCharacter player = new PlayerCharacter();
            //player.PlayerName="Omkar Kadam";
            //player.DaysSinceLastLogin = 22;
            //int days = player?.DaysSinceLastLogin ?? -1;

            //player.DateOfBirth = new DateTime(1997, 11, 14);
            //player.IsPlayerNew= true;
            //Console.WriteLine(days);

            PlayerCharacter[] players = new PlayerCharacter[3]
            {
                new PlayerCharacter {PlayerName = "Omkar" },
                new PlayerCharacter{PlayerName="Pankaj" },
                null

            };
            
            //string player1 = players?[0]?.PlayerName;
            //string player2 = players?[1]?.PlayerName;
            //string player3 = players?[2]?.PlayerName;
            PlayerDisplayer.Write(players[0]);
            PlayerDisplayer.Write(players[1]);
            PlayerDisplayer.Write(players[2]);

            Console.ReadLine();
        }
    }
}
