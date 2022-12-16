using System;

namespace _3.TiketBioskop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Nama : ");
            Console.WriteLine("");
            string nama = Console.ReadLine();
            Console.Write("Tahun Kelahiran : ");
            Console.WriteLine("");
            try
            {
                 
                int tahunlahir = int.Parse(Console.ReadLine());
                int usia = 2022 - tahunlahir;
                if (usia < 10 || usia > 60)
                {
                    Console.WriteLine("|****************************|");
                    Console.WriteLine("|       -- Studio 1 --       |");
                    Console.WriteLine("| Nama  :{0,20}|",         nama);
                    Console.WriteLine("| Harga :     Rp.    10000.00|");
                    Console.WriteLine("|----------------------------|");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("|****************************|");
                    Console.WriteLine("|       -- Studio 1 --       |");
                    Console.WriteLine("| Nama  :{0,20}|",         nama);
                    Console.WriteLine("| Harga :     Rp.    25000.00|");
                    Console.WriteLine("|----------------------------|");
                    Console.ReadKey();
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("Tahun Harus Berformat Angka!!");
                Console.ReadKey();
            }
        }
    }
}
