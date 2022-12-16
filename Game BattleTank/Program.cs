using System;

namespace BattleTank
{
    class Program
    {
        static void Main(string[] argh)
        {
            Intro();
            MulaiMain();
        }

        static void Intro()
        {
            Console.WriteLine("Selamat Datang!!!");
            Console.WriteLine("Hari ini kamu akan bermain game Battle Tank");
            Console.WriteLine($"Terdapat sebanyak 3 Tank yang harus di tebak possisinya");
            Console.WriteLine("Kamu akan memasukkan angka kemungkinan Tank tersebut berada");
            Console.WriteLine("Selamat Bermain!!!\n");
        }

        static void MulaiMain()
        {
            int luasArea = 5;
            char rumput = '~';
            char tank = 't';
            char hit = 'X';
            char miss = 'O';
            int jumlahTank = 3;

            char[,] playArea = buatRuang(luasArea,rumput,tank,jumlahTank);

            print(playArea, rumput, tank);
            
            int jumlahTankTersembunyi = jumlahTank;
            while (jumlahTankTersembunyi > 0)
            {
                int[] tebakanKoordinat = getKoordinatTebakan(luasArea);
                char updateTampilanArea = verifikasiTebakan(tebakanKoordinat, playArea, tank, rumput, hit, miss);
                if (updateTampilanArea == hit)
                {
                    jumlahTankTersembunyi--;
                }
                playArea = updateArea(playArea, tebakanKoordinat, updateTampilanArea);
                print(playArea, rumput, tank);
            }
            Console.WriteLine("Game Over!");
        }
        private static char[,] buatRuang(int luasArea, char rumput, char tank, int jumlahTank)
        {
            char[,] ruangan = new char[luasArea, luasArea];

            for (int baris = 0; baris < luasArea; baris++)
            {
                for (int kolom = 0; kolom < luasArea; kolom++)
                {
                    ruangan[baris,kolom] = rumput;
                }
            }
            return letakkanTank(ruangan, jumlahTank, rumput, tank);
        }
        private static char[,] letakkanTank(char[,]ruangan, int jumlahTank, char rumput, char tank)
        {
            int letakTank = 0;
            int luasArea = 5;

            while (letakTank < jumlahTank)
            {
                int[] lokasiTank = koordinatTank(luasArea);
                char posisi = ruangan[lokasiTank[0], lokasiTank[1]];

                if (posisi==rumput)
                {
                    ruangan[lokasiTank[0], lokasiTank[1]] = tank;
                    letakTank++;
                }
            }
            return ruangan;
        }
        private static int[] koordinatTank(int luasArea)
        {
            Random awm = new Random();
            int[] koordinat = new int[2];
            for (int i = 0; i < koordinat.Length; i++)
            {
                koordinat[i] = awm.Next(luasArea);;
            }
            return koordinat;
        }
        private static void print(char[,] playArea, char rumput, char tank)
        {
            Console.Write("  ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(i + 1 + " ");
            }
            Console.WriteLine();
            for (int baris = 0; baris < 5; baris++)
            {
                Console.Write(baris + 1 + " ");
                for (int kolom = 0; kolom < 5; kolom++)
                {
                    char posisi = playArea[baris, kolom];
                    if (posisi == tank)
                    {
                        Console.Write(rumput + " ");
                    }
                    else
                    {
                        Console.Write(posisi + " ");
                    }
                }
                Console.WriteLine();
            }
        }
        static int[] getKoordinatTebakan(int luasArea)
        {
            int kolom;
            int baris;

            do
            {
                Console.Write("Pilih Baris: ");
                baris = Convert.ToInt32(Console.ReadLine());
            } while (baris < 0 || baris > luasArea + 1);

            do
            {
                Console.Write("Pilih Kolom: ");
                kolom = Convert.ToInt32(Console.ReadLine());
            } while (kolom < 0 || kolom > luasArea + 1);
            return new[]{baris - 1, kolom - 1};
        }
        static char verifikasiTebakan(int[] tebakan, char[,] playArea, char tank, char rumput, char hit, char miss)
        {
            string pesan;;
            int baris = tebakan[0];
            int kolom = tebakan[1];
            char target = playArea[baris, kolom];

            if (target == tank)
            {
                pesan = "HIT!";
                target = hit;
            }
            else if (target == rumput)
            {
                pesan ="MISS!";
                target = miss;
            }
            else
            {
                pesan = "CLEAR!";
            }
            Console.WriteLine(pesan);
            Console.WriteLine("----");
            return target;
        }
        static char[,] updateArea(char[,] area, int[] tebakanKoordinat, char updateTampilanArea)
        {
            int baris = tebakanKoordinat[0];
            int kolom = tebakanKoordinat[1];
            area[baris, kolom] = updateTampilanArea;
            return area;
        }
    }
}