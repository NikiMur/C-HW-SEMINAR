Console.WriteLine("Введите координаты X: ");
int X1 = Convert.ToInt32(Console.ReadLine());
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Y: ");
int X2 = Convert.ToInt32(Console.ReadLine());
int Y2 = Convert.ToInt32(Console.ReadLine());
double Length = 0;
Length = Math.Sqrt(Math.Pow(X2-X1,2)+Math.Pow(Y2-Y1,2));
Console.WriteLine("расстояние ");
Console.WriteLine(Length);

