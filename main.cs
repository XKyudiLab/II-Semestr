using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nWybierz zadanie:");
            Console.WriteLine("1 - Kalkulator");
            Console.WriteLine("2 - Konwerter temperatur");
            Console.WriteLine("3 - Srednia ocen ucznia");
            Console.WriteLine("0 - Zakoncz");
            Console.Write("Twoj wybor: ");
            string wybor = Console.ReadLine();

            switch (wybor)
            {
                case "1":
                    Zadanie1();
                    break;
                case "2":
                    Zadanie2();
                    break;
                case "3":
                    Zadanie3();
                    break;
                case "0":
                    return;
            }
        }
    }

    static void Zadanie1()
    {
        Console.Write("Podaj pierwsza liczbe: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Podaj druga liczbe: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Wybierz operacje (+, -, *, /): ");
        string op = Console.ReadLine();

        double wynik = 0;

        if (op == "+")
            wynik = a + b;
        else if (op == "-")
            wynik = a - b;
        else if (op == "*")
            wynik = a * b;
        else if (op == "/")
            wynik = a / b;

        Console.WriteLine("Wynik: " + wynik);
    }

    static void Zadanie2()
    {
        Console.Write("Wybierz konwersje (C lub F): ");
        string kierunek = Console.ReadLine();

        Console.Write("Podaj temperature: ");
        double temp = double.Parse(Console.ReadLine());

        if (kierunek == "C")
        {
            double wynik = temp * 1.8 + 32;
            Console.WriteLine($"{temp}C = {wynik}F");
        }
        else if (kierunek == "F")
        {
            double wynik = (temp - 32) / 1.8;
            Console.WriteLine($"{temp}F = {wynik}C");
        }
    }

    static void Zadanie3()
    {
        Console.Write("Ile ocen chcesz podac? ");
        int n = int.Parse(Console.ReadLine());

        double suma = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write("Podaj ocene: ");
            double ocena = double.Parse(Console.ReadLine());
            suma += ocena;
        }

        double srednia = suma / n;
        Console.WriteLine("Srednia: " + Math.Round(srednia, 2));

        if (srednia >= 3.0)
            Console.WriteLine("Uczen zdawal.");
        else
            Console.WriteLine("Uczen nie zdawal.");
    }
}
