Console.WriteLine("Какой длины будет массив?");
int length = Convert.ToInt32(Console.ReadLine());
double[] array = new double[length];
Console.WriteLine("Укажите до какого числа будет разброс");
double finish = Convert.ToInt32(Console.ReadLine());
CreateArray2(array, finish);
PrintArray2(array);
Console.WriteLine();
double max = MaxElement(array);
double min = MinElement(array);
Console.WriteLine("{0,1:N2} Большее", max);
Console.WriteLine("{0,1:N2} Меньшее", min);
Console.WriteLine("Разница между минимальным и максимальным элементом - "+ "{0,1:N2}", max - min);
            

            double[] CreateArray2(double[] array, double finishNumber)
            {
                Random rand = new Random();
                for(int i = 0 ; i < array.Length; i++)
                {
                    array[i] = rand.NextDouble()*finishNumber;
                }
                return array;
            }

            double[] PrintArray2(double[] array)
            {
                for(int i = 0 ; i < array.Length; i++)
                {
                  Console.Write("{0,8:N2}", array[i]);
                }
                return array;
            }

            double MaxElement(double[] array)
            {
                double max = array[0];
                for(int i = 0 ; i < array.Length; i++)
                {
                    if(array[i] >max)
                    {
                      max = array[i];
                    }
                }
                return max;
            }
            double MinElement(double[] array)
            {
                double min = array[0];
                for(int i = 0 ; i < array.Length; i++)
                {
                    if(array[i] <min)
                    {
                        min = array[i];
                    }

                }
                return min;
            }
    
