// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int CountEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0) count++;
    return count; 
}

void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
        collection[i] = new Random().Next(100, 1000);
    Console.WriteLine($"Массив - [{String.Join(", ", collection)}]");
}

Console.Write("Введите колличество элементов в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
FillArray(array);
Console.WriteLine($"Колличество четных чисел равно: {CountEven(array)}");