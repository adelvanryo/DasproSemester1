using System;
using System.Collections.Generic;

namespace DasProTebakKata
{
    class Program
    {
        static int Kesempatan = 5;
        static string KataMisteri = "Liverpool";
        static List<string> ListTebakan = new List<String>{};
        
    static void Main(string[] args){
            Intro();
            PlayGame();
        }
    
    static void Intro(){
        Console.WriteLine("Selamat Datang, Hari Ini Kita Akan Bermain Tebak Kata");
        Console.WriteLine($"Kamu Punya {Kesempatan} Kesempatan Untuk Menebak Kata Misteri Hari Ini");
        Console.WriteLine("Petunjuknya Ialah Nama Klub Sepakbola");
        Console.WriteLine($"Kata Tersebut Terdiri Dari {KataMisteri.Length} Huruf");
        Console.WriteLine("Klub Apakah Yang Dimaksud??");
        Console.ReadKey();
        Console.WriteLine("");
    }
    
    static void PlayGame(){
        while(Kesempatan>0){
            Console.Write("Apa Huruf Tebakanmu? (Pilih A-Z) : ");
            string input = Console.ReadLine();
            ListTebakan.Add(input);
            if(CekJawaban(KataMisteri, ListTebakan)){
                Console.WriteLine("Selamat Anda Berhasil Menebak Katanya");
                Console.WriteLine($"Kata Misteri Hari Ini Adalah {KataMisteri}");
                break;
            }else if(KataMisteri.Contains(input)){
                Console.WriteLine("Huruf Itu Ada Didalam Kata Ini");
                Console.WriteLine(CekHuruf(KataMisteri, ListTebakan));
            }else{
                Console.WriteLine("Huruf Itu Tidak Ada Didalam Kata Ini");
                Kesempatan--;
                Console.WriteLine($"Kesempatan Anda Tinggal {Kesempatan}");
            }

            if(Kesempatan == 0){
                EndGame();
                break;
            }
        }
    }

    static bool CekJawaban(string KataRahasia, List<string> list){
        bool status = false;
        for (int i = 0 ; i < KataRahasia.Length; i++)
        {
            string c = Convert.ToString(KataRahasia[i]);
            if(list.Contains(c)){
                status = true;
            }else{
                return status = false;
            }
        }

        return status;
    }

    static string CekHuruf(string KataRahasia, List<string> list){
        string x = "";

        for (int i=0; i < KataRahasia.Length; i++)
        {
            string c = Convert.ToString(KataRahasia[i]);
            if(list.Contains(c)){
                x = x + c;
            }else{
                x = x + "-";
            }
        }

        return x;
    }

    static void EndGame()
    {
        Console.WriteLine("Permainan Berakhir");
        Console.WriteLine("Bye..");
    }

    }
}
