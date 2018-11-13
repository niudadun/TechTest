using System;
using System.Collections.Generic;
using System.Text;
using TechTest.Charactors;

namespace TechTest.Fights
{
    public class Battle
    {
        public static void IsCharactorDead(BaseChorator hero)
        {
            if (hero.Health <= 0)
            {
                Console.Clear();
                Console.WriteLine("Looks like you are dead!");
                Console.WriteLine("Better luck next time!");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }
        public static void PrintTheStats(BaseChorator person1, BaseChorator person2)
        {
            person1.PrintStats();
            Console.WriteLine("");
            person2.PrintStats();
            Console.WriteLine("");
        }

        public static void FightTurn(BaseChorator hero, BaseChorator computer)
        {
            while (computer.Health > 0 && hero.Health > 0)
            {
                PrintTheStats(computer, hero);

                hero.YourTurn(hero.Action, computer);

                if (computer.Health > 0)
                {
                    computer.PrintStats();
                    IsCharactorDead(hero);
                }

            }

            Console.WriteLine("{0} was killed!", computer.Name);
            Console.ReadLine();
            Console.Clear();
        }

        
    }
}
