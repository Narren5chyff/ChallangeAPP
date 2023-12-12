using ChallengeAPP;

var emploee = new Emploee("Jan", "Kowalski");
emploee.AddGrade(5);
emploee.AddGrade(15);
emploee.AddGrade(9);
var statistics = emploee.GetStatistics();
Console.WriteLine($"średnia: {statistics.Average:N2}");
Console.WriteLine($"min: {statistics.Min}");
Console.WriteLine($"max: {statistics.Max}");