using System;

namespace SimUDuck.Creature.Behavior
{
    class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.Out.WriteLine("Fly");
        }
    }
}
