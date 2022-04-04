//Задача 2: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает
 //значение этого элемента или же указание, что такого элемента нет.

int [,] MayArray(int row, int colump)
{
    int[,] array = new int[row, colump];
    Random rnd = new Random();
    for (int i=0;i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(1);j++)
        {
            array[i,j] = rnd.Next(1,18);
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
            Console.Write($"{array[i,j]}   ");
        }
       Console.WriteLine();  
    }
        Console.WriteLine();
 }
int [,] array = MayArray(4,4);
PrintArray(array);
Console.Write("введите индекс вертикали > ");
    string strA = Console.ReadLine();
    int A =int.Parse(strA);
Console.Write("введите индекс горизонтали >  ");
    string strN = Console.ReadLine();
    int N =int.Parse(strN);
void NamberArray(int[,]array,int A,int N)
{
  A -=1;
  N -=1;
    if(array.GetLength(0) <= A && array.GetLength(1) <= N)
     Console.Write($" позиции  нет ");
     else Console.Write($"на позиции {A+1},{N+1} находится число {array[A,N]}");
}

    

NamberArray(array,A,N);
Console.WriteLine( ""  );
