/*Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет количество 
чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

//Создаем массив - (99, 1000)
//Создаем переменную
//Создаем цикл 
// Делим их на 2 и остатком от него будем искать четные числа 
//Выводем результат на экран

int [] GetArray(int size, int minValue, int maxValue)
{
    int [] res = new int [size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{res[i]} ");
    }
    return res;
}

int [] array = GetArray(7, 300, 888);
Console.WriteLine();

int evenNumbers = 0;

for(int i =0; i < array.Length; i++)
{
    if(array[i] % 2 == 0)
    {
        evenNumbers++;
    }
}

Console.WriteLine($"Количество четных чисел в массиве равно {evenNumbers}");
