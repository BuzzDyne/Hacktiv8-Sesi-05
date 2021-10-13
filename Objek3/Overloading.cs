using System;

public class Overloading
{
    public string nama;
    public double nomor_telp;
    public void print(string nama)
    {
        this.nama = nama;
        System.Console.WriteLine("Namanya = "+this.nama);
    }
    public void print(double no_telp)
    {
        this.nomor_telp = no_telp;
        System.Console.WriteLine("Nomor HP = "+this.nomor_telp);
    }
}