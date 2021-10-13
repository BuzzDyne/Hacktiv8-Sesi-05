using System;
using System.Linq; // For string.All()

namespace Objek3
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = -1;
            string tempChoice = string.Empty;

            bool wantToExit = false;
            string strWantToExit = string.Empty;

            do
            {
                Console.WriteLine("=== Welcome to Sesi 05 ===");

                do
                {
                    Console.Write("\nMenu:\n1. Pesawat\n2. Overloading\n3. Overriding\n4. About Me\n5. Exit\n\nInput (1-5): ");
                    tempChoice =  Console.ReadLine();

                    if(tempChoice.All(char.IsDigit)) {
                        choice = int.Parse(tempChoice);
                        if(1 <= choice && choice <= 5) {
                            break;
                        }
                    }
                } while (true);

                System.Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        Pswt();
                        break;
                    case 2:
                        Overloading();
                        break;
                    case 3:
                        Overide();
                        break;
                    case 4:
                        AboutMe();
                        break;
                    case 5:
                        System.Console.WriteLine("Thank you!\n");
                        Environment.Exit(1);
                        break;
                    default:
                        break;
                }

                // Ask to continue
                do
                {
                    Console.Write("\nBack to Main Menu (y/n)? ");
                    strWantToExit = Console.ReadLine();

                    if(strWantToExit == "y" || strWantToExit == "Y") {
                        wantToExit = false;
                        break;
                    }
                    if(strWantToExit == "n" || strWantToExit == "N") {
                        wantToExit = true;
                        break;
                    }
                } while (true);

            } while (wantToExit == false);
        }

        public static void Pswt()
        {
            Console.WriteLine("=== Pesawat ===");
            Pesawat p = new Pesawat();
            PesawatTempur pt = new PesawatTempur();

            Console.WriteLine("Pesawat 1");
            Console.Write("Nama: ");
            p.nama              = Console.ReadLine();
            Console.Write("JumlahRoda: ");
            p.JumlahRoda        = Console.ReadLine();
            Console.Write("ketinggian: ");
            p.ketinggian        = Console.ReadLine();   
            Console.Write("JumlahPenumpang: ");
            p.JumlahPenumpang   = Console.ReadLine();

            Console.WriteLine("\nPesawat 2");
            Console.Write("Nama: ");
            pt.nama              = Console.ReadLine();   
            Console.Write("JumlahRoda: ");
            pt.JumlahRoda        = Console.ReadLine();   
            Console.Write("ketinggian: ");
            pt.ketinggian        = Console.ReadLine();   
            Console.Write("JumlahPenumpang: ");
            pt.JumlahPenumpang   = Console.ReadLine();

            System.Console.WriteLine("\n");
            p.Terbang();
            System.Console.WriteLine();
            pt.TerbangTinggi();
        }

        public static void Overloading()
        {
            Console.WriteLine("=== Overloading ===");

            Overloading o = new Overloading();
            Console.Write("Masukan Nama: ");
            o.print(Console.ReadLine());

            Console.Write("Masukan Angka: ");
            o.print(int.Parse(Console.ReadLine()));
        }

        public static void Overide()
        {
            int satu, dua;
            Override.OverrideParent ov = new Override.OverrideParent();

            Console.WriteLine("Before");
            Console.Write("Bilangan 1: ");
            satu = int.Parse(Console.ReadLine());
            Console.Write("Bilangan 2: ");
            dua = int.Parse(Console.ReadLine());

            ov.bilangan(satu,dua);
            ov.pnjmlhperkalian();

            ov = new Override.OverrideChild();

            Console.WriteLine("After");
            Console.Write("Bilangan 1: ");
            satu = int.Parse(Console.ReadLine());
            Console.Write("Bilangan 2: ");
            dua = int.Parse(Console.ReadLine());
            ov.bilangan(satu,dua);
            ov.pnjmlhperkalian();
        }

        public static void AboutMe()
        {
            System.Console.WriteLine("\nHalo, Nama saya Ricky asal Jakarta.");
            System.Console.WriteLine("Karena sebelumnya saya sering menggunakan Python, ketika belajar C# masih sering lupa semi-colon (;)");
            System.Console.WriteLine("Selain dari itu, sejauh ini kelas C# Hacktiv8 sangat menarik sih.");
            System.Console.WriteLine("Terima Kasih!");
        }
    }
}
