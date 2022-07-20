 Console.WriteLine("Введите количество строк");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов");
        int coloumns = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите элемент");
        int Row = Convert.ToInt32(Console.ReadLine());
        int Colms = Convert.ToInt32(Console.ReadLine());
        
        int[,] DoubleArray = new  int[rows,coloumns];
        CreateIntArray(DoubleArray);
        PrintIntArray(DoubleArray); 
        ElementInArray(DoubleArray, Row,Colms);
        
        

         int[,] CreateIntArray( int[,] arr)
        {
            Random rand = new Random();
            int m =  arr.GetLength(0);
            int n =  arr.GetLength(1);
            for (int i = 0; i <m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i,j] = rand.Next(1,10);
                }
            }
            return arr;
        }

          int[,] PrintIntArray( int[,] arr)
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

        void ElementInArray(int[,] arr, int Row, int Colms)
        {
            bool flag = false;
         
            int m =  arr.GetLength(0);
            int n =  arr.GetLength(1);
            for (int i = 0; i <  m; i++)
            {
                 for (int j = 0; j <n; j++)
                {
                   if (i  == Row && j == Colms)
                   {
                    flag = true;
                    break;
                   }
                }       
            }

            if (flag == true)
            {
                Console.WriteLine($"Элемент - {arr[Row,Colms]}, есть в массиве ");
            }
            else {Console.WriteLine("Такого элемента нет в массиве");}
        }      
