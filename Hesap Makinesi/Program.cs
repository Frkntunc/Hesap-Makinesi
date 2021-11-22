using System;

namespace Hesap_Makinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4 işlem örnepi!");

            Console.WriteLine("Kaç Adet sayı gireceksiniz");
            int n = Convert.ToInt32(Console.ReadLine());
            
            int[] sayilar = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($" {i+1}. Sayıyı Giriniz");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz");
            char islem = Convert.ToChar(Console.ReadLine());

            float islemSonucu = Islem(islem, sayilar);

            Console.Write($"İşlem Sonucunuz = {islemSonucu}");

            Console.ReadKey();
        }

        private static float Islem(char islem, params int[] sayi)
        {
            float sonuc = 0;

            for (int i = 0; i < sayi.Length; i++)
            {
                switch (islem)
                {
                    case '+':
                        sonuc += sayi[i];
                        break;
                    case '-':
                        sonuc -= sayi[i];
                        break;
                    case '*':
                        sonuc *= sayi[i];
                        break;
                    case '/':
                        sonuc /= sayi[i];
                        break;
                }
            }
            
            return sonuc;
        }
    }
    
}
