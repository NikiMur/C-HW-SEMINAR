Console.WriteLine("Введите номер четверти");
int nubmer = Convert.ToInt32(Console.ReadLine());


if (nubmer == 1)
{
    Console.WriteLine($" 0 < x < infinity ");
    Console.WriteLine($" 0 < y < infinity ");
}
else if (nubmer == 2)
{
     Console.WriteLine($"-infinity < x < 0 ");
     Console.WriteLine($" 0 < x < infinity ");
}
else if (nubmer==3)
{
    Console.WriteLine($" -infinity < y < 0 ");
    Console.WriteLine($" -infinity < y < 0 ");
}
else if (nubmer == 4)
{
    Console.WriteLine($" 0 < y < infinity ");
    Console.WriteLine($" -infinity < y < 0 ");
}
