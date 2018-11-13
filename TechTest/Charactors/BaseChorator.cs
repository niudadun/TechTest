using System;
using System.Collections.Generic;
using System.Text;
using TechTest.Charactors.Bonuses;

namespace TechTest.Charactors
{
    public class BaseChorator
    {
        public int Health { get; set; }

        public int Action { get; set; }

        public string Name { get; set; }

        public void PrintStats()
        {
            Console.WriteLine("{0} stats:");
            Console.WriteLine("");
            Console.WriteLine("Attack value is: {0}");
            Console.WriteLine("Health value is: {0}", Health);
        }

        public void YourTurn(int decision, BaseChorator target)
        {
            if (decision == 1)
            {
                new Bonus().DodgeAttack();
                Console.WriteLine("You attached the enemy twice!");
            }

            if (decision == 2)
            {
                new Bonus().SelfHeal();
                Console.WriteLine("You healed for {0} health!");
            }

            if (decision == 4)
            {
                new Bonus().GiveAWish();
                Console.WriteLine("You used a wish!");
            }

            if (decision == 5)
            {
                new Bonus().GiveABless();
                Console.WriteLine("You used a bless!");
            }

        }
    }
}
