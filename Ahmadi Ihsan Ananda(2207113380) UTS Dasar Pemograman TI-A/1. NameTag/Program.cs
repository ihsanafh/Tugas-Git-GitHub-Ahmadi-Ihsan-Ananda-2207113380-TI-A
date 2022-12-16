using System;

namespace UtsDaspro
{
    class NameTag
    {
        public static void Main(string[] args)
        {
            String NamaMu, NIM, Konsentrasi;
            Console.WriteLine("Nama : ");
            NamaMu = Console.ReadLine();
            Console.WriteLine("Nim : ");
            NIM = Console.ReadLine();
            Console.WriteLine("Konsentrasi : ");
            Konsentrasi = Console.ReadLine();

            Console.WriteLine("|*******************************|");
            Console.WriteLine("{0,-8} {1,24}", "|Nama :", $"{NamaMu}|");
            Console.WriteLine("{0,-16} {1,16}", "|", $"{NIM}|");
            Console.WriteLine("|-------------------------------|");
            Console.WriteLine("{0,-16} {1,16}", "|", $"{Konsentrasi}|");
            Console.WriteLine("|*******************************|");
            Console.ReadKey();
        }
    }
}