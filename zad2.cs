using System;

class Car
{
    public string Marka { get; }
    public string Model { get; }
    public string Typ { get; }
    public decimal CenaZaDzien { get; }

    public Car(string marka, string model, string typ, decimal cenaZaDzien)
    {
        Marka = marka;
        Model = model;
        Typ = typ;
        CenaZaDzien = cenaZaDzien;
    }

    public override string ToString()
    {
        return $"{Marka} {Model} ({Typ})";
    }
}

class Customer
{
    public string ImieINazwisko { get; }
    public string NumerPrawaJazdy { get; }

    public Customer(string imieINazwisko, string numerPrawaJazdy)
    {
        ImieINazwisko = imieINazwisko;
        NumerPrawaJazdy = numerPrawaJazdy;
    }
}

class Rental
{
    public Car Samochod { get; }
    public Customer Klient { get; }
    public int LiczbaDni { get; }
    public decimal KosztCalkowity { get; }

    public Rental(Car samochod, Customer klient, int liczbaDni)
    {
        Samochod = samochod;
        Klient = klient;
        LiczbaDni = liczbaDni;
        KosztCalkowity = samochod.CenaZaDzien * liczbaDni;
    }

    public override string ToString()
    {
        return $"{Klient.ImieINazwisko} wypożyczył(a) {Samochod.Marka} {Samochod.Model} na {LiczbaDni} dni. Koszt: {KosztCalkowity:F2} zł";
    }
}

class Program
{
    static void Main()
    {
        var samochod1 = new Car("Toyota", "Corolla", "Sedan", 120);
        var klient1 = new Customer("Anna Kowalska", "XYZ123456");
        var wypozyczenie1 = new Rental(samochod1, klient1, 3);

        Console.WriteLine(samochod1);
        Console.WriteLine(wypozyczenie1);
    }
}
