using System;
using SimUDuck.Creature.Behavior;

namespace SimUDuck.Creature
{
    class RedheadDuck : Duck
    {
        public RedheadDuck() : base(new FlyWithWings(), new Quack()) { }

        public override void Display()
        {
            Console.Out.WriteLine("Redhead Duck");
        }
    }
}
