using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _191107_2_OverloadMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aynı isimde farklı işlemleri yapan metotlara aşırı yüklenme denir.
            // Aynı isimde farklı bir metot oldugunu parametre veri tipinden ya da parametre sayısından anlayabiliriz.Aynı veri tipi ve sayısında ise hata verecektir, değiştirmemiz lazım
            Console.WriteLine();
            
            string x = Console.ReadLine();
            Console.WriteLine(MetotOverload(x));
            Console.WriteLine(MetotOverload("baki ilhan", "ÖZTÜRK"));
            MetotOverload();
            
            
        }

        /// <summary>
        /// Yazdırma Metodu
        /// 
        /// </summary>
        /// 
        static void MetotOverload()
        {
            Console.WriteLine("Yazınız");
        }
        /// <summary>
        /// Ekrana yazdırılacak string yazıyı büyük harfe dönüştürür
        /// </summary>
        /// <param name="Girilecekyazi"></param>
        static string MetotOverload(string Girilecekyazi)
        {
            return Girilecekyazi.ToUpper();
        }


        // MetotOverload() adında bir metoda kullanıcıdan alınan iki adet string veri tipini birleştirsin arasına bir boşluk verecek şeklinde kullanıcıya göstersin
        /// <summary>
        /// Alınan iki yazıyı içinde boşluk olacak şekilde birleştir
        /// </summary>
        /// <param name="yazi1"></param>
        /// <param name="yazi2"></param>
        /// <returns></returns>
        static string MetotOverload(string yazi1, string yazi2)
        {
            return yazi1 + " " + yazi2;
        }

    }
}
