using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_1
{
  class Program
  {
    // Dit word uitgevoerd als ik het programma opstart
    static void Main(string[] args)
    {
      // Dit is commentaar
      // Variable:
      // string = een verzameling van karakters in een bepaalde volgorde
      // int = een nummer wat positief/negatief kan zijn
      // bool = ja of nee
      bool deurbelIngedrukt = false;
      string postcode = "27349 GTR";
      int huisnummer = 10;
      string nieuwePostcode = "hoi95";

      deurbelIngedrukt = true;
      postcode = nieuwePostcode;

      Console.WriteLine(postcode);
      Console.WriteLine("Wat voor pizza wil je bestellen?");
      string pizza = Console.ReadLine();

      Console.WriteLine(pizza);

      int een = 5;
      int twee = 10;
      int uitkomst;

      uitkomst = een + twee;

      // 15 euro
      Console.WriteLine(uitkomst + " euro");
      //Console.ReadLine();

      // Probeer de persoon om 2 getallen te vragen en die van elkaar af te trekken

      int pizza1 = Convert.ToInt32(Console.ReadLine());
      int pizza2 = Convert.ToInt32(Console.ReadLine());
      int betaling = pizza1 - pizza2;

      Console.WriteLine(betaling + " euro");
      Console.ReadLine();  

    }
  }
}
