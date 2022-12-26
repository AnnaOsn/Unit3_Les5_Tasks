// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] array = new int[8];
int sum = 0;
for (int i =0; i <array.Length; i++)
{
    array [i] = new Random().Next(1, 5);
    Console.Write(array[i] + ", ");
}
for (int i =0; i <array.Length; i++)
{
    if (i % 2==1)
    sum = sum + array[i];
}
Console.Write($"Сумма элементов, стоящих на нечетных позициях -> {sum}");