 Zadacha41();
        void Zadacha41()
        {
            Console.WriteLine("Введите скольцо будет цифр");
            int numb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите числа");
            int num;
            int count = 0;
            string num1 = "";
            while (numb>0)
            { 
             num = Convert.ToInt32(Console.ReadLine());
             num1 = num1 + num + " ";
                if (num > 0)
                {
                    count++;
                }
                numb--; 
            }
            Console.WriteLine($"Выведенные числа  {num1}");
            Console.WriteLine($"Колличество больше нуля  {count}");   
        }


