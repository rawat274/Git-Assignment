using System;

namespace CSharp5
{
    class RubberDuck : Duck //derived class
    {
        public RubberDuck(double weight, int numberofwings, DuckType duckType)
            : base(weight, numberofwings, duckType)
        {
        }
        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine("Rubber ducks don’t fly and squeak.");
        }
    }
}
