// Nama : Khafidz Nurhidayah (Apit Veryo Aryanto)
// materi dan tugas pertama


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReyKalkulator
{
    class Program
    {
        static void method(string[] args)
        {
        }
        static float penambahan(int a, int b)
        {
            return a + b;
        }
        static float pengurangan(int a, int b)
        {
            return a - b;
        }
        static float perkalian(float a, float b)
        {
            return a * b;
        }
        static float pembagian(float a, float b)
        {
            return a / b;
        }
        static void Main(string[] args)
        {
            int menu;

        tampilanmenu:
            {
                Console.Title = "Aplikasi Rey Kalkulator";
                Console.Clear();

                Console.WriteLine("---------------------");
                Console.WriteLine("1. Penambahan");
                Console.WriteLine("2. Pengurangan");
                Console.WriteLine("3. Perkalian");
                Console.WriteLine("4. Pembagian");
                Console.WriteLine("---------------------");
            }

        pilihmenu:
            {
                Console.Write("Pilih menu 1 sampai 4 = ");
                menu = int.Parse(Console.ReadLine());
            }
                if (menu > 4)
            {
                Console.WriteLine("Menu tidak tersedia!!");
                goto pilihmenu;
            }
                 else if (menu < 1)
            {
                Console.WriteLine("Menu tidak Tersedia!!");
                goto pilihmenu;
            }
                 else
            {
                Console.Write("Inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Inputkan nilai b = ");
                int b = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        Console.WriteLine("Hasil Penambahan  " + a + " + " + b + " = " + penambahan(a, b));
                        break;
                    case 2:
                        Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, pengurangan(a, b));
                        break;
                    case 3:
                        Console.WriteLine("hasil perkalian {0} * {1} = {2}", a, b, perkalian(a, b));
                        break;
                    case 4:
                        Console.WriteLine("hasil pembagian {0} / {1} = {2}", a, b, pembagian(a, b));
                        break;
                }
                Console.WriteLine("1.Menghitung ulang!");
                Console.WriteLine("2.Keluar");
            pilihmenukeluar:
                {
                    Console.Write("Pilih menu 1 atau 2 = ");
                    int menukeluar = int.Parse(Console.ReadLine());
                    switch (menukeluar)
                    {
                        case 1:
                            Console.Clear();
                            goto tampilanmenu;
                        case 2:
                            Console.Clear();
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Menu tidak tersedia!!");
                            goto pilihmenukeluar;
                    }
                }
            }
        }
    }
}
