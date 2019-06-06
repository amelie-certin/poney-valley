namespace poney_valley
{
    public class Farm
    {
        public Name { get; }
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