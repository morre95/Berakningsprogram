namespace Berakningsprogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej och välkommen till beräkningsprogrammet.");
            Console.WriteLine("Skriv 'hjälp' för hjälp!");
            string command;
            do
            {
                Console.Write("Kommando: ");
                command = Console.ReadLine();
                if (command == "plus")
                {
                    Console.Write("tal 1: ");
                    double X = double.Parse(Console.ReadLine());
                    Console.Write("tal 2: ");
                    double Y = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{X} + {Y} = {X + Y}");
                }
                else if (command == "hjälp")
                {
                    Console.WriteLine($"Tyvärr ej implementerat!");
                }
                else if (command == "division")
                {
                    Console.Write("tal 1: ");
                    double X = double.Parse(Console.ReadLine());
                    Console.Write("tal 2: ");
                    double Y = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{X} / {Y} = {X / Y}");
                }
                else if (command == "sluta")
                {
                    Console.WriteLine("Du vill avsluta alltså?");
                    Console.WriteLine("Okej då gör vi det.....");
                }
                else if (command == "gånger")
                {
                    Console.Write("tal 1: ");
                    double X = double.Parse(Console.ReadLine());
                    Console.Write("tal 2: ");
                    double Y = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{X} * {Y} = {X * Y}");
                }
                else
                {
                    Console.WriteLine($"Okänt kommando: {command}");
                }
            } while (command != "sluta");
            Console.WriteLine("Hej då!");
        }
    }
}