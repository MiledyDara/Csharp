// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int ReadInt(string msg)
{
    Console.Write(msg);
    int result=Convert.ToInt32(Console.ReadLine());
    return result;
}

int M=ReadInt("Введите число M: ");
int N=ReadInt("Введите число N: ");

int CalcSumm (int M, int N)
{
    if (M == N)
    {
        return M;
    }
    return M + CalcSumm (M + 1, N);
}

if (M > N)
{
    int temp = M;
    M = N;
    N = temp;
}

Console.WriteLine(CalcSumm (M, N));