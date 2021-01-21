using System;

namespace Harjoitus_3__KT_
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Kiuas kiuas = new Kiuas();

            kiuas.Nimi = "Harvia";
            kiuas.Lämpö = 80;
            kiuas.Tila = "Päällä";
            kiuas.Kosteus = 15;

            kiuas.TulostaData();

            string kiuasTiedot = kiuas.ToString();
            Console.WriteLine(kiuasTiedot);
        }
    }
}
