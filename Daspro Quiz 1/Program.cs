using System;

namespace dadugameAdelVanryo
{
    class Program
    {
        static int pc;
        static int manusia;
        static int SkorB;
        static int SkorA;
        static Random random = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("Game dadu random");

            for (int i = 0; i < 10; i++){
                playGame();
                Console.WriteLine($"skor anda {SkorA} dan skor pc {SkorB}");
            }

            
        }

        static void playGame(){

            pc = random.Next(1, 7);
            manusia = random.Next(1, 7);
            Console.WriteLine($"Dadu pc adalah {pc} dan dadu dadu anda adalah {manusia}");
            Console.ReadLine();

            if(manusia > pc){
                SkorA= SkorA+ 1;
                Console.WriteLine("anda menang");
            } else if(manusia == pc){
                Console.WriteLine("draw");
            } else {
                SkorB = SkorB + 1;
                Console.WriteLine("anda kalah");
            }


        }
    }
}