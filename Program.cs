using System;

namespace tydz2lek7
{
    class Program
    {
        static void Main(string[] args)
        {
            // zadanie 1

            int a = 5;
            int b = 5;

            if (a == b)
            {
                Console.WriteLine("ZADANIE 1: Zmienne są równe");
            }
            else
            {
                Console.WriteLine("ZADANIE 1: Zmienne są różne");
            }

            // zasanie 2

            Console.WriteLine("ZADANIE 2: Podaj liczbę całkowitą a program sprawdzi czy jest ona parzysta");
            int liczba = int.Parse(Console.ReadLine());
            int liczba2 = liczba % 2;

            if (liczba2 == 0)
            {
                Console.WriteLine($"{liczba} jest parzysta");
            }
            else
            {
                Console.WriteLine($"{liczba} jest nieparzysta");
            }



            // zadanie 3

            Console.WriteLine("ZADANIE 3: Podaj liczbę całkowitą a program sprawdzi czy jest ona dodatnia czy ujemna");
            int liczba3 = int.Parse(Console.ReadLine());

            if (liczba3 == 0 || liczba3 > 0)
            {
                Console.WriteLine($"{liczba3} jest dodatnia");
            }
            else
            {
                Console.WriteLine($"{liczba3} jest ujemna");
            }

            // zadanie 4

            Console.WriteLine("ZADANIE 4: Podaj rok a program sprawdzi czy jest on przestępny");
            int liczba4 = int.Parse(Console.ReadLine());
            int liczba4a = liczba4 % 4;

            if (liczba4a == 0)
            {
                Console.WriteLine($"{liczba4} jest rokiem przestępnym");
            }
            else
            {
                Console.WriteLine($"{liczba4} nie jest rokiem przestępnym");


                // zadanie 5


                Console.WriteLine("ZADANIE 5: Podaj swój wiek a program sprawdzi czy możesz ubiegać się o stanowisko posła, premiera, senatory, prezydenta");
                int liczba5 = int.Parse(Console.ReadLine());

                if (liczba5 < 21)
                {
                    Console.WriteLine("Nie możesz zostać posłem, premierem, senatorem ani preze=ydentem.");
                }
                else if (liczba5 >= 21 && liczba5 < 30)
                {
                    Console.WriteLine("Możesz zostać tylko posłem");
                }

                else if (liczba5 >= 30 && liczba5 < 35)
                {
                    Console.WriteLine("Możesz zostać posłem, premierem lub senatorem");
                }
                else
                {
                    Console.WriteLine("Możesz zostać posłem, premierem, senatorem lub prezydentem");
                }


                // zadanie 6

                Console.WriteLine("ZADANIE 6: Podaj swój wzrost w cm a program odpowie do jakiej kategorii przynależysz");
                int liczba6 = int.Parse(Console.ReadLine());


                if (liczba6 < 160)
                {
                    Console.WriteLine("Jesteś niskiego wzrostu");
                }
                else if ((liczba6 >= 160) && (liczba6 < 175))
                {
                    Console.WriteLine("Jesteś średniego wzrostu");
                }
                else
                {
                    Console.WriteLine("Jesteś wysokiego wzrostu");
                }


                // zadanie 7

                Console.WriteLine("ZADANIE 7: Podaj 3 liczby a program odpowie, która jest największa");
                int liczba7a = int.Parse(Console.ReadLine());
                int liczba7b = int.Parse(Console.ReadLine());
                int liczba7c = int.Parse(Console.ReadLine());

                if ((liczba7a >= liczba7b) && (liczba7a >= liczba7c))
                {
                    Console.WriteLine($"{liczba7a} jest największa");
                }
                else if ((liczba7b >= liczba7a) && (liczba7b >= liczba7c))
                {
                    Console.WriteLine($"{liczba7b} jest największa");
                }
                else
                {
                    Console.WriteLine($"{liczba7c} jest największa");
                }




                // zadanie 8

                Console.WriteLine("ZADANIE 8: Podaj poniższe dane a program sprawdzi, czy możesz ubiegać się o miejsce na studia");
                Console.WriteLine("Podaj wynik z matury z matematyki");
                int liczba8a = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj wynik z matury z fizyki");
                int liczba8b = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj wynik z matury z chemii");
                int liczba8c = int.Parse(Console.ReadLine());
                int liczba8d = liczba8a + liczba8b + liczba8c;

                if ((liczba8a > 55 && liczba8b > 45 && liczba8c > 45 && liczba8d > 180) || ((liczba8a + liczba8b > 150) || (liczba8a + liczba8c > 150)))
                {
                    Console.WriteLine("Możesz ubiegać się o przyjęcie na studia");
                }
                else
                    Console.WriteLine("Nie możesz ubiegać się o przyjęcie na studia");

                // zadanie 9

                Console.WriteLine("ZADANIE 9: Podaj temperaturę");
                int liczba9 = int.Parse(Console.ReadLine());

                if (liczba9 < 0)
                {
                    Console.WriteLine("Cholernie zimno");
                }
                else if (liczba9 >= 0 && liczba9 <= 10)
                {
                    Console.WriteLine("Zimno");
                }
                else if (liczba9 > 10 && liczba9 <= 20)
                {
                    Console.WriteLine("Chłodno");
                }
                else if (liczba9 > 20 && liczba9 <= 30)
                {
                    Console.WriteLine("W sam raz");
                }
                else if (liczba9 > 30 && liczba9 <= 40)
                {
                    Console.WriteLine("Zaczyna być słabo bo gorąco");
                }
                else
                {
                    Console.WriteLine("a weż wyprowadzam się na Alaskę");
                }

                // zadanie 10
                Console.WriteLine("ZADANIE 10: Podaj 3 liczby a program sprawdzi czy z podanych długości można stworzyć trójkąt");
                Console.WriteLine("Podaj najkrótszą długość");
                int liczba10a = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj środkową długość");
                int liczba10b = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj najdłuższą długość");
                int liczba10c = int.Parse(Console.ReadLine());

                if (liczba10a + liczba10b > liczba10c)
                {
                    Console.WriteLine("Można zbudować trójkąt");
                }
                else
                {
                    Console.WriteLine("Nie można zbudować trójkąta");
                }


                // zadanie 11
                Console.WriteLine("ZADANIE 11: Podaj ocenę");
                int liczba11 = int.Parse(Console.ReadLine());

                if (liczba11 == 6)
                {
                    Console.WriteLine("Celujący");
                }
                else if (liczba11 == 5)
                {
                    Console.WriteLine("Bardzo dobry");
                }
                else if (liczba11 == 4)
                {
                    Console.WriteLine("Dobry");
                }
                else if (liczba11 == 3)
                {
                    Console.WriteLine("Dostateczny");
                }
                else if (liczba11 == 2)
                {
                    Console.WriteLine("Dopuszczający");
                }
                else if (liczba11 == 1)
                {
                    Console.WriteLine("Niedostateczny");
                }
                else
                {
                    Console.WriteLine("Błąd wprowadzania");
                }



                // zadanie 12

                Console.WriteLine("ZADANIE 12: Podaj numer dnia tygodnia");
                int liczba12 = int.Parse(Console.ReadLine());

                if (liczba12 == 1)
                {
                    Console.WriteLine("Poniedziałek");
                }
                else if (liczba12 == 2)
                {
                    Console.WriteLine("Wtorek");
                }
                else if (liczba12 == 3)
                {
                    Console.WriteLine("Sroda");
                }
                else if (liczba12 == 4)
                {
                    Console.WriteLine("Czwartek");
                }
                else if (liczba12 == 5)
                {
                    Console.WriteLine("Piątek");
                }
                else if (liczba12 == 6)
                {
                    Console.WriteLine("Sobota");
                }
                else if (liczba12 == 7)
                {
                    Console.WriteLine("Niedziela");
                }
                else
                {
                    Console.WriteLine("Błąd wprowadzania");

                    // zadanie 13

                    Console.WriteLine("ZADANIE 13: Kalkulator");
                    Console.WriteLine("Podaj pierwszą liczbę:");
                    int liczba13a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Podaj drugą liczbę:");
                    int liczba13b = int.Parse(Console.ReadLine());

                    Console.WriteLine("Podaj numer operacji do wykonania");

                    Console.WriteLine("1. Dodawanie");
                    Console.WriteLine("2. Odejmowanie");
                    Console.WriteLine("3. Mnożenie");
                    Console.WriteLine("4. Dzielenie");

                    int liczba13c = int.Parse(Console.ReadLine());

                    if (liczba13c == 1)
                    {
                        Console.WriteLine($"Twój wynik to:{liczba13a + liczba13b}");
                    }
                    else if (liczba13c == 2)
                    {
                        Console.WriteLine($"Twój wynik to:{liczba13a - liczba13b}");
                    }
                    else if (liczba13c == 3)
                    {
                        Console.WriteLine($"Twój wynik to:{liczba13a * liczba13b}");
                    }
                    else if (liczba13c == 4)
                    {
                        Console.WriteLine($"Twój wynik to:{liczba13a / liczba13b}");
                    }
                    else
                    {
                        Console.WriteLine("Błąd wprowadzania");
                    }
                }
            }
        }
    }
}

