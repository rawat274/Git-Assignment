namespace CSharp4
{
    public class Immobile : Equipment
    {
        public override void MoveBy(int dm, int Weight)
        {
            DMTD = DMTD + dm;
            mc = Weight * dm;
        }
    }
}
