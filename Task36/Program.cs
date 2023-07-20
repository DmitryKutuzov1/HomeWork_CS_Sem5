// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int SumOdd(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
        sum = sum + array[i];
    return sum;
}

void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
        collection[i] = new Random().Next(-100, 100);
    Console.WriteLine($"Массив - [{String.Join(", ", collection)}]");
}

Console.Write("Введите колличество элементов в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
FillArray(array);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна: {SumOdd(array)}");