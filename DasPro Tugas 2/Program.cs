/* Created By Adel Vanryo*/

using System;

namespace DasPro
{
    class Program
    {  
        //Deklarasi Variabel
        public static int KodeA, KodeB, KodeC, HasilTambah, HasilKali, Level, Kesempatan;
        public static String TebakanA, TebakanB, TebakanC;
        public static bool GameEnd, Check;

        //Method Utama
        static void Main(string[] args)
        {   
            //Memanggil Function Init (Memanggil Variabel)
            Inisial(); 

            //Saat nyawa lebih dari 0 dan level masih dibawah/sama dengan 5, game berjalan
            while(Kesempatan > 0 && Level <= 5) 
            {
                //Cek status boolean playgame
                Check = Play(Level);

                //Jika Jawaban benar
                if(Check)  
                {   
                    //Maka level bertambah
                    Level += 1;
                    Console.WriteLine("Level naik jadi "+Level);
                }
                //Jika jawaban salah
                else
                {
                    //Kesempatan berkurang
                    Kesempatan -= 1;
                    Console.WriteLine("Kesempatan tersisa menjadi "+Kesempatan);
                }

                //Jika level sudah lebih dari 5 dan kesempatan masih ada
                if(Kesempatan > 0 && Level > 5)
                {
                    Console.WriteLine("Game Selesai!!\nLevel terjawab semua.");
                    GameEnd = true;
                }
 
                else if(Kesempatan == 0 && Level != 1)
                {
                    Console.WriteLine("Game Berakhir!!\nLevel terjawab "+(Level-1));
                    GameEnd = true;
                }
                else if(Kesempatan == 0 && Level == 1)
                {
                    Console.WriteLine("Game Berakhir!!\nTidak ada ronde yang berhasil dijawab");
                    GameEnd = true;
                }

                if(GameEnd)
                {
                    break;
                }
            
            }
            Console.Write("\nTekan Enter Untuk Keluar...");
            Console.ReadKey();
        }

        static void Inisial()
        {
            //Inisialisasi Variabel
            Level = 1;
            Kesempatan = 3;
            Check = false;
            GameEnd = false;
        }

 
        static bool Play(int LVL)
        {
            //Random code
            Random rng = new Random();

            KodeA = rng.Next(1,LVL+1);
            KodeB = rng.Next(1,LVL+1);
            KodeC = rng.Next(1,LVL+1);
            
            //Aritmatika kode hint
            HasilTambah = KodeA+KodeB+KodeC;
            HasilKali = KodeA*KodeB*KodeC;

            //Menuliskan intro atau narasi game
            Console.WriteLine("Hello Player! Enjoy The Game!");
            Console.WriteLine(""); 
            Console.WriteLine("Anda adalah agen rahasia yang bertugas mendapatkan data dari server.\nAkses ke server membutuhkan password yang tidak diketahui...");
            Console.WriteLine("- Password terdiri dari 3 angka");
            Console.WriteLine("- jika ditambahkan hasilnya "+ HasilTambah);
            Console.WriteLine("- jika dikalikan hasilnya "+ HasilKali);
            
            //Cheat
            //Console.WriteLine("Kode "+KodeA+", "+KodeB+", "+KodeC+"?");

            //Tebakan
            Console.Write("Masukkan Kode Pertama : ");
            TebakanA = Console.ReadLine();
            Console.Write("Masukkan Kode Kedua : ");
            TebakanB = Console.ReadLine();
            Console.Write("Masukkan Kode Ketiga : ");
            TebakanC = Console.ReadLine();
            Console.WriteLine("Tebakan anda "+TebakanA+", "+TebakanB+", "+TebakanC+"?");
            
            //Jika benar, playgame jadi true
            if(TebakanA == KodeA.ToString() && TebakanB == KodeB.ToString() && TebakanC == KodeC.ToString()){
            
                Console.WriteLine(" \nTebakan Anda Benar...");
                return true;
            }
            else //jika salah, playgame jadi false
            {
                Console.WriteLine(" \nTebakan Anda Salah...");
                return false;
            }
        }
    }
}