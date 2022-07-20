
        Console.WriteLine("Введите количество строк");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов");
        int coloumns = Convert.ToInt32(Console.ReadLine());
         
        double[,] DoubleArray = new  double[rows,coloumns];
        
        CreateDoubleArray(DoubleArray, 10);
        PrintDoubleArray(DoubleArray); 
        

         double[,] CreateDoubleArray( double[,] arr, int finishNumber)
        {
            Random rand = new Random();
            int m =  arr.GetLength(0);
            int n =  arr.GetLength(1);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i,j] = Math.Round(rand.NextDouble()  * finishNumber, 1);
                }
            }
            return arr;
        }

          double[,] PrintDoubleArray( double[,] arr)
        {
            int m =  arr.GetLength(0);
            int n =  arr.GetLength(1);
            
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                   Console.Write($"{arr[i,j]} ");
                }
                Console.WriteLine();
            }
            return arr;
        }