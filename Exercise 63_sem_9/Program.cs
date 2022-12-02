/* Задача 63. Задайте значение N. Написать программу,который выведет все натуральные число от 1 до N. */

Console.Write("Enter the N= ");
int.TryParse(Console.ReadLine()!, out int N);

/*int Numbers(int n, int k=1)
{
    if( k == n) return n;
    else Console.Write(k); return Numbers(n, k+1);
}

Console.Write(Numbers(N)); */

/* void Numbers(int n, int k=1)
{
    if(k == n) {Console.Write(k); }
    else {Console.Write(k);
    Numbers(n, k+1); }
}
Numbers(N); */

string Numbers(int n, int k=1)
{
    if(k==n) {return $"{k}"; }
    else return $"{k} {Numbers(n, k+1)}";
}
Console.Write(Numbers(N)); */

