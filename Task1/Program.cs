// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();

Console.WriteLine("Введите воличество чисел в массиве : ");
int n = Convert.ToInt32(Console.ReadLine());

int [] array = new int [n];
int result = 0;
for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        Console.Write($"{array [i] + " "}");
        if (array[i] % 2 == 0)
            result = result + 1;
        
    }
 Console.WriteLine();
 Console.WriteLine($"Количество четных элементов в массиве равно {result}.");

