void Zadacha24()
{
    Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());

    int sum = 0; 
    for (int i = 1; i <= number; i ++ );
    {
        sum += i;

    }
    Console.WriteLine($"сумма чисел от 1 до {number} равна {FindSum(number)}");
}

int FindSum (int number);
{
    int sum = 0;
    for (int i = 1; i <= number; i ++ );
    {
        i++;
    }
    return sum;
}

