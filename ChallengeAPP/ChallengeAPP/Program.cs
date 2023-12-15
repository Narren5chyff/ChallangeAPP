using ChallengeAPP;

Console.WriteLine("Witaj w programie oceny pracowników");
Console.WriteLine("===================================");
Console.WriteLine();
Console.WriteLine("Dodaj ocenę pracownika");

var emploee1 = new Emploee("Jan", "Kowalski");

while (true)
{
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    emploee1.AddGrade(input);
}

var statistics1 = emploee1.GetStatisticsInForEach();
Console.WriteLine($"Średnia ocena: {statistics1.Average:N2}");
Console.WriteLine($"Najniższa ocena: {statistics1.Min}");
Console.WriteLine($"Najwyższa ocena: {statistics1.Max}");
Console.WriteLine($"Ocena: {statistics1.AverageLetter}");