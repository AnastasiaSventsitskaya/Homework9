// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// функция ack(n, m)
//    пока n ≠ 0
//      если m = 0
//        m:= 1
//      иначе
//        m:= ack(n, m - 1)
//      n:= n - 1
//    вернуть m + 1


long Acker(long n, long m)
{
    while (n != 0)
    {
        if (m == 0)
            m = 1;
        else
            m = Acker(n, m - 1);
     
        n = n - 1;
    }
    return m + 1;
}
long res = Acker(2,2);
Console.WriteLine(res);