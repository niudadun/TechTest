using System;
using System.Collections.Generic;
using System.Text;
using TechTest.Charactors.Bonuses;

namespace TechTest.Charactors.Support
{
    public class Genie : BaseChorator, BaseClass
    {
        public int Action { get; set; }
        public bool CanCastSpells() { return false; }

        public List<Bonus> GetAvailableSpells()
        {
            List<Bonus> result = new List<Bonus>();
            var spells = new Bonus();
            result.Add(spells);
            return result;
        }
    }
}
