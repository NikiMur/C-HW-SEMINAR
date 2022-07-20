
            Console.Write("Введите колличество строк:");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Введите колличество столбцов:");
            int coloumns = int.Parse(Console.ReadLine());
           
 
            int[,] array = new int[rows, coloumns];            
            int row = 0, col = 0, dx = 0, dy = 1, dirChanges = 0, gran = rows;
            int l =  array.Length;
            for(int i = 0; i < l; i++) 
            {
                array[row, col] = i + 1;
 
                if(--gran == 0) 
                {
                    gran = rows * (dirChanges % 2) + coloumns * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
                    int temp = dy;
                    dy = -dx;
                    dx = temp;
                    dirChanges++;
                }
 
                col += dx;
                row += dy;
            }
                        
            coloumns = array.GetLength(1);
            for(int k = 0; k < l; k++)
                Console.Write("{0}{1,3}", k % coloumns == 0 ? "\n" : "", array[k / coloumns, k % coloumns]);
 
 
            Console.ReadLine();
