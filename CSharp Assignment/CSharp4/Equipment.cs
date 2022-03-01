namespace CSharp4
{
    public class Equipment                       //parent class equipment
    {
        public string Name;                       //all the data members of the parent class
        public string Description;
        public int DMTD;
        public int mc;
        public virtual void MoveBy(int dm, int Wheels)       //moveby function made virtual for overriding it later
        {
            DMTD = DMTD + dm;
            mc = Wheels * dm;
        }
    }
}