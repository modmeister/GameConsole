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
            var player = new PlayerCharacter();
            player.Name = "Khoa";
            player.DaysSinceLastLogin = 30;

            PlayerDisplayer.Write(player);

            Console.ReadLine();
        }
    }
}
