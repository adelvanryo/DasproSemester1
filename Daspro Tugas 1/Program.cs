/* Created By Adel Vanryo*/

using System;

namespace DasPro
{
    class Program
    { //New Method
        static void Main(string[] args)
        {
            //Ini Variabel
            const int a = 8;
            const int b = 4;
            const int c = 1;
            
            //Operasi Tambah(+), Bagi(/), Kali(*), Kurang(-) Adalah Operator Aritmatika.
            const int hasiltambah = a+b+c;
            const int hasilkali = a*b*c;
            const int hasilkurang = c-b-a;
            const int hasilbagi = c/b/a;

            //Menuliskan Narasi
            Console.WriteLine("Hello World");
            Console.WriteLine(""); 
            Console.WriteLine("Anda adalah agen rahasia yang bertugas mendapatkan data dari server.\nAkses ke server membutuhkan password yang tidak diketahui...");
            Console.WriteLine("- Password terdiri dari 4 angka");
            Console.WriteLine("- jika ditambahkan hasilnya "+ hasiltambah);
            Console.WriteLine("- jika dikalikan hasilnya "+ hasilkali);    
            Console.WriteLine("- jika dikurangkan hasilnya "+  hasilkurang);
            Console.WriteLine("- jika dibagikan hasilnya "+hasilbagi);
           /* Created By Adel Vanryo
            31 Agustus 2022*/
            Console.WriteLine("");
            Console.WriteLine("Enter Code:");
           //Dibawah adalah perintah untuk menampilkan hasil pada CMD
        }


    }
}
