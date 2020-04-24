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
            if (string.IsNullOrWhiteSpace(playerCharacter.Name))
            {
                Console.WriteLine("Player is Null or WhiteSpace");
            }
            else
            {
                Console.WriteLine(playerCharacter.Name);
            }

            //Using the get value or default
            int days = playerCharacter.DaySinceLastLogin.GetValueOrDefault(-1);
            Console.WriteLine($"{days} days since last Login");


            //Conditonal Operator
            int daysCond = playerCharacter.DaySinceLastLogin.HasValue ? playerCharacter.DaySinceLastLogin.Value : -1;
            Console.WriteLine($"{daysCond} days since last Login");


            //Null Coalescing Operator (Use the object itself and ?? and default value
            int daysCoales = playerCharacter.DaySinceLastLogin ?? -1;
            Console.WriteLine($"{daysCoales} days since last Login");


            //Has Value return a bool - Know that the value exist or not

            if (playerCharacter.DaySinceLastLogin.HasValue)
            {
                Console.WriteLine(playerCharacter.DaySinceLastLogin.Value);
            }
            else
            {
                Console.WriteLine("No value for Day SinceLastLogin");
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
