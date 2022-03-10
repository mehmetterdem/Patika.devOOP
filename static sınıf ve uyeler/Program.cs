using System;

namespace static_sınıf_ve_uyeler
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("calısan sayısı: {0}",calısan.CalısanSayısı);
            calısan calısan1 = new calısan("ayse","yılmaz","ık");
            calısan calısan2 = new calısan("ayse", "yılmaz", "ık");
         
            calısan calısan3 = new calısan("ayse", "yılmaz", "ık");
            Console.WriteLine("Calısan sayısı: {0}", calısan.CalısanSayısı);

            Console.WriteLine("sonuc: {0}",işlemler.Topla(8, 6));
            Console.WriteLine("sonuc: {0}", işlemler.Cıkar(8, 6));


        }



        class calısan
        {
            private static int calısanSayısı;
            public static int CalısanSayısı { get => calısanSayısı; }



            private string İsim;

            private string Soyisim;

            private string Depertman;

            static calısan()
            {
                calısanSayısı = 0;
            }

            public calısan(string isim, string soyisim, string depertman)
            {
                this.İsim = isim;
                this.Soyisim = soyisim;
                this.Depertman = depertman;
                calısanSayısı++;
                

            }
            

            
        }

        static class işlemler
        {
            public static long Topla(int sayı1,int sayı2)
            {
                return sayı1 + sayı2;
            }
            public static long Cıkar(int sayı1, int sayı2)
            {
                return sayı1 - sayı2;
            }
        }




    }
}
