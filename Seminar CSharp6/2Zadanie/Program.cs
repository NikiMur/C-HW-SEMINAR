void Zadacha48()
{
    Console.WriteLine("Введите колличество строк:");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите колличество столбцов:");
    int columns = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];
    FillArray(array, rows, columns);
    PrintArray(array, rows, columns);
}

void FillArray(int[,] array, int rows, int columns)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = i + j;
        }
    }
}

void PrintArray(int[,] array, int rows, int columns)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    
}

Zadacha48();
