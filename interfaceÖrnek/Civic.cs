using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceÖrnek
{
    public class Civic : IOtomobil
    {
        public Marka HangiMarka()
        {
            return Marka.honda;
        }

        public int KacTekerlek()
        {
            return 4;
        }

        public Renk StandartRengi()
        {
            return Renk.siyaz;
        }
    }
}
