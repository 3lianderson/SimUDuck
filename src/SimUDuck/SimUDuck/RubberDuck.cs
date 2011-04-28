using System;

namespace SimUDuck
{
    class RubberDuck : Duck
    {
        public override void Quack()
        {
            Console.Out.WriteLine("Squeak");
        }

        public override void Display()
        {
            Console.Out.WriteLine("Rubber Duck");
        }
    }
}
