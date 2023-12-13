using ChallengeAPP;

var emploee = new Emploee("Jan", "Kowalski");
emploee.AddGrade("500");
emploee.AddGrade("Adam");
emploee.AddGrade(9.5);
emploee.AddGrade(14);
emploee.AddGrade(29.69);
emploee.AddGrade(97);
var statistics = emploee.GetStatistics();
Console.WriteLine($"Średnia ocena: {statistics.Average:N2}");
Console.WriteLine($"Najniższa ocena: {statistics.Min}");
Console.WriteLine($"Najwyższa ocena: {statistics.Max}");