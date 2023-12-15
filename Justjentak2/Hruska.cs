namespace Justjentak2
{
    public class Hruska
    {
        public Hruska(string barva, double velikost, int id, string jmeno)
            
        { 
            Barva = barva;
            Velikost = velikost;
            Id = id;
            Jmeno = jmeno;
        }
        public Hruska()
        {

        }


        public string Jmeno = "Anonym";
        public string Barva = "Neznama";
        public double Velikost = 100.0;
        public int Id = 0;

        public void Vlastnosti()
        {
            Console.WriteLine( $"Jsem hruska,jmenuji se {Jmeno}, moje barva je {Barva}," +
                $" velikost mam  {Velikost}" + 
                $" a moje seriove cislo je {Id}");
        }
    }
}
