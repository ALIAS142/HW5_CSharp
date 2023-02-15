// Задача 2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19  ; [-4, -6, 89, 6] -> 0

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


// Метод нахождения элементов на нечетных позициях.

int GetOddPosition (int[] NewArray)
{
int count = 0;

for (int i = 1; i < NewArray.Length; i+=2 )
{
count = count + NewArray [i];
}
return count;
}

int [] NewArray = GetArray (5, -5, 5);

Console.WriteLine(String.Join(" ", NewArray));

Console.WriteLine($"{GetOddPosition(NewArray)}");
