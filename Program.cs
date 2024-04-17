// See https://aka.ms/new-console-template for more information

while (true)
{
    Console.WriteLine("Podaj pierwszą liczbę");
    double numb1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Podaj drugą liczbę");
    double numb2 = double.Parse(Console.ReadLine());

    Console.WriteLine(
        "Wybierz operaję: \n1. Dodawanie \n2. Odejmowanie \n3. Mnożenie \n4. Dzielenie"
    );

    int arithmetic = int.Parse(Console.ReadLine());

    double result = 0;

    switch (arithmetic)
    {
        case 1:
            result = numb1 + numb2;
            break;
        case 2:
            result = numb1 - numb2;
            break;
        case 3:
            result = numb1 * numb2;
            break;
        case 4:
            if (numb2 == 0)
            {
                Console.WriteLine(
                    "Nie ryzykuj stabilności kontinuum czasoprzestrzennego dzieląc przez 0"
                );
                continue;
            }
            ;
            result = numb1 / numb2;
            break;
        default:
            Console.WriteLine("chyba coś poszło źle");
            continue;
    }

    Console.WriteLine($"Wynik: {result}");
    Console.WriteLine("Czy chcesz uruchomić kalkulator ponownie? (t/n)");
    string decision = Console.ReadLine().ToLower();

    if (decision != "t")
    {
        break; 
    }
}
Console.WriteLine("naciśnij Enter żeby wyjść...");
Console.ReadLine();
