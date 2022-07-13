Console.WriteLine("Введите колличество чисел");
int Lenght = Convert.ToInt32(Console.ReadLine());
int [] array = new int [Lenght];
  Random rand = new Random();

int [] CreateMasive (int []array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i]=rand.Next(100,999);
    }
    return array;
}
 void PrintMassiv(int[] array2)
 {
    for (int i = 0; i < array2.Length; i++)
    {
        Console.Write(array2[i]+ " ");
    }
 }

 void EvenMassive(int [] array3)
 {
    int b = 0;
    for (int i = 0; i < array3.Length; i++)
    {
        if (array3[i] % 2 == 0)
        {
            b=b+1;
        }
    }
    Console.WriteLine(b);
 }
 Console.WriteLine(" ");
 CreateMasive(array);
 PrintMassiv(array);
 EvenMassive(array);
