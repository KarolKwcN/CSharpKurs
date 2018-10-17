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
            /*
            dzienniczek.DodawanieOcen(5);
            dzienniczek.DodawanieOcen(7.6f);
            dzienniczek.DodawanieOcen(3.4f);
            float srednia = dzienniczek.LiczenieSredniej();
            float maks = dzienniczek.PobierzMaksymalnaOcene();
            float min = dzienniczek.PobierzNajnizszaOcene();

            Console.WriteLine(srednia);
            Console.WriteLine(maks);
            Console.WriteLine(min);
            */
        
            for(  ; ; )
            {
                Console.WriteLine("Podaj ocene: ");

                float ocenyy;
                bool wynik = float.TryParse(Console.ReadLine(), out ocenyy); //sprawdzamy czy wprowadzana dana to liczba

                if (ocenyy == 11)
                {
                    break;
                }

                if (wynik)
                {
                dzienniczek.DodawanieOcen(ocenyy);
                }

                


            }

            Console.WriteLine("Srednia Twoich ocen to : "+ dzienniczek.LiczenieSredniej());
            Console.WriteLine("Mkasymalna ocena to : " + dzienniczek.PobierzMaksymalnaOcene());
            Console.WriteLine("minimalna ocena to : " + dzienniczek.PobierzNajnizszaOcene());
            Console.ReadKey();
        }
    }
}
