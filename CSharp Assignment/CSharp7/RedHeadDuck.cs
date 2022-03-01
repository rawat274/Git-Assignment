using System;

namespace CSharp7
{
    class RedHeadDuck : Ducks //Derived class RedHead Duck
    {
        public RedHeadDuck()
        {
            Console.WriteLine("A RedHeaded Duck is Created.");
        }
        public override void Show()
        {
            Console.WriteLine("This is a RedHeaded Duck.");
            base.Show();
            Console.WriteLine("RedHead Ducks fly slow and Quack mild.");
        }
    }
}

