//Задача 1: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
double [,] MayArray(int row, int column)
{

double[,] array = new double[row, column];
Random rnd = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = rnd.NextDouble() * 100; 
    }
}
return array;
}
void PrintArray(double[,]array)
{
    for (int i=0;i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(1);j++)
        {
            Console.Write("{0,6:F2}",array[i,j]);
            Console.Write("\t");
        }
        Console.WriteLine("\n");
    }

}

double [,] array = MayArray(4,4);
PrintArray(array);