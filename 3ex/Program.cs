//  Напишите программу, которая задаёт массив
// из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

const int ARRAYSIZE = 8;
int[] RandomArray = randomArray();
PrintArray(RandomArray);
int[] randomArray()
{
    int[] array = new int [ARRAYSIZE];
    for (int i = 0; i < ARRAYSIZE; i ++ )
    array[i] = int.Random.Next();
    return array;
}
void PrintArray(int[] array)
{
    foreach( var element in array)
    Console.WriteLine($"{element}");
}