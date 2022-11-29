// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] array = new double[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().NextDouble() + new Random().Next(1, 100);
}
Console.WriteLine($"{String.Join(", ", array)}");

int j = 0;
double min = array[j];
double max = array[j];
while (j < array.Length)
{
    if (array[j] < min) min = array[j];
    if (array[j] > max) max = array[j];
    j++;
}
Console.WriteLine($"Разница между максимальным и минимальным числами - {max - min}");
