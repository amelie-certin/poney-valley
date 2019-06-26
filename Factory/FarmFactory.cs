using System.Collections.Generic;
namespace poney_valley
{
    public class FarmFactory
    {
        public static Farm GetFarm()
        {
            Farm farm = new Farm();
            farm.Animals = new List<Animal>();
            return farm;
        }
    }
}