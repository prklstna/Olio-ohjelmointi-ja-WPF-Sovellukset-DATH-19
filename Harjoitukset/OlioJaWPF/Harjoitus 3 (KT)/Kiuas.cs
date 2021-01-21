using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_3__KT_
{
    class Kiuas
    {
        bool isKiuasPäällä = true;
        public string Nimi { get; set; }
        public string Tila { get; set; }
        public int Lämpö { get; set; }
        public int Kosteus { get; set; }
        
        public void TulostaData()
        {
            Console.WriteLine("Sauna");
            Console.WriteLine("-- Kiuas: " + Nimi);
            Console.WriteLine("-- Lämpö: " + Lämpö);
            Console.WriteLine("-- Tila: " + isKiuasPäällä);
            Console.WriteLine("-- Kosteus: " + Kosteus);

        }


        public string ToString()
        {
            string merkkijono = "Kiuas: " + Nimi + " Lämpö: " + Lämpö + " Astetta. Tila: " + Tila + " Kosteus: " + Kosteus + " ML.";

            return merkkijono;
        }
    }


}
