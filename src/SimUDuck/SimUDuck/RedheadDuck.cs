using System;

namespace SimUDuck
{
    class RedheadDuck : Duck, IQuackable, IFlyable
    {
        public override void Display()
        {
            Console.Out.WriteLine("Redhead Duck");
        }

        public void Quack()
        {
            Console.Out.WriteLine("Quack");
        }

        public void Fly()
        {
            Console.Out.WriteLine("Fly");
        }
    }
}
