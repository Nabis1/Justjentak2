namespace Justjentak2
{
    public class Hruska
    {
        public Hruska(string barva, double velikost, int id)
            
        { 
            Barva = barva;
            Velikost = velikost;
            Id = id;
        }
        
        
        public string Barva = "Neznama";
        public double Velikost = 100.0;
        public int Id = 0;

        public void Vlastnosti()
        {
            Console.WriteLine( $"Jsem hruska Zdenek {Barva}," +
                $" velikost mam  {Velikost}" + 
                $" a moje seriove cislo je {Id}");
        }
    }
}
