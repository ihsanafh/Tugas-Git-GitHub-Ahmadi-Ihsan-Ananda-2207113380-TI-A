//Tugas Project Game Tebak Kata
//Ahmadi Ihsan Ananda - 22071133800
//Teknik Informatika - A
//MatKul Dasar Pemograman
using System;
using System.Collections.Generic;

namespace TebakHuruf
{
    class Program
    {
        static int kesempatan = 5;
        static string secretWord = "saxophone";
        static List<string> hurufTebakan = new List<string>{}; 

        static void Main(string[] argh)
        {
        Console.ForegroundColor=ConsoleColor.Blue;
        Intro();
        MulaiMain();
        SelesaiMain();
        }
        //Intro
        static void Intro()
        {
            Console.WriteLine("Selamat Datang Dalam Permainan Tebak Kata");
            Console.WriteLine($"Anda Memiliki {kesempatan} Kesempatan Untuk Menebak Kata Misterinya");
            Console.WriteLine("Petunjuk Untuk Kata Ini Adalah Nama Sebuah Alat Musik");
            Console.WriteLine($"Kata Misteri Terdiri Dari {secretWord.Length} Huruf");
            Console.WriteLine("Alat Musik Apakah Yang Dimaksud?!?!?!?\n");
            Console.WriteLine("Klik Enter Untuk Melanjutkan...");
            Console.ReadKey();
        }
        //Play Game
        static void MulaiMain()
        {
            while(kesempatan > 0)
            {
                Console.WriteLine("\nMasukkan huruf tebakan Anda!? (a-z) : ");
                string input = Console.ReadLine().ToLower();;
                hurufTebakan.Add(input);

                if(cekHasil(secretWord,hurufTebakan))
                {
                    Console.WriteLine("\nSelamat anda berhasil menebak kata misterinya...");
                    Console.WriteLine($"\nKata misterinya adalah {secretWord}");
                    break;
                }   
                else if(secretWord.Contains(input))
                {
                    Console.WriteLine($"\nHuruf {input} ada di dalam kata misteri");
                    Console.WriteLine(cekHuruf(secretWord,hurufTebakan));
                    Console.WriteLine("\nMari tebak huruf yang lain...");
                    Console.WriteLine("==============================================");
                } 
                else
                {
                    Console.WriteLine($"\nHuruf {input} tidak ada di dalam kata misteri");
                    kesempatan--;
                    Console.WriteLine($"Kesempatan anda menjawab tinggal {kesempatan}");
                }
            }
        }
        static bool cekHasil(string word, List<string> List)
        {
            bool letakHuruf = false;
            for(int i = 0; i < word.Length; i++)
            {
                string sisaHuruf = Convert.ToString(word[i]);
                if(List.Contains(sisaHuruf))
                {
                    letakHuruf = true;
                } 
                else
                {
                    return letakHuruf = false;
                }
            }
            return letakHuruf;
        }
        static string cekHuruf(string word, List<string> List)
        {
            string letakHuruf = "";
            for(int i = 0; i < word.Length; i++)
            {
                string sisaHuruf = Convert.ToString(word[i]);
                if(List.Contains(sisaHuruf))
                {
                    letakHuruf += sisaHuruf;
                }
                else
                {
                    letakHuruf += "_";
                }
            }
            return letakHuruf;
        }
        //End Game
        static void SelesaiMain()
        {
            Console.WriteLine("Terimakasih telah bermain...");
            Console.WriteLine("Game telah Berakhir...");
            Console.WriteLine("Good Bye...");
            Console.ReadKey();
            if(kesempatan == 0)
            {
                Console.WriteLine($"\nKata misteri yang dimaksud adalah {secretWord}");
                Console.WriteLine("Terimakasih telah bermain...");
                Console.WriteLine("Game telah Berakhir...");
                Console.WriteLine("Good Bye...");
                Console.ReadKey();
            }
            Console.Clear();
            Console.WriteLine("================================================================\n");
            Console.WriteLine("");
            Console.WriteLine("               Terimakasih Telah Bermain Game Ini...             ");
            Console.WriteLine("");
            Console.WriteLine("\n================================================================\n");
            Console.WriteLine("");
            Console.WriteLine("Create By :");
            Console.WriteLine("Nama  : Ahmadi Ihsan Ananda");
            Console.WriteLine("Prodi : Teknik Informatika - A");
            Console.WriteLine("NIM   : 2207113380");
            Console.ReadKey();
        }
    }
}
