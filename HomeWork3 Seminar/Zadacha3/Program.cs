Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 1;

Console.WriteLine();
while (count<=N)
{
    Console.WriteLine(Math.Pow(count,3));
    count++;
   
}