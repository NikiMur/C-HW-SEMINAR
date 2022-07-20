
         Console.WriteLine("Введите колличество строк:");
         int rows = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Введите колличество столбцов:");
         int columns = Convert.ToInt32(Console.ReadLine());
            var matrix = new int[rows, columns];
            var rand = new Random();
 
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rand.Next(12, 45);
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
 
            var arr = matrix.Cast<int>().OrderByDescending(a => a).ToArray();
 
            int c = 0;
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    matrix[j, k] = arr[c];
                    Console.Write(matrix[j, k] + " ");
                    c++;
                }
                Console.WriteLine();
            }
          Console.ReadKey();
        