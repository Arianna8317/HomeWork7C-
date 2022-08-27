int [,] FillArray(int N, int M)
{
    int[,] Array = new int[N, M];
    Random rnd = new Random();
    for (int i = 0; i < N; i++)
        for (int j = 0; j < M; j++)
            Array[i, j] = rnd.Next(100, 1001);
    return Array;
}

//печать массива
void Print2Array(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void PrintArrayDouble(double[] Array)
{
    for (int i = 0; i < Array.Length; i++)
        Console.Write($"{Math.Round(Array[i],2)} ");

    Console.WriteLine();

}

double[] AverageColumn(int[,] Array)
{
    double[] Average = new double[Array.GetLength(1)];
    for (int j = 0; j < Array.GetLength(1); j++)
    {
        for (int i = 0; i < Array.GetLength(0); i++)
        {
            Average[j] += Array[i, j];
        }
        Average[j] /= Array.GetLength(0);
    }
    return Average;
} 

System.Console.Write(" N = ");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.Write(" M = ");
int M = Convert.ToInt32(Console.ReadLine());

int[,] Arr = FillArray(N, M);
Print2Array(Arr);
System.Console.Write("Средние арифтетические столбцов : ");
PrintArrayDouble(AverageColumn(Arr));