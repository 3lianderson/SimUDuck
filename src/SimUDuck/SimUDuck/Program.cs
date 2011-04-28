using System;
using System.Collections.Generic;
using SimUDuck.Creature;

namespace SimUDuck
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Duck> ducks = new List<Duck>() { new DecoyDuck(), new MallardDuck(), new RedheadDuck(), new RubberDuck() };

            PrintDucks(ducks);
        }

        private static void PrintDucks(IEnumerable<Duck> ducks)
        {
            foreach(Duck duck in ducks)
            {
                duck.Display();
                duck.PerformFly();
                duck.PerformQuack();
                duck.Swim();
                Console.Out.WriteLine();
            }
        }
    }
}
