using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    class PlayerCharacter
    {
        private readonly SpecialDefence _specialDefence;

        public PlayerCharacter(SpecialDefence specialDefence)
        {
            _specialDefence = specialDefence;
        }

        public string Name { get; set; }
        public int Health { get; set; } = 100;
        public int? DaysSinceLastLogin { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public bool? IsNoob { get; set; }

        public PlayerCharacter()
        {
            DaysSinceLastLogin = null;
            DateOfBirth = null;
        }

        public void Hit(int damage)
        {
            int damageReduction = 0;
            damageReduction = _specialDefence.CalculateDamageReduction(damage);

            int totalDamageTaken = damage - damageReduction;

            Health -= totalDamageTaken;
        }
    }
}
