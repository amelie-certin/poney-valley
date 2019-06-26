using System.Collections.Generic; 

namespace poney_valley
{
    public class Shetland : Poney
    {
        public Shetland(string name, int livePointStart): base(name, livePointStart)
        {
            AppendAction(new ShowJumping());
            AppendAction(new Feed());
        }

    }
}