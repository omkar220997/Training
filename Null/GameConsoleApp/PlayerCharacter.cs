using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsoleApp
{
    internal class PlayerCharacter
    {
        // string is a class so it is reference type 
        // int and DateTime is struct so it is value type

        public string PlayerName { get; set; }
        public int? DaysSinceLastLogin { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public bool? IsPlayerNew { get; set; }

        //public PlayerCharacter()
        //{
            //DateOfBirth=DateTime.MinValue; //Magic Number
            //DaysSinceLastLogin= -1;  //Magic Number

            //DateOfBirth = null;
            //DaysSinceLastLogin = null;
        //}
    }
}
