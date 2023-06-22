//  Напишите программу, которая принимает на
//  вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Prompt (string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}
int number = Prompt("Введите число: ");

int FindSum(int n)
{
    int t = n;
    int rez = 0;
    for (int i = 0; i < number; i ++)
        {
            t = n % 10;
            rez += t;
            n /= 10;
        }
    return rez;
}
int result = FindSum(number);
Console.WriteLine ($"{number} -> {result}");