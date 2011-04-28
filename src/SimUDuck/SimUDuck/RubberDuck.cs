using System;

namespace SimUDuck
{
    class RubberDuck : Duck, IQuackable
    {
        public void Quack()
        {
            Console.Out.WriteLine("Squeak");
        }

        public override void Display()
        {
            Console.Out.WriteLine("Rubber Duck");
        }
    }
}
