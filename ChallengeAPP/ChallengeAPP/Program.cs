using ChallengeAPP;

var emploee = new Emploee("Jan", "Kowalski");
emploee.AddGrade("500");
emploee.AddGrade("Adam");
emploee.AddGrade(9.5);
emploee.AddGrade(14);
emploee.AddGrade(29.69);
emploee.AddGrade(97);

var statistics1 = emploee.GetStatisticsInForEach();
Console.WriteLine($"Średnia ocena: {statistics1.Average:N2}");
Console.WriteLine($"Najniższa ocena: {statistics1.Min}");
Console.WriteLine($"Najwyższa ocena: {statistics1.Max}");

var statistics2 = emploee.GetStatisticsInFor();
Console.WriteLine($"Średnia ocena: {statistics2.Average:N2}");
Console.WriteLine($"Najniższa ocena: {statistics2.Min}");
Console.WriteLine($"Najwyższa ocena: {statistics2.Max}");

var statistics3 = emploee.GetStatisticsInDoWhile();
Console.WriteLine($"Średnia ocena: {statistics3.Average:N2}");
Console.WriteLine($"Najniższa ocena: {statistics3.Min}");
Console.WriteLine($"Najwyższa ocena: {statistics3.Max}");

var statistics4 = emploee.GetStatisticsInWhile();
Console.WriteLine($"Średnia ocena: {statistics4.Average:N2}");
Console.WriteLine($"Najniższa ocena: {statistics4.Min}");
Console.WriteLine($"Najwyższa ocena: {statistics4.Max}");