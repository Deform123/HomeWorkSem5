// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();

Console.WriteLine("Введите воличество чисел в массиве : ");
int n = Convert.ToInt32(Console.ReadLine());

int [] array = new int [n];
int sum = 0;
int i = 1;

while (i < array.Length)
    {
        array[i] = new Random().Next(0, 10);
        Console.Write($"{array [i] + " "}");
        
        if (i % 2 != 0)
            {
                sum = sum + array[i];
                i++;
            }
        else i++;
    }
Console.WriteLine();
Console.WriteLine($"Сумма элементов массива с нечетным индексом равна {sum}.");