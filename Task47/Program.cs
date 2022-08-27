double[,] FillArray( int N, int M )
{
    double[,] Array = new double[N,M];
    Random rnd = new Random();
    for (int i=0; i<N; i++)
       for (int j=0; j<M; j++)
            Array[i,j]=Math.Round((new Random().Next(-100, 100)) * rnd.NextDouble(),2) ;
    return Array;
}

//печать массива
void PrintArray(double[,] Array)
{
    for (int i=0; i<Array.GetLength(0); i++)
    {
        for (int j=0; j<Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i,j]} ");   
        }
        Console.WriteLine();
    }
}

System.Console.Write(" N = ");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.Write(" M = ");
int M = Convert.ToInt32(Console.ReadLine());
double[,] Arr = FillArray(N,M);
PrintArray(Arr);

