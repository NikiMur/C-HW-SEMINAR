Console.WriteLine("Введите координаты первой точки (X): ");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты первой точки (Y): ");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты первой точки (Z): ");
int Z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки (X2): ");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки (Y2): ");
int Y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки (Z2): ");
int Z2 = Convert.ToInt32(Console.ReadLine());
double Length = 0;
Length = Math.Sqrt(Math.Pow(X2-X1,2)+Math.Pow(Y2-Y1,2)+Math.Pow(Z2-Z1,2));
Console.WriteLine("расстояние ");
Console.WriteLine(Length);

