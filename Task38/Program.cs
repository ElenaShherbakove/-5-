// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
double[] FillArrayWithRandomNumbers(int length)
{
    double[] arr = new double [length];
    Random rnd = new Random();
    for(int i =0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(new Random().NextDouble() + new Random().Next(0,100), 2);
    }
    return arr;
} 

System.Console.WriteLine("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
double[] array = FillArrayWithRandomNumbers(length);
System.Console.WriteLine($"[ {string.Join("; ", array)} ]");

double min = array[0];
double max = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
        {
            max = array[i];
        }
    if (array[i] < min)
        {
            min = array[i];
        }
}

Console.WriteLine($"Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");
