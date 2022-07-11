Console.WriteLine("введите число");
int Number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите степень");
int NumberB = Convert.ToInt32(Console.ReadLine());

int i (int a, int b)
{
    int exp = 1;
    while (b > 0)
    {
        exp = exp*a;
        b--;

    }
return exp;
}
Console.WriteLine(i (Number, NumberB));