using System;

public class Laptop
{
    public string merk;
    public int ram;
    public int storage;

    public void Chatting() {
        System.Console.WriteLine("\n"+ this.merk + "sedang chatting.");
    }

    public void Sosmed() {
        System.Console.WriteLine("\n"+ this.merk + "sedang Sosmed.");
    }

    public void OnlineShop() {
        System.Console.WriteLine("\n"+ this.merk + "sedang OnlineShop.");
    }
}