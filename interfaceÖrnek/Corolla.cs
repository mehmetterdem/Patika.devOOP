using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceÖrnek
{
    public class Corolla : IOtomobil
    {
        public Marka HangiMarka()
        {
            return Marka.toyota;
        }

        public int KacTekerlek()
        {
            return 4;
        }

        public Renk StandartRengi()
        {
            return Renk.kırmızı;
        }
    }
}
