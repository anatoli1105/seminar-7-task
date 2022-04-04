//Задача 2: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает
 //значение этого элемента или же указание, что такого элемента нет.

int [,] MayArray(int row, int column)
{
    int[,] array = new int[row, column];
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
    string strrow = Console.ReadLine();
    int row =int.Parse(strrow);
Console.Write("введите индекс горизонтали >  ");
    string strcolumn = Console.ReadLine();
    int column =int.Parse(strcolumn);
void NamberArray(int[,]array,int row,int column)
{
  row -=1;
  column -=1;
    if(array.GetLength(0) <= row)
     Console.Write($" позиции  нет ");
     if(array.GetLength(0) <= column)
     Console.Write($" позиции  нет ");
     else Console.Write($"на позиции {row+1},{column+1} находится число {array[row,column]}");
}

    

NamberArray(array,row,column);
Console.WriteLine( ""  );
