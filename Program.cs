using System;

// base class for geometric shapes
abstract class BaseGeometrikSekil
{
    public double Genislik { get; set; }
    public double Yukseklik { get; set; }

    // constructor to set common properties
    public BaseGeometrikSekil(double genislik, double yukseklik)
    {
        Genislik = genislik;
        Yukseklik = yukseklik;
    }

    // abstract method
    public abstract double AlanHesapla();
}

// kare sinifi
class Kare : BaseGeometrikSekil
{
    public Kare(double kenar) : base(kenar, kenar) { }

    public override double AlanHesapla()
    {
        return Genislik * Yukseklik;
    }
}

// dikdortgen sinifi
class Dikdortgen : BaseGeometrikSekil
{
    public Dikdortgen(double genislik, double yukseklik) : base(genislik, yukseklik) { }

    public override double AlanHesapla()
    {
        return Genislik * Yukseklik;
    }
}

// dik ucgen sinifi
class DikUcgen : BaseGeometrikSekil
{
    public DikUcgen(double genislik, double yukseklik) : base(genislik, yukseklik) { }

    public override double AlanHesapla()
    {
        return (Genislik * Yukseklik) / 2;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // kare ornegi
        BaseGeometrikSekil kare = new Kare(5);
        Console.WriteLine($"Karenin alanı: {kare.AlanHesapla()}");

        // dikdortgen ornegi
        BaseGeometrikSekil dikdortgen = new Dikdortgen(4, 6);
        Console.WriteLine($"Dikdörtgenin alanı: {dikdortgen.AlanHesapla()}");

        // dik ucgen ornegi
        BaseGeometrikSekil dikUcgen = new DikUcgen(3, 4);
        Console.WriteLine($"Dik üçgenin alanı: {dikUcgen.AlanHesapla()}");
    }
}
