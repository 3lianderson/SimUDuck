﻿using System;
using SimUDuck.Creature.Behavior;

namespace SimUDuck.Creature
{
    class RubberDuck : Duck
    {
        public RubberDuck() : base(new Flyless(), new Squeak()) { }

        public override void Display()
        {
            Console.Out.WriteLine("Rubber Duck");
        }
    }
}
