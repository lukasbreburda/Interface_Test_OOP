using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
           

            int bla = 600;
            Console.WriteLine("Hodnota nákuppu je: " + bla);
            NGuest zak1 = new NGuest();
            Console.Write("Cena po slevě u normálního uživatele: ");
            zak1.Prize(bla);
            Console.Write("Cena po slevě u premiového uživatele: ");
            PGuest zak2 = new PGuest();
            zak2.Prize(bla);



            Console.ReadKey();
        }
    }
}
