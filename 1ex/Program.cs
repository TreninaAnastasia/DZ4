// Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Prompt (string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}
int A = Prompt ("Введите первое число");
int B = Prompt ("Введите второе число");
int FindProduct (int a, int b)
{
    int rez = a;
        for ( int i = 1; i < b; i ++)
        {
        rez *= b;
        }
    return rez;
}
int result = FindProduct(A,B);
Console.WriteLine($" {A}, {B} -> {result}");