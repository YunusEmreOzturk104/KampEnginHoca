using System;

namespace KampEnginHoca
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety  tip güvenliği
            // Do not repeat yourself kendini tekrarlama
            // değer tutucu alias
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Aazalış oku");
            }
            else if (dolarBugun>dolarDun)
            {
                Console.WriteLine("Artış Oku");
            }
            else
            {
                Console.WriteLine("değişmedi oku");
            }
            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giris Yap Butonu");
            }
            Console.WriteLine(kategoriEtiketi);
        }
    }
}
