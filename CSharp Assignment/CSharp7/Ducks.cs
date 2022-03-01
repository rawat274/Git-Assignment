using System;

namespace CSharp7
{
    class Ducks : IDuckType  //base class inheriting interface
    {
        float Weight;
        int NumberOfWings;
        public void GetInfo() //Getting UserInput
        {
            Console.WriteLine("Enter Weight of the Duck:- \n");
            this.Weight = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number of Wings:- \n");
            this.NumberOfWings = int.Parse(Console.ReadLine());
        }
        public virtual void Show() // virtual function for overriding
        {
            Console.WriteLine("The weight of the duck is {0}", this.Weight);
            Console.WriteLine("The number of Wings of this Duck are {0}", this.NumberOfWings);
        }
        public float GetWeight()
        {
            return this.Weight;
        }
        public int GetWings()
        {
            return this.NumberOfWings;
        }
    }
}
