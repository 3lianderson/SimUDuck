using System;
using SimUDuck.Creature.Behavior;

namespace SimUDuck.Creature
{
    class MallardDuck : Duck
    {
        public MallardDuck() : base(new FlyWithWings(), new Quack()) { }

        public override void Display()
        {
            Console.Out.WriteLine("Mallard Duck");
        }
    }
}
