/* Задача 63. Задайте значение M и N. Написать программу,
который выведет все натуральные число от M до N. */

Console.Write("Enter the M= ");
int.TryParse(Console.ReadLine()!, out int M);
Console.Write("Enter the N= ");
int.TryParse(Console.ReadLine()!, out int N);

void ShowNumbers(int m, int n)
{
    if(m == n) Console.Write($"{m}");
    else {Console.Write($"{m} "); ShowNumbers(m+1, n); }

}
Console.Write("-> ");
ShowNumbers(M, N);
