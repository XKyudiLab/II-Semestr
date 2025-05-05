class Car:
    def __init__(self, marka, model, typ, cena_za_dzien):
        self.marka = marka
        self.model = model
        self.typ = typ
        self.cena_za_dzien = cena_za_dzien

    def __str__(self):
        return f"{self.marka} {self.model} ({self.typ})"

class Customer:
    def __init__(self, imie_i_nazwisko, numer_prawa_jazdy):
        self.imie_i_nazwisko = imie_i_nazwisko
        self.numer_prawa_jazdy = numer_prawa_jazdy

class Rental:
    def __init__(self, samochod, klient, liczba_dni):
        self.samochod = samochod
        self.klient = klient
        self.liczba_dni = liczba_dni
        self.koszt_calkowity = samochod.cena_za_dzien * liczba_dni

    def __str__(self):
        return f"{self.klient.imie_i_nazwisko} wypożyczył(a) {self.samochod.marka} {self.samochod.model} na {self.liczba_dni} dni. Koszt: {self.koszt_calkowity:.2f} zł"

samochod1 = Car("Toyota", "Corolla", "Sedan", 120)
klient1 = Customer("Anna Kowalska", "XYZ123456")
wypozyczenie1 = Rental(samochod1, klient1, 3)

print(samochod1)
print(wypozyczenie1)
