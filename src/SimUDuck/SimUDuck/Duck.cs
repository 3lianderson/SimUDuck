using System;

namespace SimUDuck
{
    abstract class Duck
    {
        public void Swim()
        {
            Console.Out.WriteLine("Swim");
        }

        public abstract void Display();
    }
}
