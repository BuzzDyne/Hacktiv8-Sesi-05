using System;

namespace build
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop l1 = new Laptop();

            Console.Write("Merk Laptop: ");
            l1.merk = Console.ReadLine();

            Console.Write("RAM Laptop: ");
            l1.ram  = int.Parse(Console.ReadLine());

            Console.Write("Storage Laptop: ");
            l1.storage = int.Parse(Console.ReadLine());

            System.Console.WriteLine("\n\nMerk Laptop adalah "+ l1.merk);
            System.Console.WriteLine("RAM Laptop adalah "+ l1.ram);
            System.Console.WriteLine("Memory Laptop adalah "+ l1.storage);

            l1.Chatting();
            l1.Sosmed();
            l1.OnlineShop();
        }
    }
}
