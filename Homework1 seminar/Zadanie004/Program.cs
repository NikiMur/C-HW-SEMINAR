int NumberA =Convert.ToInt32(Console.ReadLine());
int count = 1;
void EvenNumbers( int N)
        {
           while (count <= N)
           {
            if(count%2 == 0)
            { 
                Console.Write(count + " ");
            }   
             count++;
           }

        }

       EvenNumbers(NumberA);
