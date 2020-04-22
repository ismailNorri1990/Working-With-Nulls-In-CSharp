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
            DateOfBirth = null ; //Using Nullabke
            DaySinceLastLogin = null ; //Using Nullable
        }

        public string Name { get; set; }
        public int? DaySinceLastLogin { get; set; }
        public Nullable<DateTime> DateOfBirth { get; set; }

        public bool? IsNoob { get; set; }
    }
}
