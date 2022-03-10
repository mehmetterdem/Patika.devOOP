using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceÖrnek
{
    public class focus : IOtomobil
    {
        public Marka HangiMarka()
        {
            return Marka.ford;
        }

        public int KacTekerlek()
        {
            return 4;
        }

        public Renk StandartRengi()
        {
            return Renk.beyaz;
        }
    }
}
