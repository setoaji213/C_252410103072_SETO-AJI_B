
using System;
class Agen
{
    public string idAgen;
    public string namaAgen;
    public int stokAgen;

    public Agen(string i, string n, int s)
    {
        idAgen = i;
        namaAgen = n;
        stokAgen = s;
    }
    public void TampilInfo()
    {
        Console.WriteLine("ID Agen : " + idAgen);
        Console.WriteLine("Nama Agen : " + namaAgen);
        Console.WriteLine("Stok Agen : " + stokAgen);
    }
}
class ProdukGalon
{
    private string idProduk;
    private string namaProduk;
    private int stokGudang;
    
    private ProdukGalon(string idProduk, string namaProduk, int stokGudang)
    {
        this.idProduk = idProduk;
        this.namaProduk = namaProduk;
        this.stokGudang = stokGudang;
    }


}

class GalonAqua : ProdukGalon
{
    int Hargaproduk;


}

class GalonBerkeran : ProdukGalon
{
    int hargaProduk;

}
public class SindikatGalon
{ 

}

static void Main(string[] args)
{
    Agen agn1 = new Agen("1","Budi", 2);
    Agen agn2 = new Agen("2", "andi", 3);

    agn1.TampilInfo();
    agn2.TampilInfo();
}
