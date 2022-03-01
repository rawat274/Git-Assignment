namespace CSharp6
{
    class Equipment
    {
        private string name;
        private string description;
        private double mc;
        public Equipment() { }
        public Equipment(string name, string deletedescription, double mc)
        {
            this.name = name;
            this.description = description;
            this.mc = mc;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public double MaintenanceCost
        {
            get { return mc; }
            set { mc = value; }
        }
    }
}
