using System;

namespace SimUDuck
{
    class MallardDuck : Duck, IFlyable, IQuackable
    {
        public override void Display()
        {
            Console.Out.WriteLine("Mallard Duck");
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
