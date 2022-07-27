Zadacha64();
        void Zadacha64()
        {
            Console.WriteLine("Введите чилло- М:");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число- N:");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Числа из промежутка от {M} до {N}: ");
            AllNumbers(M, N);
            Console.WriteLine();

        }

        void AllNumbers(int m, int n)
        {
            if (m > n)
            {
                return;
            }
            if (m % 3 == 0)
            {
                Console.Write(m + "\t");

            }
            m++;
            AllNumbers(m, n);
        }    