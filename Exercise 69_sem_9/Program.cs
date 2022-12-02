/*Задача 69. Написать программу,который на вход принимает два числв A и B и 
возводит число А в целую степень В с помощью рекурсии.
Например:
A=3, B=5 -> 243(3^5) 3*3^4 */

Console.Write("Enter the number A= ");
int.TryParse(Console.ReadLine()!, out int A);
Console.Write("Enter the number B= ");
int.TryParse(Console.ReadLine()!, out int B);

int NumberAB(int a, int b)
{
    if(b == 1) return a;
    else return a = a*NumberAB(a, b-1);
}
Console.Write(NumberAB(A, B));