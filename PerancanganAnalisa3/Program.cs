using System;

namespace PerancanganAnalisa3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRun = true;
            while (isRun)
            {
                Console.Clear();
                Console.WriteLine("Nama : Misbah Ramadani");
                Console.WriteLine("\t\tTugas 3");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("1) Soal 1");
                Console.WriteLine("2) Soal 2");
                Console.WriteLine("3) Keluar");
                Console.WriteLine("Pilih nomor menu :");
                string menu = Console.ReadLine();

            
                switch (menu)
                {
                    case "1":
                        Soal1 soal1 = new Soal1();
                        soal1.Run();
                        break;
                    case "2":
                        Soal2 soal2 = new Soal2();
                        soal2.Run();
                        break;
                    case "3":
                        Console.WriteLine("selamat jalan");
                        isRun = false;
                        break;
                    default:
                        Console.WriteLine("pilihan salah");
                        break;
                }
            }
            
        }
    }
}
