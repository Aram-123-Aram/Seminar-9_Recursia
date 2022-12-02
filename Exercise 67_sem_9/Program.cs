/* Задача 67. Напишите программу,который на вход будет принимать число,
и возвращать сумму его цифр. */

Console.Write("Enter the number n= ");
int.TryParse(Console.ReadLine()!, out int n);

/* int SumNumbers(int m, int sum = 0)
{
    if(m/10 == 0) {return sum = sum + m%10;}
    else {return SumNumbers(m/10, sum = sum + m%10); }
}
Console.Write(SumNumbers(n)); */

void SumNumbers(int m, int sum = 0)
{
    if(m/10 == 0) {Console.Write(sum=sum+m%10); }
    else SumNumbers(m/10, sum = sum +m%10);
}
SumNumbers(n);
