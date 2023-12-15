using System.ComponentModel.DataAnnotations.Schema;

namespace Justjentak2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hruska zdenek = new Hruska("Zluta", 100.0,1,"Zdenek" );
            Hruska josef = new Hruska("Zelena", 72.0, 45, "Josef");
            Hruska karel = new Hruska();
            zdenek.Vlastnosti();
            josef.Vlastnosti();
            karel.Vlastnosti();
            // tyto vlastnosti napise az metoda pod 
            zdenek.Barva = "Zluta";
            zdenek.Velikost = 80.7;
            zdenek.Id = 360;

            zdenek.Vlastnosti();
        }








        


    }
}
    
