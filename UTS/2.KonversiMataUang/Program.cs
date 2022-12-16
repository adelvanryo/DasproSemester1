using System;

namespace _2.KonversiMataUang
{
    class Program
    {

        static void Main(string[] args)
        {

            float usd, rp, kali;
            rp = 15358.12f;
             
            try{
            Console.Clear();
            Console.WriteLine("Rate USD Ke RP: ");
            Console.WriteLine(rp);
            
            Console.Write("Jumlah USD:");
            Console.WriteLine();
            usd = Convert.ToSingle(Console.ReadLine());

            kali = rp * usd;

            Console.WriteLine("Hasil Konversi = " +kali);
            Console.ReadKey();
            }
            catch(FormatException){
                Console.WriteLine("Inputan Harus Angka!!");
                Console.ReadKey();
            }

        }
    }
}
