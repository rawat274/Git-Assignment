using System;

namespace CSharp7
{
    class MallardDuck : Ducks //Derived Class Mallard duck
    {
        public MallardDuck()
        {
            Console.WriteLine("A Mallard Duck is Created.");
        }
        public override void Show() //Overriding base class function
        {
            Console.WriteLine("This is a Mallard Duck.");
            base.Show();
            Console.WriteLine("Mallard Ducks fly fast and Quack loud.");
        }
    }
}
