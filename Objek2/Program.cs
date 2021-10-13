using System;

namespace Objek2
{
    class Program
    {
        static void Main(string[] args)
        {
            class_pesawat pesawat = new class_pesawat();
            Console.Write("Pesawat Nama: ");
            pesawat.nama = Console.ReadLine();

            Console.Write("Ketinggian: ");
            pesawat.ketinggian = Console.ReadLine();

            pesawat.Terbang();
            pesawat.SudahTerbang();
        }
    }
}
