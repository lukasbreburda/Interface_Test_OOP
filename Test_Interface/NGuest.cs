using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface
{
    class NGuest
    {
        public paycom prize { get; set; } = new normalni();
        
        public void Prize(int Cena)
        {
            prize.sleva(Cena);
        }
    }
}
