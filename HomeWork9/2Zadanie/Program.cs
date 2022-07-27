Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = CountDigits(n);

int CountDigits(int num)
{
    
    if (num/10>0)
        return CountDigits(num/10)+1;
        
    return 1;
}




Console.WriteLine($"Количество цифр в числе {n} равно {result}");
