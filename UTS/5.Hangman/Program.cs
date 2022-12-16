using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace _5.Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            int Miss = 0; 
            String jawaban = ""; 
            bool wrong = false, Win = false, Lost = false, benar = false;
            Console.Clear();
            string[] Textkode = new string[10];
            Textkode[0] = "white";
            Textkode[1] = "black";
            Textkode[2] = "purple";
            Textkode[3] = "orange";
            Textkode[4] = "red";
            Textkode[5] = "pink";
            Textkode[6] = "green";
            Textkode[7] = "yellow";
            Textkode[8] = "green";
            Textkode[9] = "brown";
            Random randGen = new Random();
            var random = randGen.Next(0, 9);
            string Clue = Textkode[random];
            char[] guess = new char[Clue.Length]; 
 
            for (int p = 0; p < Clue.Length; p++) {
                guess[p] = '_'; 
            }
 
            while (Win == false && Lost == false) 
            {
                Console.Write("Huruf tebakan : ");
                char playerGuess = char.Parse(Console.ReadLine());
                for (int j = 0; j < Clue.Length; j++)
                {
                    if (playerGuess == Clue[j]) { 
                        benar = true; 
                        guess[j] = playerGuess; 
                    } else if (j == Clue.Length - 1 && benar == false){ 
                        wrong = true; 
                    }
                }
                Console.Clear();
                jawaban = new String(guess); 
                if (wrong == true) { 
                    Console.WriteLine("Tebakan anda salah!"); 
                    Miss++; 
                    wrong = false; 
                }
                benar = false; 
                Console.WriteLine(guess); 
                Console.WriteLine();
                switch (Miss)
                {
                    case 1:
                        Console.WriteLine(" |__");
                        break;

                    case 2: 
                        Console.WriteLine(" |\n |\n |\n |\n |__");
                        break;

                    case 3: 
                        Console.WriteLine(" |/\n |\n |\n |\n |\n |__");
                        break;

                    case 4:
                        Console.WriteLine("__________\n |/\n |\n |\n |\n |\n |__");
                        break;

                    case 5:
                        Console.WriteLine("__________\n |/      |\n |\n |\n |\n |\n |__");
                        break;

                    case 6:
                        Console.WriteLine("__________\n |/      |\n |      (_)\n |\n |\n |\n |__");
                        break;
                        
                    case 7:
                        Console.WriteLine("__________\n |/      |\n |      (_)\n |      \\|/\n |\n |\n |__");
                        break;
                        
                    case 8:
                        Console.WriteLine("__________\n |/      |\n |      (_)\n |      \\|/\n |       |\n |\n |__");
                        break;
                        
                    case 9:
                        Console.WriteLine("__________\n |/      |\n |      (_)\n |      \\|/\n |       |\n |      / \\\n |__");
                        break;

                    case 10:
                        Console.WriteLine("__________\n |/      |\n |      (_)\n |      \\|/\n |       |\n |      / \\\n |__");
                        break;

                    default:
                        break;
                }

                if (jawaban == Clue) { 
                    Console.WriteLine("Selamat, anda menang!"); 
                    Win = true; 
                } else if (Miss == 10 && jawaban != Clue) { 
                    Console.WriteLine("Anda kurang beruntung");
                    Lost = true; 
                }
            }
        }
    }
}
