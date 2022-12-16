using System;

namespace UtsDaspro
{
    class TebakAngka
    {
        static void Main(string[] args)
        {
            int Tebakan = 0;
            Random rnd = new Random();
            int check = rnd.Next(1, 101);

            while(Tebakan != check)
            {
                Console.WriteLine("Silahkan Tebak Angka 1-100: ");
                Tebakan = Convert.ToInt32(Console.ReadLine());

                if(Tebakan < check)
                {
                    Console.WriteLine("Salah. Nilai terlalu rendah");
                }
                else if(Tebakan > check)
                {
                    Console.WriteLine("Salah. Nilai terlalu tinggi");
                }
                else
                {
                    Console.WriteLine("Anda Benar!");
                    Console.WriteLine("Bye...");
                    Console.ReadKey();
                }
            }
        }
    } 
}