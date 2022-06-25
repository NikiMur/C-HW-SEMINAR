Console.WriteLine("Введите первое число");
int NumberA =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int NumberB =Convert.ToInt32(Console.ReadLine());
int Max = 0;
int Min = 0;
if (NumberA > NumberB)
{
    Max = NumberA;
    Min = NumberB;
    Console.WriteLine($"Большее число  {Max}");
    Console.WriteLine($"Меньшее число  {Min}");
}
else if (NumberA==NumberB)

{
    Console.WriteLine($"Числа равны"); 
}
 
else
{
    Max =NumberB;
    Min =NumberA;
    Console.WriteLine($"Большее число  {Max}");
    Console.WriteLine($"Меньшее число  {Min}");
}   

 
   

