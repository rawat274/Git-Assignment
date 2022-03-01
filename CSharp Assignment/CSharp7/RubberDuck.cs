using System;

namespace CSharp7
{
    class RubberDuck : Ducks  //Derived class
    {
        public RubberDuck()
        {
            Console.WriteLine("A Rubber Duck is Created.");
        }
        public override void Show() //Overriding base class function
        {
            Console.WriteLine("This is a Rubber Duck.");
            base.Show();
            Console.WriteLine("Rubber Ducks don't fly and Squeak.");
        }
    }
}
