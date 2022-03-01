using System;

namespace CSharp5
{
    class Duck : IShowDetail
    {
        private double weight;
        private int numberofwings;
        private DuckType duckType;
        public Duck() { }
        public Duck(double weight, int numberofwings, DuckType duckType)
        {
            this.weight = weight;
            this.numberofwings = numberofwings;
            this.duckType = duckType;
        }
        public virtual void ShowDetails()
        {
            if (duckType == DuckType.Mallard)
            {
                Console.WriteLine("Mallard duck:-\n");
            }
            if (duckType == DuckType.Rubber)
            {
                Console.WriteLine("Rubber duck:-\n");
            }
            if (duckType == DuckType.Redhead)
            {
                Console.WriteLine("Redhead duck:-\n");
            }
            Console.WriteLine("Weight:- \n{0}", weight);
            Console.WriteLine("Number of wings:- \n{0}", numberofwings);
        }
    }
}
