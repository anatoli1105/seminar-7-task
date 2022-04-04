// Задайте двумерный массив. Введите элемент, и найдите первое его вхождение,
 //выведите позиции по горизонтали и вертикали, или напишите, что такого элемента нет.
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
Console.Write("введите число->  ");
    string strN = Console.ReadLine();
    int N =int.Parse(strN);
void NamberArray(int[,]array,int N)
{
  for (int i=0;i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(1);j++)
        {
            if(N == array[i,j]) 
            {
                Console.Write($"число {N} нахожится на позиции {i+1} по вертикали и {j+1} по горизонтали");
             return;
            }
        }
    } 
   Console.WriteLine("такого числа  нет");
 }
NamberArray(array,N);
Console.WriteLine( ""  );
