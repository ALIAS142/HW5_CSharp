// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// 1. Метод вывода массива рандомного.

int [] GetArray (int size, int minValue, int maxValue)
{
    int [] res = new int [size];
    for(int i = 0; i < size; i++)
    {
        res [i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}


// 2. Метод вычисления четных элементов.

int CountEvenNumbers (int[] EvenNumbers)
{
int count = 0;
for (int i = 0; i < EvenNumbers.Length; i++)
{
    if (EvenNumbers[i] % 2 == 0)
    {
        count++;   
    }
}
return count;
}


int[] EvenNumbers = GetArray(5, 100, 999);
System.Console.WriteLine(String.Join(" ", EvenNumbers));
System.Console.WriteLine($"{CountEvenNumbers(EvenNumbers)}");
           



