def zadanie_1():
    a = float(input("Podaj pierwsza liczbe: "))
    b = float(input("Podaj druga liczbe: "))
    op = input("Wybierz operacje (+, -, *, /): ")

    if op == "+":
        wynik = a + b
    elif op == "-":
        wynik = a - b
    elif op == "*":
        wynik = a * b
    elif op == "/":
        wynik = a / b

    print("Wynik:", wynik)


def zadanie_2():
    kierunek = input("Wybierz konwersje (C lub F): ")
    temp = float(input("Podaj temperature: "))

    if kierunek == "C":
        wynik = temp * 1.8 + 32
        print(f"{temp}C = {wynik}F")
    elif kierunek == "F":
        wynik = (temp - 32) / 1.8
        print(f"{temp}F = {wynik}C")


def zadanie_3():
    n = int(input("Ile ocen chcesz podac? "))
    suma = 0

    for i in range(n):
        ocena = float(input("Podaj ocene: "))
        suma += ocena

    srednia = suma / n
    print("Srednia:", round(srednia, 2))

    if srednia >= 3.0:
        print("Uczen zdawal.")
    else:
        print("Uczen nie zdawal.")


while True:
    print("\nWybierz zadanie:")
    print("1 - Kalkulator")
    print("2 - Konwerter temperatur")
    print("3 - Srednia ocen ucznia")
    print("0 - Zakoncz")
    wybor = input("Twoj wybor: ")

    if wybor == "1":
        zadanie_1()
    elif wybor == "2":
        zadanie_2()
    elif wybor == "3":
        zadanie_3()
    elif wybor == "0":
        break
