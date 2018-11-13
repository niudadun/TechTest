using System;
using System.Collections.Generic;
using System.Text;
using TechTest.Charactors.Bonuses;

namespace TechTest.Charactors
{
    public interface BaseClass
    {
        bool CanCastSpells();
        List<Bonus> GetAvailableSpells();
        
    }
}
