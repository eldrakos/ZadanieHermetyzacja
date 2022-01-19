using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieHermetyzacja
{
    class Samolot : TypSamolotu
    {
         decimal waga;
        private uint iloscCylindrow;
        private uint iloscSilnikow;
        private uint iloscMiejsc;
        private readonly string typUstrzenia;

        decimal TypSamolotu.waga => waga;
        uint TypSamolotu.iloscCylindrow => iloscCylindrow;
        uint TypSamolotu.iloscSilnikow => iloscSilnikow;
        uint TypSamolotu.iloscMiejsc => iloscMiejsc;
        string TypSamolotu.typUstrzenia => typUstrzenia;

        void TypSamolotu.WyswietlanieInformacji()
        {
            Console.WriteLine($"Twój samolot to {typUstrzenia} waży {waga} kg. Posiada {iloscSilnikow} silniki o {iloscCylindrow} cylindrach. Może zabrać na pokład {iloscMiejsc} pasażerów.");
        }




        public Samolot(decimal ciezar, uint cylindry, uint silniki, uint miejsca, string usterzenie)
        {
            this.waga = ciezar;
            this.iloscCylindrow = cylindry;
            this.iloscSilnikow = silniki;
            this.iloscMiejsc = miejsca;
            this.typUstrzenia = usterzenie; 
        }

        public static void WyswietlanieInformacji(Samolot sam)
        {
            Console.WriteLine($"Twój samolot to {} waży {waga} kg. Posiada {iloscSilnikow} silniki o {iloscCylindrow} cylindrach. Może zabrać na pokład {iloscMiejsc} pasażerów.");
        }
    }



}
