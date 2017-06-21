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

      string postcode = "27349 GTR";
      int huisnummer = 10;
      string nieuwePostcode = "hoi95";


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
      Console.WriteLine("Hoeveel kost de cola?");
      int cola1 = Convert.ToInt32(Console.ReadLine());
      int cola2 = Convert.ToInt32(Console.ReadLine());
      int end = cola1 - cola2;

      Console.WriteLine(end + " euro");
      Console.ReadLine();

      // vermenigvuldigen = *
      // delen = /
      // je kan een IF statement maken, dat is zegmaar hetzelfde als zeggen "als dit waar is doe X"
      // Daarna kan je een else toevoegen (kan alleen direct nadat je een if sluit) voor als het niet waar was
      // Je kan ook een else if toevoegen dat betekend "als alles hiervoor niet waar was, maar dit wel doe Y"
      // voorbeeld:
      // if (cola1 == 10) 
      // {
      //   end = cola1 * cola2;
      // } 
      // else if (cola1 == 5) 
      // {
      //   end = cola1 / cola2;
      // }
      // else
      // { 
      //   end = cola1 + cola2;
      // }
      // Hier staat: Als cola1 gelijk is aan 10, doe cola1 keer cola2, 
      // als cola1 niet gelijk is aan 10 maar wel gelijk is aan 5, deel cola 1 door cola2,
      // als dat allemaal niet klopt doe cola1 plus cola2

      // probeer een reken machine (soort van) te maken

    }
  }
}

