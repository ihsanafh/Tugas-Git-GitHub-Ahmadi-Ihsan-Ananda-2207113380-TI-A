using System;

namespace UtsDaspro
{
    class GameBatuGuntingKertas
    {
        static void Main(string[] args)
        {
            int win = 0;
            int lose = 0;
            int draw = 0;
            char pemain = ' ';
            Random rnd = new Random();
            Console.WriteLine("Batu, Gunting, Kertas");

            while (pemain !='e')
            {
                Console.Write("Choose [b]atu, [g]unting, [k]ertas, or [e]xit : ");
                pemain = Convert.ToChar(Console.ReadLine());
            

                if (pemain == 'e')
                {
                    break;
                }

                int komputer = rnd.Next(1, 4);
                if(pemain == 'b')
                {
                    if(komputer == 1)
                    {
                        Console.WriteLine("Komputer memilih batu");
                        Console.WriteLine("Hasil Seri!");
                        draw++;
                    }
                    else if (komputer == 2)
                    {
                        Console.WriteLine("Komputer memilih gunting");
                        Console.WriteLine("Anda Menang!");
                        win++;
                    }
                    else if (komputer == 3)
                    {
                        Console.WriteLine("Komputer memilih kertas");
                        Console.WriteLine("Anda Kalah!");
                        lose++;
                    }
                }
                else if(pemain == 'g')
                {
                    if(komputer == 1)
                    {
                        Console.WriteLine("Komputer memilih batu");
                        Console.WriteLine("Anda Kalah!");
                        lose++;
                    }   
                    else if(komputer == '2')
                    {
                        Console.WriteLine("Komputer memilih gunting");
                        Console.WriteLine("Hasil Seri!");
                        draw++;
                    }
                    else if(komputer == 3)
                    {
                        Console.WriteLine("Komputer memilih kertas");
                        Console.WriteLine("Kamu Menang!");
                        win++;
                    }
                }
                else if(pemain == 'k')
                {
                    if(komputer == 1)
                    {
                        Console.WriteLine("Komputer memilih batu");
                        Console.WriteLine("Kamu Menang!");
                        win++;
                    }
                    else if(komputer == 2)
                    {
                        Console.WriteLine("Komputer memilih gunting");
                        Console.WriteLine("Kamu Kalah!");
                        lose++;
                    }
                    else if(komputer == 3)
                    {
                        Console.WriteLine("Komputer memilih kertas");
                        Console.WriteLine("Hasil Seri!");
                        draw++;
                    }
                    
                }
                Console.WriteLine("Skor : " + win + " menang " + lose + " kalah " + draw + " seri ");
                Console.WriteLine("Tekan Enter Untuk Melanjutkan Permainan...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}