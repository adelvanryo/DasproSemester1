using System;

namespace BattleTank_AdelVanryo
{
    class Program
    {
        static int[] Tebak = {0,0};
        static int Jawaban = 0;
        static bool Game = true;
        static int truth = 0; 
        static char[,] tank = {
            {' ','1','2','3','4','5'},
            {'1','~','~','~','~','~'},
            {'2','~','~','~','~','~'},
            {'3','~','~','~','~','~'},
            {'4','~','~','~','~','~'},
            {'5','~','~','~','~','~'}
        };
        static int[,] ans = {
            {1,5},
            {2,4},
            {5,2},
        };
        static int[,] recent = {
            {0,0},
            {0,0},
            {0,0}
        };

        static void Main(string[] args)
        {
            while(Game)
            {
                DrawTank();
                try
                {   
                    Console.Write("Ada 3 Tank Yang Bersembunyi. Anda Diharuskan Menghancurkan Ketiga Tank Tersebut!\nPilih baris: "); Tebak[0] = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Pilih kolom: "); Tebak[1] = Convert.ToInt32(Console.ReadLine());
                }catch(Exception e){
                    Console.WriteLine("Error: Angka Yang Anda Masukkan Bukan Angka Yang Valid");
                }
                truth = cekTank();
                if(truth ==2 )
                {
                    Console.WriteLine("Tank Sudah Hancur!");

                }
                else
                if(truth == 1)
                {
                    Console.WriteLine("Boom! Tank hancur!");
                    Jawaban++;
                }
                else
                {
                    Console.WriteLine("Pilihan Anda Meleset!");
                }
                if(Jawaban >= 3)
                {
                    Console.WriteLine("\nSelamat, Anda Menang! Tank Telah Hancur Semua!");
                    DrawTank();
                    Game=false;
                }
                Console.WriteLine();
            }
        }

        static void DrawTank()
        {
            for(int i=0;i<6;i++)
            {
                for(int j=0;j<6;j++)
                {
                    Console.Write(tank[i,j] + " ");
                }
                Console.WriteLine();
            }
        }

        static int cekTank()
        {
            for(int i=0;i<3;i++)
            {
                if(recent[i,0] == Tebak[0] && recent[i,1] == Tebak[1])
                {
                    return 2;
                }
            }
            for(int i=0;i<3;i++)
            {
                if(ans[i,0] == Tebak[0] && ans[i,1] == Tebak[1])
                {
                    tank[Tebak[0],Tebak[1]] = 'X';
                    recent[i,0] = Tebak[0];
                    recent[i,1] = Tebak[1];
                    return 1;
                }
                else
                {
                    tank[Tebak[0],Tebak[1]] = '0';
                }
            }
            return 0;
        }
    }
}