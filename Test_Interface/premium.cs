using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface
{
    class premium : paycom
    {
        

        public void sleva(int Cena)
        {
            //cena = 200;
            int vys = Cena /2;
            Console.WriteLine(vys);
        }
    }
}
