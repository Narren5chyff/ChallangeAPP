// Zadanie zrobione pod Ewę, lat 33, ale zadziała dla wszystkich komunikatów z zadania.
var name = "Marek";
var age = 20;
var sex = "mężczyzna";

if (sex == "kobieta")
{
    if (name == "Ewa")
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
if (age < 18)
{
    Console.WriteLine("niepełnoletni/a");
}
else if (age >= 18 && age < 30)
{
    Console.WriteLine("pełnoletni/a, przed 30-stką");
}
else if (age >= 30)
{
    if (age == 33)
    {
        Console.WriteLine("lat 33");
    }
    else
    {
        Console.WriteLine("po 30-stce");
    }
}