using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    class PlayerCharacter
    {
        public PlayerCharacter()
        {
            DateOfBirth = DateTime.MinValue; //Magic Number
            DaySinceLastLogin = -1; //Magic Number
        }

        public string Name { get; set; }
        public int DaySinceLastLogin { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
