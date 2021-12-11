namespace D11
{
    public class Octopus
    {
        public Octopus(int initial)
        {
            Flashed = false;
            Energy = initial;
        }
        
        public bool Flashed { get; set; }
        
        public  int Energy { get; set; }
    }
}