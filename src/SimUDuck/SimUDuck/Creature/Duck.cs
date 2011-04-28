using System;
using SimUDuck.Creature.Behavior;

namespace SimUDuck.Creature
{
    abstract class Duck
    {
        protected readonly IFlyBehavior flyBehavior;
        protected readonly IQuackBehavior quackBehavior;

        protected Duck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior)
        {
            this.flyBehavior = flyBehavior;
            this.quackBehavior = quackBehavior;
        }

        public void PerformFly()
        {
            flyBehavior.Fly();
        }

        public void PerformQuack()
        {
            quackBehavior.Quack();
        }

        public void Swim()
        {
            Console.Out.WriteLine("Swim");
        }

        public abstract void Display();
    }
}
