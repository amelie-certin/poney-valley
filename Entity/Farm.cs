using poney_valley; 
using System.Collections.Generic;
using System;
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

        public void DisplayAll(){
            Animals.ForEach( a => Console.WriteLine(a.GetLife()));
        }
    }
}