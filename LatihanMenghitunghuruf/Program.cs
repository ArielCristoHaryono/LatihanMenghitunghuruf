using System;

namespace LatihanMenghitunghuruf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("INPUT KALIMAT: ");
            var kalimat = Console.ReadLine();

            Console.Write("INPUT KATA: ");
            var kata = Console.ReadLine();
            while (kata.Length < 4)
            {
                Console.WriteLine("huruf pada kata kurang panjang");
                Console.Write("INPUT KATA : ");
                kata = Console.ReadLine();
            }

        }
    }
}
