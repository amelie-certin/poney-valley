namespace poney_valley
{
    public class Unicorn : Poney
    {
        public List<Unicorn> Parents { get; set; }
        
        public Unicorn(string name, int livePointStart)
        {
            base(name, livePointStart)
        }
    }
}