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

            if(playerCharacter.DaySinceLastLogin == null)
            {
                Console.WriteLine("No value for Day SinceLastLogin");
            }
            else
            {
                Console.WriteLine(playerCharacter.DaySinceLastLogin);
            }

           if (playerCharacter.DateOfBirth == null)
            {
                Console.WriteLine("No value for Birthday");
            }
            else
            {
                Console.WriteLine(playerCharacter.DateOfBirth);
            }

            if (playerCharacter.IsNoob == null)
            {
                Console.WriteLine("The player newbie status is unknown");
            }
            else if(playerCharacter.IsNoob == true)
            {
                Console.WriteLine("Player is newbie");
            }
            else
            {
                Console.WriteLine("Player is experienced");
            }
        }
            
    }
}
