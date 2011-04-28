using System;

namespace SimUDuck.Creature.Behavior
{
    class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.Out.WriteLine("Squeak");
        }
    }
}
