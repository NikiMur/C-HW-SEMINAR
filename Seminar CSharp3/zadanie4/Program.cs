int size = 8;
         int[] array = new int[size];     
         FindMass(array);
         Print(array);
        

        void Print(int[] array)
        {
            Console.WriteLine("Вывод массива");
           for (int index=0; index< array.Length; index++)
           {
            Console.Write(array[index]+ " ");
           }
           Console.WriteLine();
            
            
        }
        
        void FindMass(int[] array)
        {
            
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0,2); 
            }


        }
