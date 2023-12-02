// Zadanie zrobione pod Ewę, lat 33, ale zadziała dla wszystkich komunikatów z zadania.
var Name = "Marek";
var Age = 20;
var Sex = "mężczyzna";

if (Sex == "kobieta")
{
    if (Name == "Ewa")
    {
        Console.WriteLine("Ewa");
    }
    else
    {
        Console.WriteLine("kobieta");
    }
}
else
{
    Console.WriteLine("mężczyzna");
}
if (Age < 18)
{
    Console.WriteLine("niepełnoletni/a");
}
else if (Age >= 18 && Age < 30)
{
    Console.WriteLine("pełnoletni/a, przed 30-stką");
}
else if (Age >= 30)
{
    if (Age == 33)
    {
        Console.WriteLine("lat 33");
    }
    else
    {
        Console.WriteLine("po 30-stce");
    }
}

