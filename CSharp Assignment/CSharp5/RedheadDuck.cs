using System;

namespace CSharp5
{
    class RedheadDuck : Duck //derived class
    {
        public RedheadDuck(double weight, int numberofwings, DuckType duckType)
            : base(weight, numberofwings, duckType)
        {
        }
        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine("Redhead ducks fly slow and quack mild.");
        }
    }
}
