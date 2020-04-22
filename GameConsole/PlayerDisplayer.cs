using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    class PlayerDisplayer
    {
        public static void Write(PlayerCharacter playerCharacter)
        {
            Console.WriteLine(playerCharacter.Name);

            if(playerCharacter.DaySinceLastLogin == -1)
            {
                Console.WriteLine("No value for Day SinceLastLogin");
            }
            else
            {
                Console.WriteLine(playerCharacter.DaySinceLastLogin);
            }


           if (playerCharacter.DateOfBirth == DateTime.MinValue)
            {
                Console.WriteLine("No value for Birthday");
            }
            else
            {
                Console.WriteLine(playerCharacter.DateOfBirth);
            }

        }
            
    }
}
