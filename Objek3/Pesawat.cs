using System;

public class Pesawat
{
    public string nama;
    private string _ketinggian;
    public string ketinggian
    {
        get {return _ketinggian;}
        set {_ketinggian = value;}
    }

    private string _JumlahRoda;
    public string JumlahRoda
    {
        get {return _JumlahRoda;}
        set {_JumlahRoda = value;}
    }

    private string _JumlahPenumpang;
    public string JumlahPenumpang
    {
        get {return _JumlahPenumpang;}
        set {_JumlahPenumpang = value;}
    }

    public void Terbang()
    {
        System.Console.WriteLine("Pesawat \nNama: "+this.nama+"\nJumlah Roda: "+this._JumlahRoda+"\nJumlah Penumpang: "+this._JumlahPenumpang);
    }
}

public class PesawatTempur:Pesawat
{
    public void TerbangTinggi()
    {
        System.Console.WriteLine("Pesawat TEMPUR\nNama: "+this.nama+"\nJumlah Roda: "+this.JumlahRoda+"\nJumlah Penumpang: "+this.JumlahPenumpang);
    }
}