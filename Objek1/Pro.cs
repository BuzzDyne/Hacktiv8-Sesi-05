using System;

class Pro
{
    static void Main(string[] args)
    {
        Laptop l1 = new Laptop();

        l1.merk = "Lenovo";
        l1.ram  = 4;
        l1.storage = 128;

        System.Console.WriteLine("\nMerk Laptop adalah "+ l1.merk);
        System.Console.WriteLine("\nRAM Laptop adalah "+ l1.ram);
        System.Console.WriteLine("\nMemory Laptop adalah "+ l1.storage);

        l1.Chatting();
        l1.Sosmed();
        l1.OnlineShop();
    }
}