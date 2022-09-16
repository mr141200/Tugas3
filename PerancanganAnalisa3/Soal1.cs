using System;
using System.Collections.Generic;
using System.Text;

namespace PerancanganAnalisa3
{
    class Soal1
    {

        public void Run()
        {
            Console.Clear();
            Console.WriteLine("\n\nNilai bukan angka akan dikonversi menjadi 0");
            Int32 a, b, c, nilaiTengah;
            Console.Write($"Masukkan angka ke 1 : ");
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {

                a = 0;
            }
            Console.Write($"Masukkan angka ke 2 : ");
            try
            {
                b = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {

                b = 0;
            }
            Console.Write($"Masukkan angka ke 3 : ");
            try
            {
                c = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {

                c = 0;
            }
            // 1 , 2, 3
            Console.WriteLine($"daftar angka: {a}, {b}, {c}");
            // 1 > 2
            if (a > b)
            {
                // 2 > 3
                if (b > c)
                {
                    // 2
                    nilaiTengah = b;
                } 
                else if (a > c)
                {
                    nilaiTengah = c;
                }
                else
                {
                    nilaiTengah = c;
                }
            }
            else
            {
                if (a > c)
                {
                    nilaiTengah = a;
                }else if (b > c)
                {
                    nilaiTengah = c;
                }else
                {
                    nilaiTengah = b;
                }
            }
            Console.WriteLine($"nilai tengah = {nilaiTengah}");
            Console.WriteLine("\n\nTekan tombol apapun untuk keluar");
            Console.ReadKey();
        }
    }
}
