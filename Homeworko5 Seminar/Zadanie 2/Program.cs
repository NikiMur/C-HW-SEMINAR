 
Console.WriteLine("Какой длины будет массив?");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];
Console.WriteLine("Укажите диапазон разброса чисел");
int start = Convert.ToInt32(Console.ReadLine());
int finish = Convert.ToInt32(Console.ReadLine());
CreateArray1(array, start, finish);
PrintArray1(array);
 Console.WriteLine();
int sum = SumIndexEven(array);
   Console.WriteLine($"Сумма элементов стоящих на нечетных позициях - {sum}");
            

            int[] CreateArray1(int[] arr, int startNumber, int finishNumber)
            {
            Random rand = new Random();
            for(int i = 0 ; i < arr.Length; i++)
                {
                     arr[i] = rand.Next(startNumber,finishNumber);
                }
            return arr;
            }

            int[] PrintArray1(int[] arr)
            {
                for(int i = 0 ; i < arr.Length; i++)
                    {
                        Console.Write(arr[i] + " ");
                    }
            return arr;
            }

            int SumIndexEven(int[] arr)
            {
                int sum = 0;
                for(int i = 0 ; i < arr.Length; i++)
                    {
                        if(i % 2 != 0)
                        {
                          sum+=arr[i];
                        }
                    }
                return sum;
            }