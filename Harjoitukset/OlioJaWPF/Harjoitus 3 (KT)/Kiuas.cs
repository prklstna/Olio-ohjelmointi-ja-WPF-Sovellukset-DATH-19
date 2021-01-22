using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_3__KT_
{
    class Kiuas
    {
        private bool Tila { get; set; }
        public string Nimi { get; set; }
        public int Lämpö { get; set; }
        public int Kosteus { get; set; }

        public Kiuas(string _nimi)
        {

            Nimi = _nimi;

            Tila = false;
            Lämpö = 10;
            Kosteus = 0;

        }

        public void TulostaData()
        {
            Console.WriteLine("Sauna");
            Console.WriteLine("-- Kiuas: " + Nimi);
            Console.WriteLine("-- Lämpö: " + Lämpö);
            Console.WriteLine("-- Tila: " + Tila);
            Console.WriteLine("-- Kosteus: " + Kosteus);
            Console.WriteLine();

        }


        public string ToString()
        {
            string nykyinenTila = "Pois Päältä";

            if (Tila == true)
            {
                nykyinenTila = "Päällä";
            }
            return nykyinenTila;
        }


        public void KiuasOnOff(bool t)
        {
            Tila = t;
        }





        public void MuutaLämpötilaa(int uusiLämpötila)
        {
            Lämpö = uusiLämpötila;

            if (Lämpö < 10)
            {
                Lämpö = 10;
            }
            else if (Lämpö > 150)
            {
                Lämpö = 150;
            }

            Console.WriteLine("Lämpötila muutettu. Uusi lämpötila: " + Lämpö);
           
        }

        public void MuutaKosteutta(int uusiKosteus)
        {
                Kosteus = uusiKosteus;

                if (Kosteus < 0)
                {
                    Kosteus = 0;
                }
                else if (Kosteus > 100)
                {
                    Kosteus = 100;
                }

            Console.WriteLine("Kosteutta muutettu. Uusi kosteus: " + Kosteus);
        }
        

    }
}
