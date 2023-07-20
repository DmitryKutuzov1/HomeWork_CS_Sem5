// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double FindMaxOrMin(double[] array, bool maximum)
{
    double extremum = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (maximum)
        {
            if (array[i] > extremum) extremum = array[i];
        }
        else
        {
            if (array[i] < extremum) extremum = array[i];
        }
    }
    return extremum;
}

void FillArray(double[] collection)
{
    for (int i = 0; i < collection.Length; i++)
        collection[i] = new Random().Next(-10, 10) + Math.Round(new Random().NextDouble(), 2);
    Console.WriteLine($"Массив - [{String.Join("  ", collection)}]");
}

Console.Write("Введите колличество элементов в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
FillArray(array);
Console.WriteLine($"Максимальный элемент: {FindMaxOrMin(array, true)}");
Console.WriteLine($"Минимальный элемент:  {FindMaxOrMin(array, false)}");
Console.WriteLine("Разность между максимальным и минимальным элементами: " + (FindMaxOrMin(array, true) - FindMaxOrMin(array, false)));