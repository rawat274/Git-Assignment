using System;

namespace CSharp5
{
    class MallardDuck : Duck //derived class
    {
        public MallardDuck(double weight, int numberofwings, DuckType duckType)
            : base(weight, numberofwings, duckType)
        {
        }
        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine("Mallard ducks fly fast and quack loud.");
        }
    }
}
