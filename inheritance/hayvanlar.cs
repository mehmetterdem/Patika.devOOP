using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    public class hayvanlar:canlılar
    {
        protected void adaptasyon()
        {
            Console.WriteLine("hayvanlar adaptasyon kurabilir");
        }
    }
    public class sürüngenler:hayvanlar
    {
        public sürüngenler()
        {
            base.adaptasyon();
        }
        public void sürünerekhareketetme()
        {
            Console.WriteLine("sürüngenler sürünerek hareket ederler");
        }
    }
    public class kuslar:hayvanlar
    {
        public kuslar()
        {
            base.solunum();
            base.bosaltım();
            base.beslenme();
            base.adaptasyon();
        }
        public void ucmak()
        {
            Console.WriteLine("kuslar ucarlar");
        }
    }
}
