using System;

namespace SimUDuck.Creature.Behavior
{
    class MuteQuack : IQuackBehavior
    {

        public void Quack()
        {
            Console.Out.WriteLine("Silence");
        }
    }
}
