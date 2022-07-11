int size = 8;
int [] array = new int [size];
Random random = new Random();

for (int i = 0; i < array.Length; i++)
{
    array [i] = random.Next (-10,11);
}

Console.WriteLine();
Console.WriteLine("Вывод массива:" );
for (int i = 0; i <array.Length; i++)
{
 Console.Write(array[i]+ "\t");    
}
Console.WriteLine();
for (int i = array.Length -1 ; i > 0; i--)
{
    for (int j = 0; j < i; j++)
    {
        if (Math.Abs(array[j]) >Math.Abs(array [j + 1]))
        {
           int temp = array [j];
           array[j] = array[j + 1];
           array[j + 1] = temp;
        }
    }

} 
Console.WriteLine();
Console.WriteLine("Вывод массива:" );