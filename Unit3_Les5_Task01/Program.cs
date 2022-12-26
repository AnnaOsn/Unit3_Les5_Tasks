// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

void ArrayPrint (int[] X)
{
Console.Write("[");
for (int i=0; i<X.Length-1; i++) Console.Write($"{X[i]}, ");
Console.WriteLine($"{X[X.Length-1]}]");
}
int[] Array =new int[10];
int count = 0;

for (int i=0; i<Array.Length; i++) Array[i] = new Random().Next(100,1000);
ArrayPrint(Array);


for (int i=0; i<Array.Length; i++)
{
    if (i % 2==1) 
    {count +=1;
    }

}
 Console.WriteLine("Четные элементы :" + count);