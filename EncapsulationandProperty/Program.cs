using System;

namespace EncapsulationandProperty
{
    class Program
    {
        static void Main(string[] args)
        {
            ogrenci ogrenci = new ogrenci();
            ogrenci.Ismi = "mehmet";
            ogrenci.Soyismi = "erdem";
            ogrenci.Ogrencino = 334;
            ogrenci.Sinif = 1;
            ogrenci.ogrencibilgilerinigetir();
            ogrenci.SinifAtlat();
            ogrenci.ogrencibilgilerinigetir();
            ogrenci.SinifDüşür();
            ogrenci.SinifDüşür();
            ogrenci.ogrencibilgilerinigetir();
            
        }
        class ogrenci
        {
            private string ismi;
            private string soyismi;
            private int ogrencino;
            private int sinif;

            public string Ismi
            {
                get { return ismi; }
                set { ismi = value; }
            }

            public string Soyismi { get => soyismi; set => soyismi = value; }
            public int Ogrencino { get => ogrencino; set => ogrencino = value; }
            public int Sinif
            {
                get => sinif;
                set
                {
                    if (value < 1)
                    {
                        Console.WriteLine("sınıf en az bir olabilir");
                        sinif = 1;

                    }
                    else

                        sinif = value;

                }
            }

            public ogrenci()
            {
                    
            }
            public ogrenci(string isim,string soyisim,int no,int sinif)
            {
                this.Ismi = isim;
                this.Soyismi = soyisim;
                this.Ogrencino = no;
                this.Sinif = sinif;
            }
            public void ogrencibilgilerinigetir()
            {
                Console.WriteLine("******öğrenci bilgileri****");
                Console.WriteLine("Öğrenci Adı: {0}",this.Ismi);
                Console.WriteLine("Öğrenci Soyismi: {0}", this.Soyismi);
                Console.WriteLine("Öğrenci No: {0}", this.Ogrencino);
                Console.WriteLine("Öğrenci Sınıfı: {0}", this.Sinif);
            }

            public void SinifAtlat()
            {
                this.Sinif = this.Sinif + 1;
            }
            public void SinifDüşür()
            {
                this.Sinif = this.Sinif - 1;

            }




        }
    }
}