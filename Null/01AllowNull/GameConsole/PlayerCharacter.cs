using System;
using System.Diagnostics.CodeAnalysis;

namespace GameConsole
{
    class PlayerCharacter
    {
        private string _name = GenerateName();
        [AllowNull]
        public string Name 
        {
            get => _name;
            set => _name = value ?? GenerateName(); 
        }
        private string? _bio;
        [DisallowNull]
        public string? Bio 
        { 
            get=> _bio; 
            set=> _bio=value?? throw new ArgumentNullException(nameof(value)); 
        }


        public int? DaysSinceLastLogin { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public bool? IsNoob { get; set; }

        public static bool TryParse(string input, [NotNullWhen(true)] out PlayerCharacter? player)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                player = null;
                return false;
            }
            if (!input.StartsWith("Name:"))
            {
                player = null;
                return false;
            }

            string parsedName = input.Split(':')[1];
            player= new PlayerCharacter { Name= parsedName };
            return true;
        }



        public static string GenerateName()
        {
            var names = new string[] { "Omkar", "Pankaj", "Shubham" };
            var random=new Random();
            return names[random.Next(0,3)];
        }
    }
}
