using System;

namespace _1.NameTags
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nama, NIM, Konsen;

            Console.Write("Nama : ");
            Console.WriteLine();
            Nama = Console.ReadLine();
            Console.Write("Nim : ");
            Console.WriteLine();
            NIM = Console.ReadLine();
            Console.Write("Konsentrasi : ");
            Console.WriteLine();
            Konsen = Console.ReadLine();

            Console.WriteLine("|*****************************|");
            Console.WriteLine("|Nama :       {0,16}| ",Nama);
            Console.WriteLine("|             {0,16}| ",NIM);
            Console.WriteLine("|-----------------------------|");
            Console.WriteLine("|             {0,16}| ",Konsen);
            Console.WriteLine("|*****************************|");
            Console.ReadLine();
        }
    }
}
