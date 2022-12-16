using System;

namespace UtsDaspro
{
    class DendaPengembalianBuku
    {
        static void Main(string[] args)
        {
            int DendaMu = 0;
            int HariTelat = 0;
            Console.Write("Input jumlah hari peminjaman : ");
            HariTelat = Convert.ToInt32(Console.ReadLine());
            
            if (HariTelat <= 5)
            {
                Console.WriteLine($"Total Denda : {DendaMu}");
            }
            else if (HariTelat > 5 && HariTelat <= 10)
            {
                DendaMu = HariTelat * 10000;
                Console.WriteLine($"Total Denda : {DendaMu}");
            }
            else if (HariTelat > 10 && HariTelat <= 30)
            {
                DendaMu = (HariTelat - 10) * 20000 + 50000;
                Console.WriteLine($"Total Denda : {DendaMu}");
            }
            else if (HariTelat > 30)
            {
                DendaMu = (HariTelat - 30) * 30000 + 50000 + 400000;
                Console.WriteLine($"Total Denda : {DendaMu}");
                Console.WriteLine("Keanggotaan Anda Dibatalkan.");
            }
            Console.ReadKey();
        }
    }
}