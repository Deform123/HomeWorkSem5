// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();

Console.WriteLine("Введите воличество чисел в массиве : ");
int size = Convert.ToInt32(Console.ReadLine());

double [] array = GetArray(size, 0, 1000);

Console.WriteLine(String.Join(" ", array));

double maxNumber = array[0];
double minNumber = array[0];

foreach (int element in array){
    if (element > maxNumber)
        maxNumber = element;
    else if (element < minNumber)
        minNumber = element;
}

double [] GetArray(int size, int min,int max){
   double [] result = new double [size];
    for (int i =0; i < size; i++){
        result [i] = new Random().Next(min, max +1);
    }
    return result;
}
 
Console.WriteLine();
Console.WriteLine($"Разница между максимальним елементом массива ({maxNumber}) и минимальным элементом массива ({minNumber}) равна  - {maxNumber - minNumber}.");