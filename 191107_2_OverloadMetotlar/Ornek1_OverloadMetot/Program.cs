23using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek1_OverloadMetot
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4 adet Overload metot kodlayınız
            //1. Metot Kullanıcıdan alınan 2 adet sayının toplamını yapsın
            //2. Metot kullanıcıdan alınan ürün fiyatına %25 indirim uygulasın
            //3. Metot random ile oluşturulan 11 elemanlı bir dizi(ya da herhangi bir int dizi ) için listeleme yapsın
            //4. Metot Kullanıcıdan alınacak şifreye ve kullanıcı adına göre sisteme giriş yapan


            Console.WriteLine("Sayı giriniz : ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Sayı giriniz : ");
            int y = int.Parse(Console.ReadLine());
            Metot(x,y);
            Console.WriteLine("Fiyat Giriniz : ");
            double fiyat = double.Parse(Console.ReadLine());
            Console.WriteLine("%25 indirimli fiyat : "+Metot(fiyat));
            

            Console.WriteLine("Dizi Elemanını giriniz");           
            int elemanAdet = Convert.ToInt32(Console.ReadLine());
            int[] dizi = new int[elemanAdet];
            Metot(dizi);

            Console.WriteLine("Kullanıcı Adınızı Giriniz : ");
            string kadi = Console.ReadLine();
            Console.WriteLine("Sifre giriniz :");
            string sifre = Console.ReadLine();
            Console.WriteLine(Metot(kadi,sifre));
            
        }
        static double Metot(double fiyat)
        {
            if (fiyat <= 0)
            {
                Console.WriteLine("Hatalı fiyat Girniz.");
                return 0;
            }
                
            return fiyat-fiyat * 0.25;
        }
        static void Metot(int sayi1,int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine(toplam);
        }
        static void Metot(int [] dizi)
        {
            Random rnd = new Random();
            for (int i = 0; i <dizi.Length; i++)
            {
                dizi[i] = rnd.Next(100);
                Console.WriteLine(dizi[i]);
            }            
        }
        static string Metot(string ad , string sifre)
        {
           
                if ("admin" == ad && "sifre" == sifre)
                    return "Hoşgeldiniz";
                else if ("admin" == ad && "sifre" != sifre)
                    return "Hatalı Şifre girdiniz";
                else if ("admin" != ad && "sifre" == sifre)
                    return "Hatalı Kullanıcı adı girdiniz";
                else
                    return "Hatalı Giriş";
           
            
        }
    }
}
