using System;

namespace SimUDuck.Creature.Behavior
{
    class Quack : IQuackBehavior
    {
        void IQuackBehavior.Quack()
        {
            Console.Out.WriteLine("Quack");
        }
    }
}
