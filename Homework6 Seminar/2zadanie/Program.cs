Zadacha43();
void Zadacha43()
{
Console.WriteLine("Введите b1:");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k1:");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2:");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k2:");
double k2 = Convert.ToInt32(Console.ReadLine());

CrossDot(b1,k1,b2,k2);

}
void CrossDot(double b1, double k1, double b2, double k2 )
{
double y;
double x;



x = (b2 - b1)/(k1 - k2);
y = (k1*x) + b1;



Console.WriteLine(y);
Console.WriteLine(x);
}