using System;
using System.Text.RegularExpressions;

namespace _4.Enkripsi
{
    class Program
    {
        public static void Main(string[] args) {
            String Text, Enkripsi = "";
            String huruf = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCabcdefghijklmnopqrstuvwxyzabc";
            Regex enc = new Regex("[^A-Za-z ]");
            do
            {
                Console.Write("Teks : ");
                Text = Console.ReadLine();
            } 
            while(String.IsNullOrEmpty(Text) || enc.IsMatch(Text));

            foreach (Char t in Text)
            {
                Char temp = ' ';
                for (int i = 0; i < huruf.Length; i++)
                {
                    Char c = huruf[i];
                    if (t.Equals(c)) {
                        temp = huruf[i+3];
                        break;
                    } else if (t.Equals(' ')) {
                        temp = ' '; 
                        break;
                    }
                }
                Enkripsi = Enkripsi + temp;
            }
            Console.WriteLine("Hasil Enkripsi : " + Enkripsi);
            Console.ReadKey(); 
        }
    }
}