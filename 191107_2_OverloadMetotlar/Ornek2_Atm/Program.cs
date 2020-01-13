using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek2_Atm
{
    class Program
    {
        static void Main(string[] args)
        {
            string adSoyad = "Baki ilhan ÖZTÜRK";
            double bakiye = 250;
            string sifre = "ab18";
            int basilan = 0;
            Console.WriteLine("         ----  Bakinin Atmsine Hoş Geldiniz....   -------");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Kartlı İslem için 1'e basınız");
            Console.WriteLine("Kartsız İslem için 2'ye basınız ");
           
            do
            {
                
                try
                {
                    basilan = int.Parse(Console.ReadLine());
                    if (basilan == 1)
                        Console.WriteLine(KartliKartsizİslem(basilan,bakiye,sifre));
                    if (basilan == 2)
                        Console.WriteLine(KartliKartsizİslem(basilan,bakiye,sifre));
                    if(basilan!=1 && basilan != 2)
                    {
                        Console.WriteLine("1 veya 2 Den birini giriniz");
                        
                    }
                        
                }
                catch (Exception)
                {

                    Console.WriteLine("************ Hatali islem *************");
                    
                }

            } while (basilan != 1 && basilan != 2);

            Console.ReadKey();
        }

        #region Ana Menu
        static object AnaMenu(double para, string Gsifre)
        {
            string sifre = Gsifre;
            double yenipara = para;
            int basilan = 0;
            do
            {
                try
                {
                    Console.WriteLine("             ***********Ana Menü************");
                    Console.WriteLine();
                    Console.WriteLine(sifre);
                    Console.WriteLine("Bakiye : " + para);
                    Console.WriteLine("Para Çekme  1");
                    Console.WriteLine("Para Yatırmak  2");
                    Console.WriteLine("Para Transferi  3");
                    Console.WriteLine("Eğitim Ödemeleri  4");
                    Console.WriteLine("Ödemeler 5");
                    Console.WriteLine("Bilgi Güncelleme 6");
                    Console.WriteLine("Çıkış için 0");
                    basilan = Convert.ToInt32(Console.ReadLine());

                    if (basilan == 1)
                        return Secim(yenipara, sifre);
                    if (basilan == 2)
                        return Secim(basilan, yenipara, sifre);
                    if (basilan == 3)
                        return Secim(yenipara, "baki ilhan öztürk", sifre);
                    if (basilan == 4)
                        return EgitimOdemeleri(yenipara, sifre);
                    if (basilan == 5)
                        return Odemeler(yenipara, sifre);
                    if (basilan == 6)
                        return sifreGuncelleme(yenipara, sifre);
                    if(basilan != 1 && basilan != 2 && basilan != 3 && basilan != 4 && basilan != 5
            && basilan != 6 && basilan != 0)
                        Console.WriteLine("************ Hatalı Tuşlama *************");
                }
                catch (Exception)
                {

                    Console.WriteLine("************* Hatalı tuşlama **********");
                }

            } while (basilan!=1 && basilan!=2 && basilan!=3 && basilan != 4 && basilan != 5
            && basilan != 6 && basilan != 0);


            return exit(yenipara);
            
        } 
        #endregion
        //static object AnaMenu(double para,string ad)
        //{
        //    double yenipara = para;
        //    int basilan = 0;
        //    Console.WriteLine("             ***********Ana Menü************");
        //    Console.WriteLine();
        //    Console.WriteLine("Bakiye : " + para);
        //    Console.WriteLine("Para Çekme  1");
        //    Console.WriteLine("Para Yatırmak  2");
        //    Console.WriteLine("Para Transferi  3");
        //    Console.WriteLine("Eğitim Ödemeleri  4");
        //    Console.WriteLine("Ödemeler 5");
        //    Console.WriteLine("Bilgi Güncelleme 6");
        //    basilan = Convert.ToInt32(Console.ReadLine());

        //    if (basilan == 1)
        //        return Secim(yenipara);
        //    if (basilan == 2)
        //        return Secim(basilan, yenipara);
        //    if (basilan == 3)
        //        return Secim(yenipara,);
        //    //if (basilan == 4)
        //    //    return Secim(EğitimÖdemeler);
        //    //if (basilan == 5)
        //    //    return Secim(Ödemeler);
        //    //if (basilan == 6)
        //    //    return Secim(BilgiGuncelleme);



        //    return 0;
        //}

        #region KartLı Kartsız Sorgu
        static object KartliKartsizİslem(int basilan, double para,string Gsifre)
        {

            int hak = 0;
            if (basilan == 1)
            {
                Console.WriteLine("            *********** Kartlı İşlem Bölümü ***************");
                do
                {
                    Console.WriteLine("Şifre Giriniz");
                    string sifre = Console.ReadLine();
                    if (sifre != Gsifre)
                    {
                        hak++;
                        Console.WriteLine("Hatalı Şifre");
                        Console.WriteLine(hak + " hakkınızı Kullandınız.");
                    }
                    if (sifre == Gsifre)
                        break;

                } while (hak != 3);

                if (hak == 3)
                    return "Kartınız Bloke edildi";
            }
            else
            {
                Console.WriteLine("         ******************* Kartsız İşlem Bölümü ****************");
                do
                {
                    Console.WriteLine("Şifre Giriniz");
                    string sifre = Console.ReadLine();
                    if (sifre != Gsifre)
                    {
                        hak++;
                        Console.WriteLine("Hatalı Şifre");
                        Console.WriteLine(hak + " hakkınızı kullandınız.");
                    }
                    if (sifre == Gsifre)
                        break;

                } while (hak != 3);

                if (hak == 3)
                    return "Hesabınız Bloke edilmiştir";
            }

            return AnaMenu(para,Gsifre);
        } 
        #endregion

        #region Cekilecek Para
        static object Secim(double para,string Gsifre)
        {
            string sifre = Gsifre;
            double miktar = 0;
            double yeniPara = para;
            int basilan = 0;
            Console.WriteLine("              ************ Para Çekme **************");


            do
            {
                try
                {


                    Console.WriteLine("Cekilecek Miktarı Giriniz : ");
                    miktar = double.Parse(Console.ReadLine());
                   
                    if (yeniPara < miktar || miktar <= 0)
                    {
                        if (miktar <= 0)
                            Console.WriteLine("********** Hatalı tuşlama ********");
                        else
                            Console.WriteLine("Yetersiz Bakiye");
                        Console.WriteLine("Ana Menüye Dönmek içim 9");
                        Console.WriteLine("Çıkmak için 0");
                        basilan = int.Parse(Console.ReadLine());
                    }
                    else if (yeniPara >= miktar && miktar > 0)
                    {

                        Console.WriteLine("Ana Menüye Dönmek içim 9");
                        Console.WriteLine("Çıkmak için 0");
                        basilan = int.Parse(Console.ReadLine());
                        if (basilan == 0 || basilan == 9)
                            yeniPara = para - miktar;

                    }   
                    if(basilan !=0 && basilan !=9)
                        Console.WriteLine("********** Hatalı Tuşlama ***********");


                }
                catch (Exception)
                {

                    Console.WriteLine("Hatalı Tuşlama ");
                    basilan = 1;


                }


            } while (basilan != 0 && basilan != 9);

            if (basilan == 9)
                return AnaMenu(yeniPara,sifre);
            
            return exit(yeniPara);

        }
        #endregion

        #region Para Yatırma
        static object Secim(int basilan, double para,string Gsifre)
        {
            string sifre = Gsifre;
            basilan = 0;
            double yeniPara = para;
            Console.WriteLine("             *********** Para Yatıma ************* ");

            do
            {
                try
                {
                    Console.WriteLine("Kredi Kartına 1");
                    Console.WriteLine("Kendi Hesabınıza 2");
                    Console.WriteLine("Ana Menu 9");
                    Console.WriteLine("Çıkmak için 0");
                    basilan = Convert.ToInt32(Console.ReadLine());
                    if (basilan != 1 && basilan != 0 && basilan != 9 && basilan != 2)
                        Console.WriteLine("********** Hatalı Tuşlama ***********");

                }
                catch (Exception)
                {
                    Console.WriteLine("*********** Hatali Tuşlama *********");

                }

            } while (basilan != 1 && basilan != 0 && basilan != 9 && basilan != 2);

            if (basilan == 1)
                return Secim1(yeniPara,sifre);
            else if (basilan == 2)
                return Secim1(basilan, yeniPara,sifre);
            else if (basilan == 9)
                return AnaMenu(yeniPara,sifre);

            return exit(yeniPara);
        }
        #endregion
        #region Para Yatırma Kredi Kartı
        static object Secim1(double para,string Gsifre)
        {
            string sifre = Gsifre;
            double yeniPara = para;
            int basilan = 1;
            string kartNo;
            double miktar = 0;
            Console.WriteLine("              *********** Kredi Kartına Para Yatırma ************");

            do
            {
                Console.WriteLine("Kredi Kartı için 12 Haneli kart Numarasını giriniz :");
                
                kartNo = Console.ReadLine();
                if (kartNo.Length != 12)
                {
                    Console.WriteLine("Fazla ya da Eksik numara girdiniz ");
                    Console.WriteLine("Ana Menüye Dönmek için 9");
                    Console.WriteLine("Çıkmak için 0");
                    basilan = int.Parse(Console.ReadLine());
                }
                
                

                if (basilan == 0)
                    return exit(yeniPara);
                else if (basilan == 9)
                    return AnaMenu(yeniPara,sifre);

            } while (kartNo.Length != 12);


            do
            {
                try
                {
                    Console.WriteLine("Yatırılacak miktarı giriniz: ");
                    miktar = double.Parse(Console.ReadLine());
                    if (yeniPara < miktar)
                    {
                        Console.WriteLine("Yetersiz Bakiye");
                        Console.WriteLine("Ana Menüye Dönmek için 9");
                        Console.WriteLine("Çıkmak için 0");
                        basilan = int.Parse(Console.ReadLine());
                    }
                    else if (miktar<=0)
                    {
                        Console.WriteLine("************ Hatalı Tuşlama ***********");
                        Console.WriteLine("Ana Menüye Dönmek için 9");
                        Console.WriteLine("Çıkmak için 0");
                        basilan = int.Parse(Console.ReadLine());
                    }
                    else
                    {

                        Console.WriteLine("Ana Menüye Dönmek içim 9");
                        Console.WriteLine("Çıkmak için 0");
                        basilan = int.Parse(Console.ReadLine());
                        if (basilan == 9 || basilan == 0)
                        {
                            yeniPara = yeniPara - miktar;
                        }

                    }
                    if (basilan != 0 && basilan != 9)
                        Console.WriteLine("********** Hatalı Tuşlama ***********");

                }
                catch (Exception)
                {
                    Console.WriteLine("Hatalı Tuşlama");
                    basilan = 1;
                }
            } while (basilan != 9 && basilan != 0);
            if (basilan == 9)
                return AnaMenu(yeniPara,sifre);




            return exit(yeniPara);
        }
        #endregion
        #region Para Yatırma Hesaba
        static object Secim1(int basilan, double para,string Gsifre)
        {
            string sifre = Gsifre;
            basilan = 0;
            double yeniPara = para;
            double miktar;
            Console.WriteLine("              ************** Hesaba Para Yatırma *************");

            do
            {
                try
                {
                    Console.WriteLine("Hesaba Yatırılacak Miktarı giriniz: ");
                    miktar = double.Parse(Console.ReadLine());
                    if (miktar <= 0)
                    {
                        Console.WriteLine("Hatalı Miktar Girdiniz. ");
                        Console.WriteLine("Ana Menüye Dönmek içim 9");
                        Console.WriteLine("Çıkmak için 0");
                        basilan = int.Parse(Console.ReadLine());
                    }
                    if (miktar > 0)
                    {

                        Console.WriteLine("Ana Menüye Dönmek içim 9");
                        Console.WriteLine("Çıkmak için 0");
                        basilan = int.Parse(Console.ReadLine());
                        if (basilan == 0 || basilan == 9)
                            yeniPara = yeniPara + miktar;
                    }
                    if (basilan != 9 && basilan != 0)
                    {
                        Console.WriteLine("******* Hatalı Tuşlama");
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("******** Tuşlama *******");
                    basilan = 1;
                }

            } while (basilan != 9 && basilan != 0);
            if (basilan == 9)
            {
                return AnaMenu(yeniPara,sifre);
            }

            return exit(yeniPara);
        }
        #endregion

        #region Para Transferi
        static object Secim(double para, string adi,string Gsifre)
        {
            string sifre = Gsifre;
            double yeniPara = para;
            string adSoyad = adi;
            int basilan = 0;
            Console.WriteLine("            *********** Para Transferi *************");

            do
            {
                try
                {
                    Console.WriteLine("Başka Hesaba EFT 1");
                    Console.WriteLine("Başka Hesaba Havale 2");
                    Console.WriteLine("Ana Menu 9");
                    Console.WriteLine("Çıkmak için 0");
                    basilan = Convert.ToInt32(Console.ReadLine());
                    if(basilan != 1 && basilan != 0 && basilan != 9 && basilan != 2)
                        Console.WriteLine("********** Hatalı Tuşlama ***********");

                }
                catch (Exception)
                {
                    Console.WriteLine("*********** Hatali Tuşlama. *********");
                    basilan = 4;

                }

            } while (basilan != 1 && basilan != 0 && basilan != 9 && basilan != 2);

            if (basilan == 1)
                return Secim2(yeniPara, adSoyad,sifre);
            else if (basilan == 2)
                return Secim2(basilan, yeniPara, adSoyad,sifre);
            else if (basilan == 9)
                return AnaMenu(yeniPara,sifre);

            return exit(yeniPara);
        } 
        #endregion
        #region Para Transferi Başka Hesaba EFT
        static object Secim2(double para, string adi,string Gsifre)
        {
            string sifre = Gsifre;
            double yeniPara = para;
            string adSoyad;
            string kartNo;
            double miktar = 0;
            int basilan = 1;
            Console.WriteLine("               **************** Başka Hesaba EFT ************");

            do
            {
                Console.WriteLine("EFT için 12 Haneli Hesap Numarasını giriniz :");
                Console.Write("TR");
                kartNo = Console.ReadLine();
                if (kartNo.Length != 12)
                {
                    Console.WriteLine("Fazla ya da Eksik numara girdiniz ");
                    Console.WriteLine("Ana Menüye Dönmek için 9");
                    Console.WriteLine("Çıkmak için 0");
                    basilan = int.Parse(Console.ReadLine());
                }
                

                if (basilan == 0)
                    return exit(yeniPara);
                else if (basilan == 9)
                    return AnaMenu(yeniPara,sifre);


            } while (kartNo.Length != 12);

            do
            {
                try
                {
                    Console.WriteLine("Hesap Sahibi : ");
                    adSoyad = Console.ReadLine().ToLower();
                    Console.WriteLine("Yatırılacak miktarı giriniz: ");
                    miktar = double.Parse(Console.ReadLine());

                    if (yeniPara < miktar)
                    {
                        Console.WriteLine("Yetersiz Bakiye");
                        Console.WriteLine("Ana Menüye Dönmek için 9");
                        Console.WriteLine("Çıkmak için 0");
                        basilan = int.Parse(Console.ReadLine());
                    }
                    else if (miktar <= 0)
                    {
                        Console.WriteLine("Yanlış Miktar Girdiniz.");
                        Console.WriteLine("Ana Menüye Dönmek için 9");
                        Console.WriteLine("Çıkmak için 0");
                        basilan = int.Parse(Console.ReadLine());

                    }
                    else if (adSoyad != adi)
                    {
                        Console.WriteLine("Hesap Sahibi isimleri Eşleşmedi ");
                        Console.WriteLine("Ana Menüye Dönmek için 9");
                        Console.WriteLine("Çıkmak için 0");
                        basilan = int.Parse(Console.ReadLine());
                    }
                    else
                    {

                        Console.WriteLine("Ana Menüye Dönmek içim 9");
                        Console.WriteLine("Çıkmak için 0");
                        basilan = int.Parse(Console.ReadLine());
                        if (basilan == 9 || basilan == 0)
                        {
                            yeniPara = yeniPara - miktar;
                        }

                    }
                    if (basilan != 9 && basilan != 0)
                    {
                        Console.WriteLine("****************  Hatalı Tuşlama ***************");
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Hatalı Tuşlama");
                    basilan = 1;
                }
            } while (basilan != 9 && basilan != 0);

            if (basilan == 9)
                return AnaMenu(yeniPara,sifre);


            return exit(yeniPara);
        }
        #endregion
        #region Para Transferi Başka Hesaba Havale
        static object Secim2(int basilan, double para, string adi,string Gsifre)
        {
            string sifre = Gsifre;
            double yeniPara = para;
            string adSoyad;
            string kartNo;
            double miktar = 0;
            basilan = 1;
            Console.WriteLine("             ************** Başka Hesaba Havale ************");

            do
            {
                Console.WriteLine("Havale için 11 Haneli Hesap Numarasını giriniz :");

                kartNo = Console.ReadLine();
                if (kartNo.Length != 11)
                {
                    Console.WriteLine("Fazla ya da Eksik numara girdiniz ");
                    Console.WriteLine("Ana Menüye Dönmek için 9");
                    Console.WriteLine("Çıkmak için 0");
                    basilan = int.Parse(Console.ReadLine());
                }
               

                if (basilan == 0)
                    return exit(yeniPara);
                else if (basilan == 9)
                    return AnaMenu(yeniPara,sifre);


            } while (kartNo.Length != 11);

            do
            {
                try
                {
                    Console.WriteLine("Hesap Sahibi : ");
                    adSoyad = Console.ReadLine().ToLower();
                    Console.WriteLine("Yatırılacak miktarı giriniz: ");
                    miktar = double.Parse(Console.ReadLine());

                    if (yeniPara < miktar)
                    {
                        Console.WriteLine("Yetersiz Bakiye");
                        Console.WriteLine("Ana Menüye Dönmek için 9");
                        Console.WriteLine("Çıkmak için 0");
                        basilan = int.Parse(Console.ReadLine());
                    }
                    else if (miktar <= 0)
                    {
                        Console.WriteLine("Yanlış Miktar Girdiniz.");
                        Console.WriteLine("Ana Menüye Dönmek için 9");
                        Console.WriteLine("Çıkmak için 0");
                        basilan = int.Parse(Console.ReadLine());

                    }
                    else if (adSoyad != adi)
                    {
                        Console.WriteLine("Hesap Sahibi isimleri Eşleşmedi ");
                        Console.WriteLine("Ana Menüye Dönmek için 9");
                        Console.WriteLine("Çıkmak için 0");
                        basilan = int.Parse(Console.ReadLine());
                    }
                    else
                    {

                        Console.WriteLine("Ana Menüye Dönmek içim 9");
                        Console.WriteLine("Çıkmak için 0");
                        basilan = int.Parse(Console.ReadLine());
                        if (basilan == 9 || basilan == 0)
                        {
                            yeniPara = yeniPara - miktar;
                        }

                    }
                    if (basilan != 9 && basilan != 0)
                    {
                        Console.WriteLine("************* Hatalı Tuşlama **********");
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Hatalı Tuşlama");
                    basilan = 1;
                }
            } while (basilan != 9 && basilan != 0);

            if (basilan == 9)
                return AnaMenu(yeniPara,sifre);


            return exit(yeniPara);
        }
        #endregion

        #region Eğitim Ödemeleri
        static object EgitimOdemeleri(double para,string Gsifre)
        {
            string sifre = Gsifre;
            int basilan = 1;
            double yeniPara = para;
            Console.WriteLine("               ********** EĞİTİM ÖDEMELERİ *************");
            do
            {
                try
                {
                    Console.WriteLine("Eğitim Ödemeleri Sayfası Arızalı.");
                    Console.WriteLine("Ana Menüye Dönmek için 9");
                    Console.WriteLine("Çıkmak için 0");
                    basilan = int.Parse(Console.ReadLine());
                    if (basilan != 0 && basilan != 9)
                        Console.WriteLine("********** Hatalı Tuşlama ***********");
                }
                catch (Exception)
                {

                    Console.WriteLine("********** Hatalı Tuşlama ***********");
                    basilan = 1;
                }


            } while (basilan!=0 && basilan!=9);

            if (basilan == 9)
                return AnaMenu(yeniPara,sifre);
            

            return exit(yeniPara);
        }
        #endregion

        #region Ödemeler
        static object Odemeler(double para,string Gsifre)
        {
            string sifre = Gsifre;
            double yeniPara = para;

            int basilan = 0;
            Console.WriteLine("              *********** ÖDEMELER *************");

            do
            {
                try
                {
                    Console.WriteLine("Elektrik Faturası 1");
                    Console.WriteLine("Telefon Faturası 2");
                    Console.WriteLine("İnternet Faturası 3");
                    Console.WriteLine("Su Faturası 4");
                    Console.WriteLine("OGS Ödemeleri 5");
                    Console.WriteLine("Ana Menüye Dönmek için 9");
                    Console.WriteLine("Çıkmak için 0");
                    basilan = Convert.ToInt32(Console.ReadLine());
                    if (basilan != 1 && basilan != 0 && basilan != 9 && basilan != 2 && basilan != 3 && basilan != 4 && basilan != 5)
                        Console.WriteLine("********** Hatalı Tuşlama ***********");

                }
                catch (Exception)
                {
                    Console.WriteLine("*********** Hatali Tuşlama *********");
                    basilan = 6;

                }

            } while (basilan != 1 && basilan != 0 && basilan != 9 && basilan != 2 && basilan != 3 && basilan != 4 && basilan != 5);

            if (basilan == 1)
                return fatura(yeniPara,sifre);
            else if (basilan == 2)
               return fatura(yeniPara,sifre);
            else if (basilan == 3)
                return fatura(yeniPara,sifre);
            else if (basilan == 4)
                return fatura(yeniPara,sifre);
            else if (basilan == 5)
                return fatura(yeniPara,sifre);
            else if (basilan == 9)
                return AnaMenu(yeniPara,sifre);

            return exit(yeniPara);

        }
        #endregion
        #region Fatura Ödeme
        static object fatura(double para,string Gsifre)
        {
            string sifre = Gsifre;
            double miktar = 0;
            double yeniPara = para;
            int basilan = 0;
            Console.WriteLine(             "************ ÖDEME **************");
            do
            {
                try
                {
                    Console.WriteLine("Ödenecek Miktarı Giriniz : ");
                    miktar = double.Parse(Console.ReadLine());

                    if (yeniPara < miktar)
                    {
                        Console.WriteLine("Yetersiz Bakiye");
                        Console.WriteLine("Ana Menüye Dönmek içim 9");
                        Console.WriteLine("Çıkmak için 0");
                        basilan = int.Parse(Console.ReadLine());
                    }
                    else if (miktar <= 0)
                    {
                        Console.WriteLine("Eksi Bakiye Girdiniz");
                        Console.WriteLine("Ana Menüye Dönmek içim 9");
                        Console.WriteLine("Çıkmak için 0");
                        basilan = int.Parse(Console.ReadLine());
                    }
                    else if (yeniPara >= miktar && miktar > 0)
                    {
                        Console.WriteLine("Ödeme Gerçekleşti.");
                        Console.WriteLine("Ana Menüye Dönmek içim 9");
                        Console.WriteLine("Çıkmak için 0");
                        basilan = int.Parse(Console.ReadLine());
                        if (basilan == 0 || basilan == 9)
                            yeniPara = para - miktar;

                    }
                    if (basilan != 0 && basilan != 9)
                    {
                        Console.WriteLine("************ Hatalı Tuşlama ********");
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("*********** Hatalı Tuşlama *************");
                    basilan = 1;

                }
            } while (basilan != 0 && basilan != 9);

            if (basilan == 9)
                return AnaMenu(yeniPara,sifre);

            return exit(yeniPara);

        }
        #endregion

        #region Sifre Guncelleme
        static object sifreGuncelleme(double para, string Gsifre)
        {
            string yeniSifre = Gsifre;
            double yeniPara = para;
            int basilan = 0;
            Console.WriteLine("              *********** Şifre Değişme ************* ");

            do
            {
                try
                {
                    Console.WriteLine("Şifre Değişmek için 1");
                    Console.WriteLine("Ana Menu 9");
                    Console.WriteLine("Çıkmak için 0");
                    basilan = Convert.ToInt32(Console.ReadLine());
                    if (basilan != 1 && basilan != 0 && basilan != 9)
                        Console.WriteLine("********** Hatalı Tuşlama ***********");
                    if (basilan == 1)
                    {
                        Console.WriteLine("Yeni Şifreyi Giriniz :");
                        yeniSifre = Console.ReadLine();

                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("*********** Hatali Tuşlama *********");

                }

            } while (basilan != 1 && basilan != 0 && basilan != 9);

            if (basilan == 1)
            {
                return AnaMenu(yeniPara, yeniSifre);
            }
            else if (basilan == 9)
                return AnaMenu(yeniPara, yeniSifre);


            return exit(yeniPara);
        }
        #endregion

        #region Çıkış
        static string exit(double para)
        {
            Console.WriteLine("             Güncel Bakiyeniz: " + para);
            return "             Yeni Bekleriz iyi günler";
        } 
        #endregion



    }
}
