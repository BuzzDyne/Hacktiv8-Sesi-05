using System;

class class_pesawat
{
    public string nama;
    private string _ketinggian;
    public string ketinggian
    {
        get {return ketinggian;}
        set {_ketinggian = value;}
    }
    public void Terbang()
    {
        Console.WriteLine("Pesawa dengan nama "+ this.nama + ", sedang take off");
    }
    public void SudahTerbang()
    {
        Console.WriteLine("Ketinggian = "+ this._ketinggian);
    }
}