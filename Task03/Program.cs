// Задача 3(38): Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// Метод для заполнения массива случайными вещественными числами

double[] RandomRealArray(int size, int minValue, int maxValue)
{
    double[] res = new double[size];
    var random = new Random();

    for (int i = 0; i < size; i++)
    {
        res[i] = Convert.ToDouble(random.Next(-100, 100) / 10.0);
    }
    return res;
}

// Метод поиска минимального элемента массива.

double GetMinElement(double[] RealArray)
{
    double Min = RealArray[0];

    for (int i = 0; i < RealArray.Length; i++)
    {
        if (RealArray[i] < Min)
            Min = RealArray[i];
    }
    return Min;
}


// Метод поиска максимального элемента массива.

double GetMaxElement(double[] RealArray)
{
    double Max = RealArray[0];

    for (int i = 0; i < RealArray.Length; i++)
    {
        if (RealArray[i] > Max)
            Max = RealArray[i];
    }
    return Max;
}

// Метод поиска разницы между между максимальным и минимальным элементов массива.

double GetDiffMaxMin(double[] RealArray)

{
    double Min = RealArray[0];
    double Max = RealArray[0];
    // double Diff = Max - Min;

    for (int i = 0; i < RealArray.Length; i++)
    {
        if (RealArray[i] < Min) Min = RealArray[i];
        if (RealArray[i] > Max) Max = RealArray[i];
    }
    double Diff = Max - Min;
    return Diff;
}


double[] RealArray = RandomRealArray(5, 0, 10);
Console.WriteLine(String.Join(" ", RealArray));
System.Console.WriteLine($"{GetMinElement(RealArray)}");
System.Console.WriteLine($"{GetMaxElement(RealArray)}");
System.Console.WriteLine($"{GetDiffMaxMin(RealArray)}");