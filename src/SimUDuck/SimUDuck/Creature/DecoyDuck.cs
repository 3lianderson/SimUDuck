using System;
using SimUDuck.Creature.Behavior;

namespace SimUDuck
{
    class DecoyDuck : Duck
    {
        public DecoyDuck() : base(new Flyless(), new MuteQuack()) { }

        public override void Display()
        {
            Console.Out.WriteLine("Decoy Duck");
        }
    }
}
