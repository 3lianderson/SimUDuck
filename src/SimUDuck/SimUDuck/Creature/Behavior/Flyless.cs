using System;

namespace SimUDuck.Creature.Behavior
{
    class Flyless : IFlyBehavior
    {

        public void Fly()
        {
            Console.Out.WriteLine("Unable to fly");
        }
    }
}
