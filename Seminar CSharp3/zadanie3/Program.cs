void Zadacha3()
        {
            Console.WriteLine("Введите число:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(FindMult(number));
        }

        int FindMult(int number)
        {
            int sum = 1;
            for (int i = 1; i <= number; i++)
            {
                sum = sum * i; 
            }
             return sum;
        }
Zadacha3();