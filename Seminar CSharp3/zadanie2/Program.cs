Zadacha2();
        void Zadacha2()
        {
            Console.WriteLine("Введите число:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(FindNums(number));
        }

        int FindNums(int number)
        {
            int count =  1;
            while(number/10 > 0)
            {
                count++;
                number = number/10;
            }
            return count;
        }
