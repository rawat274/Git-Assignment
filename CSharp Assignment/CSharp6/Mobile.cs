namespace CSharp6
{
    class Mobile : Equipment
    {
        private int dm;
        public Mobile(string name, string description, double mc)
            : base(name, description, mc)
        {
            this.dm = 0;
        }
        public int DistanceMoved
        {
            get { return dm; }
            set { dm = value; }
        }
    }
}
