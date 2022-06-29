Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Callendare(number);
void Callendare (int number)
{
if(number== 1) Console.WriteLine("Понедельник"); 
else if(number == 2) Console.WriteLine("Вторник"); 
else if(number == 3) Console.WriteLine("Среда"); 
else if(number == 4) Console.WriteLine("Четверг"); 
else if(number == 5) Console.WriteLine("Пятнтица"); 
else if(number == 6) Console.WriteLine("Суббота"); 
else if(number == 7) Console.WriteLine("Воскресение"); 
}
if(number==6 ||number==7 )
{
    Console.WriteLine("Выходной");
}
else
{
    Console.WriteLine("рабочий день");
}