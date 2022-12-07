// Задайте значения M и N. Напишите программу,
//  которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Write number 1");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Write number 2");
int m = Convert.ToInt32(Console.ReadLine());

if (n < 0 || m < 0)
{
    Console.WriteLine("Введите значения больше 0");
}

Console.WriteLine(GetSum(n,m));

int GetSum(int m, int n)
{
    if (m == n)
        return m;
    
    return m + GetSum(m + 1, n);
}