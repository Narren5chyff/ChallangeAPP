int number = 21165351;
string numberInString = number.ToString();
char[] digits = numberInString.ToArray();

int digit0 = 0;
int digit1 = 0;
int digit2 = 0;
int digit3 = 0;
int digit4 = 0;
int digit5 = 0;
int digit6 = 0;
int digit7 = 0;
int digit8 = 0;
int digit9 = 0;

foreach (char digit in digits)
{
    if (digit == '0')
    {
        digit0++;
    }
    else if (digit == '1')
    {
        digit1++;
    }
    else if (digit == '2')
    {
        digit2++;
    }
    else if (digit == '3')
    {
        digit3++;
    }
    else if (digit == '4')
    {
        digit4++;
    }
    else if (digit == '5')
    {
        digit5++;
    }
    else if (digit == '6')
    {
        digit6++;
    }
    else if (digit == '7')
    {
        digit7++;
    }
    else if (digit == '8')
    {
        digit8++;
    }
    else if (digit == '9')
    {
        digit9++;
    }
}
Console.WriteLine("Dla liczby " + number);
Console.WriteLine("Cyfra 0 występuje " + digit0 + " raz/y");
Console.WriteLine("Cyfra 1 występuje " + digit1 + " raz/y");
Console.WriteLine("Cyfra 2 występuje " + digit2 + " raz/y");
Console.WriteLine("Cyfra 3 występuje " + digit3 + " raz/y");
Console.WriteLine("Cyfra 4 występuje " + digit4 + " raz/y");
Console.WriteLine("Cyfra 5 występuje " + digit5 + " raz/y");
Console.WriteLine("Cyfra 6 występuje " + digit6 + " raz/y");
Console.WriteLine("Cyfra 7 występuje " + digit7 + " raz/y");
Console.WriteLine("Cyfra 8 występuje " + digit8 + " raz/y");
Console.WriteLine("Cyfra 9 występuje " + digit9 + " raz/y");