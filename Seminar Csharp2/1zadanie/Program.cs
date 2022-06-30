Console.WriteLine("Введите первое число");
int X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int Y = Convert.ToInt32(Console.ReadLine());

if (X > 0 && Y > 0)
{
    Console.WriteLine("Первая четвердь");
}
else if (X < 0 && Y > 0)
{
    Console.WriteLine("Вторая четвердь");
}
else if (X < 0 && Y < 0)
{
    Console.WriteLine("Третья четвердь");
}
else if (X > 0 && Y < 0)
{
    Console.WriteLine("Четвертая четверть");
}
