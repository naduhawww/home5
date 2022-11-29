
/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

// Console.WriteLine(" введите размер массива...");
// int size = Convert.ToInt32(Console.ReadLine());
// int [] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine();
// PrintArray(numbers);
// int count = 0;
// for( int i = 0; i< numbers.Length; i++){
//  if(numbers[i]%2==0){
//  count++;
//  Console.WriteLine($" четное число, {count}");}

// }

// void FillArrayRandomNumbers(int[] numbers){
//  for( int i = 0; i< numbers.Length; i++){
//  numbers[i] = new Random().Next(100,1000);
//     }
// }
// void PrintArray(int[] numbers){

//  for(int i=0; i<numbers.Length; i++){
//  Console.WriteLine(numbers[i]+ ",");
//     }

//  Console.WriteLine();
// }

Console.WriteLine("Задайте массив трёхзначных чисел.");
Console.WriteLine();

void FillAray (int [] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next (100,999);
        Console.Write(arr [i] + " "); 
    }
}

int[] array = new int[8];
FillAray(array);
int length = array.Length;
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0) 
    count++;
}
Console.WriteLine(" ");
Console.WriteLine("Количество четных значений: " + count);