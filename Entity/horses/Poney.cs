using poney_valley;
using System.Collections.Generic;

namespace poney_valley
{
    public abstract class Poney : Animal
    {
        
        public Poney(string name, int livePointStart) 
        : base(name, livePointStart)
        {
            
        }


    }
}