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
            var player = new PlayerCharacter[] { 
                new PlayerCharacter(){ Name = "Issam"},
                new PlayerCharacter(){ Name = null},
                null
            };


            var p1 = player?[0]?.Name;
            var p2 = player?[1]?.Name;
            var p3 = player?[2]?.Name;

            Console.WriteLine(p1 +" "+ p2 + " "+ p3);
            

           
            Console.ReadLine() ;
        }
    }
}
