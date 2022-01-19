using System;

namespace ZadanieHermetyzacja
{
    class Program
    {
        static void Main(string[] args)
        {
            Samolot awionetka = new Samolot(1250, 4, 2, 6, "jednopłatowiec");
            
            Samolot.WyswietlanieInformacji(awionetka);

            
            
        }

        
    }
}
