// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


Console.Write("Введите размер массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.Write("Массив: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int A = 0; A < numbers.Length; A++)
{
    if (numbers[A] > max)
        {
            max = numbers[A];
        }
    if (numbers[A] < min)
        {
            min = numbers[A];
        }
}

Console.WriteLine($"Всего {numbers.Length} чисел.");
Console.WriteLine($"Максимальное значение: {max}.");
Console.WriteLine($"Минимальное значение: {min}.");
Console.WriteLine($"Разница между максимальным и минимальным значением: {max - min}.");

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}