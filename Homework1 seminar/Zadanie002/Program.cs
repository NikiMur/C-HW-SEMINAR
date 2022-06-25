Console.WriteLine("Введите первое число");
int NumberA =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int NumberB =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int NumberC =Convert.ToInt32(Console.ReadLine());
int Max = NumberA;

 if (Max < NumberB)
 {
   Max = NumberB;
 if (Max < NumberC )
{
    Max = NumberC;
}

    Max = NumberC;
 }

Console.WriteLine($"Максимальное число {Max}");

