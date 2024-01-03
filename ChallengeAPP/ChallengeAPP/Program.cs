using ChallengeAPP;

Console.WriteLine("Witaj w programie oceny pracowników");
Console.WriteLine("===================================");
Console.WriteLine();
Console.WriteLine("Dodaj ocenę pracownika");

var emploee1 = new Supervisor("Jan", "Kowalski", "m");

while (true)
{
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }

    try
    {
        emploee1.AddGrade(input);
    }
    catch (Exception EX1)
    {
        Console.WriteLine($"Exception: {EX1.Message}");
    }
}

var statistics = emploee1.GetStatisticsInForEach();
Console.WriteLine($"Średnia ocena: {statistics.Average:N2}");
Console.WriteLine($"Najniższa ocena: {statistics.Min}");
Console.WriteLine($"Najwyższa ocena: {statistics.Max}");
Console.WriteLine($"Ocena: {statistics.AverageLetter}");