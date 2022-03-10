using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    public  class canlılar
    {
        protected void beslenme()
        {
            Console.WriteLine("canlılar beslenir");
        }
        protected void solunum()
        {
            Console.WriteLine("canlılar solunum yapar");
        }
        protected void bosaltım()
        {
            Console.WriteLine("canlılar bosaltım yapar");
        }
        public virtual void uyaranlaraTepki()
        {
            Console.WriteLine("canlılar uyaranlara tepki verir.");

        }
    }
}
