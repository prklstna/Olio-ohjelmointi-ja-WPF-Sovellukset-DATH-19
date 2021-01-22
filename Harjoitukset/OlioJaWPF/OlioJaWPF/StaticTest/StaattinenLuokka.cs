using System;
using System.Collections.Generic;
using System.Text;

namespace StaticTest
{
    static class StaattinenLuokka
    {

        public static float KmToMiles(float km)
        {
            float conversion = 0.62137f;
            return km * conversion;
        }
    }
}
