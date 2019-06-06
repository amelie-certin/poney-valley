namespace poney_valley
{
    public class FarmFactory
    {
        public static Farm GetFarm()
        {
            Farm farm = new Farm()
            List<Animal> animals = new List<Animal>();

            animals.Add(new Unicorn("Claudia", 47));
            animals.Add(new Unicorn("Rhino", 77));
            Unicorn babyUni = new Unicorn("Serina", 77);
            babyUni.Parents = animals;
            animals.Add(babyUni);

            animals.Add(new Shetland("Mini", 89));
            animals.Add(new Shetland("Toto", 5));
            Poney babyPoney = new Poney("Alphonse", 66);
            babyPoney.Parents = animals.GetRange(3, 4);
            animals.Add(babyPoney);

            farm.Animals = animals;
            return farm;
        }
    }
}