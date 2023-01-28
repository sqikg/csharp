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
            if(!plansza.Contains(wspolzendne))
            {
                Console.WriteLine("Odpowiedź nie jest prawidłowa");
                continue;
            } 
            plansza[Convert.ToInt32(wspolzendne) - 1] = KogoRuch;
            RysujPlansze(plansza);
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
}

