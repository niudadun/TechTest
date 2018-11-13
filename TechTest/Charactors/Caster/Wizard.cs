using System;
using System.Collections.Generic;
using System.Text;
using TechTest.Charactors.Bonuses;

namespace TechTest.Charactors.Caster
{
    public class Wizard : BaseChorator, BaseClass
    {
        public int Damage { get; set; }

        public bool CanCastSpells() { return true; }

        public List<Bonus> GetAvailableSpells()
        {
            List<Bonus> result = new List<Bonus>();
            var spells = new Bonus();
            result.Add(spells);
            return result;
        }
    }
}
