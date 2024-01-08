using ChallengeAPP;

Console.WriteLine("Witaj w programie oceny pracowników");
Console.WriteLine("===================================");
Console.WriteLine();
Console.WriteLine("Dodaj ocenę pracownika");

var emploee1 = new EmploeeInFile("Jan", "Kowalski", "m");
emploee1.GradeAdded += NewGradeAdded;

void NewGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę");
}
emploee1.AddGrade(13);
emploee1.AddGrade(89);

//while (true)
//{
//    var input = Console.ReadLine();
//    if (input == "q")
//    {
//        break;
//    }

//    try
//    {
//        emploee1.AddGrade(input);
//    }
//    catch (Exception EX1)
//    {
//        Console.WriteLine($"Exception: {EX1.Message}");
//    }
//}

var statistics = emploee1.GetStatisticsInForEach();
Console.WriteLine($"Średnia ocena: {statistics.Average:N2}");
Console.WriteLine($"Najniższa ocena: {statistics.Min}");
Console.WriteLine($"Najwyższa ocena: {statistics.Max}");
Console.WriteLine($"Ocena: {statistics.AverageLetter}");