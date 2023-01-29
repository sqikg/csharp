namespace Filip;
class Program
{
    static void Main(string[] args)
    {

        string wspolzendne;
        string KogoRuch = "x";

        string[] plansza = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        RysujPlansze(plansza);

        while (true)
        {
            Console.WriteLine($"Graczu {KogoRuch}, wybierz swoją liczbę.");
            wspolzendne = Console.ReadLine();
            if (!plansza.Contains(wspolzendne))
            {
                Console.WriteLine("Odpowiedź nie jest prawidłowa");
                continue;
            }
            plansza[Convert.ToInt32(wspolzendne) - 1] = KogoRuch;
            RysujPlansze(plansza);
            if(SprawdzWygrana(plansza) != "n")
            {
                Console.WriteLine("WYGRANA");
                Console.ReadLine();
            };
            KogoRuch = KogoRuch == "x" ? "o" : "x";
        }
    }
    static void RysujPlansze(string[] plansza)
    {
        Console.Clear();
        Console.WriteLine(@$"{plansza[0]}|{plansza[1]}|{plansza[2]}
{plansza[3]}|{plansza[4]}|{plansza[5]}
{plansza[6]}|{plansza[7]}|{plansza[8]}");
    }
    static string SprawdzWygrana(string[] plansza)
    {
        List<int[]> KombinacjeWygranych = new List<int[]>();

        KombinacjeWygranych.Add(new int[] { 1, 2, 3 });
        KombinacjeWygranych.Add(new int[] { 4, 5, 6 });
        KombinacjeWygranych.Add(new int[] { 7, 8, 9 });
        KombinacjeWygranych.Add(new int[] { 1, 4, 7 });
        KombinacjeWygranych.Add(new int[] { 2, 5, 8 });
        KombinacjeWygranych.Add(new int[] { 3, 6, 9 });
        KombinacjeWygranych.Add(new int[] { 1, 5, 9 });
        KombinacjeWygranych.Add(new int[] { 1, 2, 3 });

        foreach(var kombinacja in KombinacjeWygranych)
        {
            if(plansza[kombinacja[0]] == plansza[kombinacja[1]] && plansza[kombinacja[0]] == plansza[kombinacja[1]])
            {
                return plansza[kombinacja[0]];
            }
        }
        return "n";
    }
}

