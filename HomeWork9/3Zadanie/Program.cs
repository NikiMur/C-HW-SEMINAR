
        
            Console.WriteLine("Введите число- М:");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число- N:");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(AkkermanFunc(M,N));
        
        int AkkermanFunc(int m, int n)
        {
            if(m == 0)
            {
              
                return n+1;
            }
            else if(n==0)
            {
                
                return AkkermanFunc(m-1,1);
            }
            else 
            {
                
                return AkkermanFunc(m-1,AkkermanFunc(m,n-1));
            }
        }