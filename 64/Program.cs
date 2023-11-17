// Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"


int ReadInt(string msg)
{
    Console.Write(msg);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
    int M = ReadInt("Введите число M: ");
    int N = ReadInt("Введите число N: ");
    

{
void printNumbers(int M, int N)
{
    
    if (M > N)
    {
        return;
    }
    if (M % 2 == 0)
    {
        System.Console.Write($"{M} \t");
    }
    printNumbers(M+1, N);
}
    printNumbers (M, N);
}


