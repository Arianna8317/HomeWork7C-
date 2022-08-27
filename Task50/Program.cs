int[,] FillArray(int N, int M)
{
    int[,] Array = new int[N, M];
    Random rnd = new Random();
    for (int i = 0; i < N; i++)
        for (int j = 0; j < M; j++)
            Array[i, j] = rnd.Next(-100, 101);
    return Array;
}

//печать массива
void PrintArray(int[,] Array)
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

(bool IfExist, int i, int j) ElementIJReturn(int[,] Array, int Element)
{
    int ii=-1, jj=-1;
    bool IfExist = false;
    for (int i = 0; i < Array.GetLength(0) && !IfExist; i++)
    {
        for ( int j = 0; j < Array.GetLength(1); j++)
        {
            if (Array[i,j]==Element)
            { 
                IfExist=true;
                ii =i;
                jj =j;
                break;
            }          

        }
        
    }
    return (IfExist: IfExist, i: ii, j: jj);
}

System.Console.Write(" N = ");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.Write(" M = ");
int M = Convert.ToInt32(Console.ReadLine());

int[,] Arr = FillArray(N, M);
PrintArray(Arr);
System.Console.Write(" Element = ");
int Element = Convert.ToInt32(Console.ReadLine());
var (Exist, i, j) = ElementIJReturn(Arr, Element);
if (Exist)
   System.Console.WriteLine($"позиция ({i},{j})");
else 
   System.Console.WriteLine("Такого элемента нет");   
