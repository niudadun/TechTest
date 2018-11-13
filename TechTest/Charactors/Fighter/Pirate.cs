using System;
using System.Collections.Generic;
using System.Text;
using TechTest.Charactors.Bonuses;

namespace TechTest.Charactors.Fighter
{
    public class Pirate : BaseChorator,BaseClass
    {
        public int Damage { get; set; }

        public bool CanCastSpells()
        {
            return true;
        }

        public List<Bonus> GetAvailableSpells()
        {
            List<Bonus> result = new List<Bonus>();
            var spells = new Bonus();
            result.Add(spells);
            return result;
        }

    }
}
