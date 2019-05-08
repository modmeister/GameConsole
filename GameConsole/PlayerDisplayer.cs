using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    class PlayerDisplayer
    {
        public static void Write(PlayerCharacter player)
        {
            if (string.IsNullOrWhiteSpace(player.Name))
            {
                Console.WriteLine("Player name is null or all whitespace");
            }
            else
            {
                Console.WriteLine(player.Name);
            }

            //if (player.DaysSinceLastLogin.HasValue)
            //{
            //    Console.WriteLine(player.DaysSinceLastLogin);
            //}
            //else
            //{
            //    Console.WriteLine("No value for DaysSinceLastLogin");
            //}

            //if (player.DateOfBirth.HasValue)
            //{
            //    Console.WriteLine(player.DateOfBirth);
            //}
            //else
            //{
            //    Console.WriteLine("No date of birth specified");
            //}

            if (player.IsNoob == null)
            {
                Console.WriteLine("Player newbie status is unknown");
            }
            else if (player.IsNoob == true)
            {
                Console.WriteLine("Player is a newbie");
            }
            else
            {
                Console.WriteLine("Player is experienced");
            }
        }
    }
}
