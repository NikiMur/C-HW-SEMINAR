
Console.Write("Введите число строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите min число: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите max число: ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] myArray = CreateRandomTwoDimArray(rows, columns, min, max);


int[,] CreateRandomTwoDimArray(int a, int b, int min, int max)
{
    int[,] newMatrix = new int[a, b];

    for (int i = 0; i < a; i++)
        for (int j = 0; j < b; j++)
            newMatrix[i, j] = new Random().Next(min, max + 1);

    return newMatrix;
}

double[] GetColumnsArithmeticMean(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    
    double [] newArray = new double[columns];

    for (int j = 0; j < columns; j++)
    {
        double arithmeticMean = 0;
        
        for (int i = 0; i < rows; i++)
        {
            
            arithmeticMean += array [i,j];
        }
        newArray [j] = Math.Round(arithmeticMean / rows,2);
    }

    return newArray;
}

void PrintTwoDimArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintArray(double [] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + "  ");
       
}


Console.WriteLine();
Console.WriteLine("Сгенерированный массив:");

PrintTwoDimArray(myArray);

double [] myArray2 = GetColumnsArithmeticMean(myArray);

Console.Write("Среднее арифметическое каждого столбца: ");

PrintArray(myArray2);