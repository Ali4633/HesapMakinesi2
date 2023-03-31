using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapMakinesi2
{
    internal class Program
    {
        //Kullanıcının yapmak istediği işlemi sorar ve kullanıcıdan iki sayı alır hesaplar.daha  
        //sonra işlem yapmak isteyip istemediğini sorar.
        static void Main(string[] args)
        {
            Console.WriteLine("-------HESAP MAKİNESİ--------");

            bool tekrar = false;
            bool sorgu = false;

            do
            {
                Console.WriteLine("Ne tür bir işlem işlem yapmak istiyorsunuz ?");

                Console.WriteLine("1. TOPLAMA");
                Console.WriteLine("2. CIKARMA");
                Console.WriteLine("3. BÖLME");
                Console.WriteLine("4. CARPMA");
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("İşlem seçiniz :");
                string islem = Console.ReadLine();
                Console.ResetColor();

                if (islem == "1" || islem == "2" || islem == "3" || islem == "4")
                {
                    Console.WriteLine("1. sayıyı seçiniz");
                    double Sayi1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("2. sayıyı seçiniz");
                    double Sayi2 = Convert.ToDouble(Console.ReadLine());

                    Console.ForegroundColor = ConsoleColor.Green;
                    switch (islem)
                    {
                        case "1":
                            Console.WriteLine("işlemin sonucu :" + Toplama(Sayi1, Sayi2)); break;
                        case "2":
                            Console.WriteLine("işlemin sonucu :" + Cikarma(Sayi1, Sayi2)); break;
                        case "3":
                            Console.WriteLine("işlemin sonucu :" + Bolme(Sayi1, Sayi2)); break;
                        case "4":
                            Console.WriteLine("işlemin sonucu :" + Carpma(Sayi1, Sayi2)); break;

                    }
                    Console.ResetColor();
                    do
                    {
                        Console.WriteLine("İşlemi tekrarı için : evet, İşlemi bitirmek için : hayır");
                        string durum = Console.ReadLine();
                        Console.WriteLine();

                        if (durum == "evet" || durum == "hayır")
                        {

                            if (durum == "evet")
                            {
                                tekrar = true;
                                sorgu = false;

                            }
                            else
                            {
                                sorgu = false;
                                tekrar = false;
                            }

                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("lütfen doğru işlem giriniz , büyük küçük harf dikkat ediniz !");
                            Console.ResetColor();
                            sorgu = true;
                        }
                    } while (sorgu);


                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("lütfen 1,2,3,4 sayılarından birini seçiniz");
                    Console.ResetColor();
                    tekrar = true;
                }



            } while (tekrar);


            Console.Read();

        }
        static double Toplama(double number1, double number2)
        {
            return number1 + number2;
        }
        static double Cikarma(double number1, double number2)
        {
            return number1 - number2;
        }
        static double Bolme(double number1, double number2)
        {
            return number1 / number2;
        }
        static double Carpma(double number1, double number2)
        {
            return number1 * number2;
        }
    }
}
