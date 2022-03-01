namespace CSharp4
{
    public class Mobile : Equipment
    {
        public override void MoveBy(int dm, int Wheels)    //overridden the parent class
        {
            DMTD = DMTD + dm;
            mc = Wheels * dm;
        }

    }
}
