using System;
using System.Collections.Generic;
using System.Linq;


namespace Dzienniczek
{
    class Dziennik
    {
        // Stan (zmienne - pola)

        List<float> oceny = new List<float>();

        // Zachowania 
        public void DodawanieOcen(float ocena)
        {
            oceny.Add(ocena);
        }

        public float LiczenieSredniej()
        {
            float suma = 0, srednia = 0;

            foreach(var ocena in oceny)
            {
                suma = suma + ocena;
            }

            srednia = suma / oceny.Count();
            return srednia;

        }

        public float PobierzMaksymalnaOcene()
        {
            return oceny.Max();
        }

        public float PobierzNajnizszaOcene()
        {
            return oceny.Min();
        }
    }
}
