using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerCharacter ismail = new PlayerCharacter(new DiamondSkinDefence())
            {
                Name = "Ismail"
            };

            PlayerCharacter badr = new PlayerCharacter(SpecialDefence.Null)
            {
                Name = "badr"
            };

            PlayerCharacter gentry = new PlayerCharacter(SpecialDefence.Null)
            {
                Name = "gentry"
            };

            ismail.Hit(10);
            badr.Hit(10);
            gentry.Hit(10);


            Console.ReadLine() ;
        }
    }
}
