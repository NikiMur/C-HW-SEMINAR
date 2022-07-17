﻿int rows = 4;
int columnes = 5;
int[,] array = new int[rows, columnes];
Random rand = new Random();
FillArray(array);
PrintArray(array);

void FillArray(int[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columnes; j++)
        {
            array[i, j] = rand.Next(0, 9);
            if ((i%2==0) && (j%2==0))
            {
              array[i, j] *= array[i,j]; 
            }
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columnes; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
