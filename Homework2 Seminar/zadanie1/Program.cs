Console.WriteLine("Введите число");
string number = Console.ReadLine();
TripleNumber(number);

 void TripleNumber(string currentNumber)
{
         if (currentNumber.Length < 3)
            {
                Console.WriteLine("Третьей цифры нет");
            }
            else if (currentNumber[2] != 0)
            {
                Console.WriteLine(currentNumber[2]);
            }

            
}