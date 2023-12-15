using System.ComponentModel.DataAnnotations.Schema;

namespace Justjentak2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hruska zdenek = new Hruska("Zluta", 100.0, 1 );
            Hruska josef = new Hruska("Zelena", 72.0, 45);
            zdenek.Vlastnosti();
            josef.Vlastnosti();

           // zdenek.Barva = "Zluta";
           // zdenek.Velikost = 3;
           // zdenek.Id = 360;

           // zdenek.Vlastnosti();
        }








        


    }
}
    
