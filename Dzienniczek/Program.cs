using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dzienniczek
{
    class Program
    {
        static void Main(string[] args)
        {
            Dziennik dzienniczek = new Dziennik();

            dzienniczek.DodawanieOcen(5);
            dzienniczek.DodawanieOcen(7.6f);
            dzienniczek.DodawanieOcen(3.4f);

            

            float srednia = dzienniczek.LiczenieSredniej();
            float maks = dzienniczek.PobierzMaksymalnaOcene();
            float min = dzienniczek.PobierzNajnizszaOcene();

            Console.WriteLine(srednia);
            Console.WriteLine(maks);
            Console.WriteLine(min);


            Console.ReadKey();
        }
    }
}
