using System;
using TechTest.Charactors.Caster;
using TechTest.Charactors.Fighter;
using TechTest.Fights;

namespace TechTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Pirate pirate = new Pirate();
            Wizard wiz = new Wizard();
            Battle.FightTurn(pirate, wiz);


        }
    }


}
