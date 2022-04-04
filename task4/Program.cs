//Задача 3: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4

//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int [,] MayArray(int row, int colump)
{
    int[,] array = new int[row, colump];
    Random rnd = new Random();
    for (int i=0;i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(1);j++)
        {
            array[i,j] = rnd.Next(0,10);
        }
    }


    return array;
}
void PrintArray(int[,]array)
{
    for (int i=0;i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(1);j++)
        {
            Console.Write($"{array[i,j]}   \t");
        }
        Console.WriteLine();
    }

}
int ResulttArray(int[,]array)
{
int sum = 0;

for (int i=0;i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(1);j+=4)
        {
             sum += array[i,j];
        }
    }
    return sum;
}

int ResulttArray2(int[,]array)
{
int sum = 0;

for (int i=0;i<array.GetLength(0);i++)
    {
        for (int j=1;j<array.GetLength(1);j+=4)
        {
             sum += array[i,j];
        }
    }
    return sum;
}
int ResulttArray3(int[,]array)
{
int sum = 0;

for (int i=0;i<array.GetLength(0);i++)
    {
        for (int j=2;j<array.GetLength(1);j+=4)
        {
             sum += array[i,j];
        }
    }
    return sum;
}

int ResulttArray4(int[,]array)
{
int sum = 0;

for (int i=0;i<array.GetLength(0);i++)
    {
        for (int j=3;j<array.GetLength(1);j+=4)
        {
             sum += array[i,j];
        }
    }
    return sum;
}

int [,] array = MayArray(4,4);
PrintArray(array);
double Sum = ResulttArray(array);
double Sum2 = ResulttArray2(array);
double Sum3 = ResulttArray3(array);
double Sum4 = ResulttArray4(array);
Console.WriteLine($"\n{Sum/4}\t{Sum2/4}\t{Sum3/4}\t{Sum4/4}");