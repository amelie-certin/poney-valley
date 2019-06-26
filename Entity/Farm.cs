using poney_valley; 
using System.Collections.Generic;

namespace poney_valley
{
    public class Farm
    {
        public string Name { get; }
        public List<Animal> Animals { get; set; }

        public Farm(string name)
        {
            this.Name = name;
        }

        public Farm()
        {

        }
    }
}