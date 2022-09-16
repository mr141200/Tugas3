using System;
using System.Collections.Generic;
using System.Text;

namespace PerancanganAnalisa3
{
    class Soal2
    {
        public void Run()
        {
            Console.Clear();

            Console.WriteLine("\n\nNilai bukan angka akan dikonversi menjadi 0");
            int a, b, c;
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
            Console.Write("Hasil : ");
            if (a==b && b == c)
            {
                Console.WriteLine("SAMA SISI");
            }else if (a==b || a==c || b==c )
            {
                Console.WriteLine("SAMA KAKI");

            }
            else
            {
                Console.WriteLine("SEMBARANG");
            }
            Console.WriteLine("\n\nTekan tombol apapun untuk keluar");
            Console.ReadKey();
        }

    }
}
