using ChallengeAPP;

Emploee emploee1 = new Emploee("Paweł", "Kowalski", "33 lata");
Emploee emploee2 = new Emploee("Marek", "Nowak", "25 lat");
Emploee emploee3 = new Emploee("Daniel", "Brzęczyszczykiewicz", "40 lat");

emploee1.AddScore(7);
emploee2.AddScore(2);
emploee3.AddScore(6);

emploee1.AddScore(8);
emploee2.AddScore(4);
emploee3.AddScore(5);

emploee1.AddScore(5);
emploee2.AddScore(9);
emploee3.AddScore(1);

emploee1.AddScore(2);
emploee2.AddScore(1);
emploee3.AddScore(7);

emploee1.AddScore(8);
emploee2.AddScore(6);
emploee3.AddScore(4);

emploee1.AddScore(4);
emploee2.AddScore(3);
emploee3.AddScore(5);

List<Emploee> emploees = new List<Emploee>()
{
    emploee1, emploee2, emploee3
};

int maxTotal = 0;
Emploee emploeeOfTheMonth = null;

foreach (var emploee in emploees)
{
    if (emploee.Total > maxTotal)
    {
        emploeeOfTheMonth = emploee;
        maxTotal = emploee.Total;
    }
}

Console.WriteLine(emploeeOfTheMonth.Name + " " + emploeeOfTheMonth.Surname + " " + emploeeOfTheMonth.Age + " - " + maxTotal + " pkt.");

var result1 = emploee1.Total;
var result2 = emploee2.Total;
var result3 = emploee3.Total;
Console.WriteLine(result1);
Console.WriteLine(result2);
Console.WriteLine(result3);