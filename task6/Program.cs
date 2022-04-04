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
            Console.Write($"{array[i,j]}   ");
        }
        Console.WriteLine();
    }

}
void ResulttArray(int[,]array)
{
double sum = 0;
double sum2 = 0;
double sum3 = 0;
double sum4 = 0;
for (int i=0;i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(1);j+=4)
        {
             sum += array[i,j];
        }
        for (int j=1;j<array.GetLength(1);j+=4)
        {
            sum2 += array[i,j]; 
        }
        for (int j=2;j<array.GetLength(1);j+=4)
        {
            sum3 += array[i,j];
        }
        for (int j=3;j<array.GetLength(1);j+=4)
        {
           sum4 += array[i,j];
        }
        
    }
    Console.WriteLine($"\n{sum} ,{sum2},{sum3},{sum4}");
    Console.WriteLine($"\n{sum/4}|{sum2/4}|{sum3/4}|{sum4/4}");
}
int [,] array = MayArray(4,4);
PrintArray(array);
ResulttArray(array);


