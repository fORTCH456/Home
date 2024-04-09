using System.Linq;

internal static class ProgramHelpers
{

    //static void Main(string[] args)
    //{
    //    Random rnd = new Random();

    //    int[] nums = new int[10];

    //   for (int i = 0; i < 10; i++)

    //   {
    //       nums[i] = rnd.Next(-50, 50);

    //        Console.Write(nums[i] + " ");

    //    }
    //    Console.WriteLine("Исходный массив");

    //    int max = nums[0], s = 0;

    //    for (int i = 0; i < 10; i++)

    //    {
    //        if (max < nums[i])

    //            max = i;

    //    }
    //    s = nums[0];
    //    nums[0] = nums[max];
    //    nums[max] = s;
    //    for (int i = 0; i < 10; i++)

    //        Console.Write(nums[i] + " ");
    //}
    //    static void Main(string[] args)
    //{
    //         Random rand = new Random();

    //         int[] arr = new int[20];

    //         int countEven = 0;

    //         int countOdd = 0;

    //         for(int i=0; i<20; i++)
    //         {
    //             arr[i] = rand.Next(1, 20);

    //             if (arr[i] % 2 == 0) countEven++;

    //                 else countOdd++;

    //             Console.Write(arr[i] + " ");
    //         }
    //         Console.WriteLine();
    //         if (countEven > countOdd) Console.WriteLine("Четных элементов больше");
    //         else
    //             if (countEven < countOdd) Console.WriteLine("Нечетных элементов больше");

    //         else Console.WriteLine("Равное количество элементов");

    //         Console.ReadLine();
    //      }
    //private static void Main(string[] args)
    //{
    //    var arr = new double[15];

    //    var count = 0;

    //    var random = new Random();

    //    arr[0] = Math.Round(random.NextDouble() + random.Next(1, 10), 2);

    //    Console.Write(arr[0] + " ");

    //    for (int i = 1; i < arr.Length; i++)
    //    {
    //        arr[i] = Math.Round(random.NextDouble() + random.Next(1, 10), 2);

    //        if (arr[i] > arr[0])
    //        {
    //            count++;
    //        }
    //        Console.Write(arr[i] + " ");
    //    }
    //    Console.WriteLine();

    //    Console.WriteLine(count);

    //    Console.ReadKey();
    //}



    //    static void Main(string[] args)
    //{
    //    double[] n = new double[16];

    //    Random rand = new Random();

    //    int mini = 0;

    //    int maxi = 0;

    //    Console.WriteLine("Введены 16 элементов массива: ");

    //    for (int i = 0; i < n.Length; i++)
    //    {
    //        n[i] = rand.Next(16);

    //        Console.WriteLine(n[i] + " ");

    //    }
    //    double min = n[0];

    //    double max = n[0];

    //    for (int i = 0; i < n.Length; i++)
    //    {
    //        if (max < n[i])
    //        {
    //            max = n[i]; maxi = i;
    //        }
    //        if (min > n[i])
    //        {
    //            min = n[i]; mini = i;
    //        }
    //    }
    //    Console.WriteLine("Результат:");

    //    Console.WriteLine("Максимальный элемент = {0};{1} ", max, maxi);

    //    Console.WriteLine("Минимальный элемент = {0};{1} ", min, mini);
    //    Console.ReadKey();
    //}
    //static void Main(string[] args)

    //{
    //    int[] v = new int[15];

    //    Random rnd = new Random();

    //    int summ = 0;

    //    string? s = null;



    //    for (int i = 0; i < 15; i++)
    //    {
    //        v[i] = rnd.Next(1, 100);

    //        s = s + v[i].ToString() + " ";

    //        summ = summ + v[i];


    //    }
    //    Console.WriteLine("Начальный массив = " + s);

    //    Console.WriteLine("Среднее арифметическое = " + (summ / 15));

    //    s = null;
    //    for (int i = 0; i < 15; i++)
    //    {
    //        v[i] = v[i] - (summ / 15);

    //        s = s + v[i].ToString() + " ";
    //    }
    //    Console.WriteLine("Новый массив = " + s);

    //    Console.ReadKey();
    //}
    //static void Main(string[] args)
    //{
    //    int n = 17, sum = 0, average = 0;

    //    int[] arr = new int[n];

    //    Random rand = new Random();

    //    for (int i = 0; i < arr.Length; i++)
    //    {
    //        arr[i] = rand.Next(0, 100);

    //    }

    //    for (int i = 0; i < arr.Length; i++)
    //    {
    //        sum += arr[i];
    //    }

    //    average = sum / n;

    //    int[] newArr = new int[n];

    //    for (int i = 0; i < newArr.Length; i++)
    //    {
    //        if (i == 4)
    //        {
    //            newArr[i] = average;
    //        }
    //        else
    //        {
    //            newArr[i] = arr[i];
    //        }
    //    }

    //    Console.Write("Исходный массив: ");

    //    for (int i = 0; i < arr.Length; i++)
    //    {
    //        Console.Write(arr[i] + " ");
    //    }
    //    Console.WriteLine();

    // Console.WriteLine("Больше среднеарифметического числа: {0}", average);
    //    Console.Write("Новый массив:    ");

    //    for (int i = 0; i < newArr.Length; i++)
    //    {
    //        Console.Write(newArr[i] + " ");
    //    }
    //    Console.WriteLine();
    //}

    //static void Main()
    //{

    //    int[] numbers = new int[17];
    //    Random random = new Random();


    //    for (int i = 0; i < 17; i++)
    //    {
    //        numbers[i] = random.Next(1, 100); 
    //    }


    //    Console.WriteLine("Исходный массив целых чисел:");
    //    foreach (int num in numbers)
    //    {
    //        Console.Write(num + " ");
    //    }


    //    int sumOfOdd = 0;
    //    for (int i = 0; i < 17; i++)
    //    {
    //        if (numbers[i] % 3 == 0)
    //        {
    //            for (int j = 0; j < 17; j++)
    //            {
    //                if (numbers[j] % 2 != 0)
    //                {
    //                    sumOfOdd += numbers[j];
    //                }
    //            }
    //            numbers[i] = sumOfOdd;
    //        }
    //    }


    //    Console.WriteLine("\n\nМассив после замены элементов кратных трём на сумму нечетных элементов:");
    //    foreach (int num in numbers)
    //    {
    //        Console.Write(num + " ");
    //    }

    //    Console.ReadLine();
    //}
    //static void Main()
    //{

    //    double[] numbers = new double[12];

    //    Random random = new Random();


    //    for (int i = 0; i < 12; i++)
    //    {
    //        numbers[i] = random.NextDouble() * 100; 
    //    }


    //    double max = numbers[0];
    //    double min = numbers[0];
    //    int maxIndex = 0;
    //    int minIndex = 0;

    //    for (int i = 1; i < 12; i++)
    //    {
    //        if (numbers[i] > max)
    //        {
    //            max = numbers[i];
    //            maxIndex = i;
    //        }

    //        if (numbers[i] < min)
    //        {
    //            min = numbers[i];
    //            minIndex = i;
    //        }
    //    }


    //    int countNumbersBetween = Math.Abs(maxIndex - minIndex) - 1;


    //    Console.WriteLine("Массив действительных чисел:");
    //    foreach (double num in numbers)
    //    {
    //        Console.Write(num + " ");
    //    }

    //    Console.WriteLine($"\n\nКоличество чисел, стоящих между максимальным ({max}) и минимальным ({min}) элементами: {countNumbersBetween}");

    //    Console.ReadLine();
    //}
    //static void Main()
    //{

    //    int[] numbers = new int[15];
    //    Random random = new Random();


    //    int negativeCount = 0;
    //    int positiveProduct = 1;
    //    int zeroCount = 0;


    //    for (int i = 0; i < 15; i++)
    //    {
    //        numbers[i] = random.Next(-10, 11); 

    //        if (numbers[i] < 0)
    //        {
    //            negativeCount++;
    //        }
    //        else if (numbers[i] > 0)
    //        {
    //            positiveProduct *= numbers[i];
    //        }
    //        else
    //        {
    //            zeroCount++;
    //        }
    //    }


    //    Console.WriteLine("Массив целых чисел:");
    //    foreach (int num in numbers)
    //    {
    //        Console.Write(num + " ");
    //    }

    //    Console.WriteLine($"\n\nКоличество отрицательных элементов: {negativeCount}");
    //    Console.WriteLine($"Произведение положительных элементов: {positiveProduct}");
    //    Console.WriteLine($"Количество нулевых элементов: {zeroCount}");

    //    Console.ReadLine();
    //}
    //static void Main()
    //{

    //    double[] numbers = new double[12];
    //    Random random = new Random();


    //    double min = double.MaxValue;
    //    double max = double.MinValue;

    //    for (int i = 0; i < 12; i++)
    //    {
    //        numbers[i] = random.NextDouble() * 100 - 50; 

    //        if (numbers[i] < min)
    //        {
    //            min = numbers[i];
    //        }

    //        if (numbers[i] > max)
    //        {
    //            max = numbers[i];
    //        }
    //    }


    //    Console.WriteLine("Массив действительных чисел:");
    //    foreach (double num in numbers)
    //    {
    //        Console.Write(num + " ");
    //    }

    //    Console.WriteLine($"\n\nГраницы интервала, в котором находятся значения элементов массива: [{min}, {max}]");

    //    Console.ReadLine();
    // }
    //static void Main()
    //{

    //    int[] numbers = new int[19];
    //    Random random = new Random();


    //    int sum = 0;
    //    bool negativeFound = false;


    //    for (int i = 0; i < 19; i++)
    //    {
    //        numbers[i] = random.Next(-100, 101); 

    //        if (!negativeFound)
    //        {
    //            if (numbers[i] < 0)
    //            {
    //                negativeFound = true;
    //            }
    //            else
    //            {
    //                sum += numbers[i];
    //            }
    //        }
    //    }


    //    Console.WriteLine("Массив целых чисел:");
    //    foreach (int num in numbers)
    //    {
    //        Console.Write(num + " ");
    //    }

    //    if (negativeFound)
    //    {
    //        Console.WriteLine($"\n\nСумма элементов до первого отрицательного элемента: {sum}");
    //    }
    //    else
    //    {
    //        Console.WriteLine("\n\nВ массиве нет отрицательных элементов.");
    //    }

    //    Console.ReadLine();
    //}
    //static void Main()
    //{

    //    int[] numbers = new int[16];
    //    Random random = new Random();


    //    int replacementsCount = 0;


    //    for (int i = 0; i < 16; i++)
    //    {
    //        numbers[i] = random.Next(1, 101); 

    //        if (numbers[i] % 3 == 0)
    //        {
    //            numbers[i] = 0;
    //            replacementsCount++;
    //        }
    //    }


    //    Console.WriteLine("Массив целых чисел после замен:");
    //    foreach (int num in numbers)
    //    {
    //        Console.Write(num + " ");
    //    }

    //    Console.WriteLine($"\n\nКоличество замен: {replacementsCount}");

    //    Console.ReadLine();
    //}

    //static void Main()
    //{

    //    double[] numbers = new double[12];
    //    Random random = new Random();


    //    for (int i = 0; i < 12; i++)
    //    {
    //        numbers[i] = random.NextDouble() * 100;
    //    }


    //    double min = numbers[0];
    //    int minIndex = 0;
    //    for (int i = 1; i < 12; i++)
    //    {
    //        if (numbers[i] < min)
    //        {
    //            min = numbers[i];
    //            minIndex = i;
    //        }
    //    }


    //    numbers[minIndex] *= 3;


    //    double temp = numbers[minIndex];
    //    numbers[minIndex] = numbers[11];
    //    numbers[11] = temp;


    //    Console.WriteLine("Массив действительных чисел до изменений:");
    //    foreach (double num in numbers)
    //    {
    //        Console.Write(num + " ");
    //    }

    //    Console.WriteLine("\n\nМассив действительных чисел после увеличения минимального элемента в три раза и замены с последним:");
    //    foreach (double num in numbers)
    //    {
    //        Console.Write(num + " ");
    //    }

    //    Console.ReadLine();
    //}
    //static void Main()
    //{

    //    int[] numbers = new int[19];
    //    Random random = new Random();


    //    int sum = 0;
    //    bool negativeFound = false;


    //    for (int i = 0; i < 19; i++)
    //    {
    //        numbers[i] = random.Next(-100, 101);

    //        if (!negativeFound)
    //        {
    //            if (numbers[i] < 0)
    //            {
    //                negativeFound = true;
    //            }
    //            else
    //            {
    //                sum += numbers[i];
    //            }
    //        }
    //    }


    //    Console.WriteLine("Массив целых чисел:");
    //    foreach (int num in numbers)
    //    {
    //        Console.Write(num + " ");
    //    }

    //    if (negativeFound)
    //    {
    //        Console.WriteLine($"\n\nСумма элементов до первого отрицательного элемента: {sum}");
    //    }
    //    else
    //    {
    //        Console.WriteLine("\n\nОтрицательных элементов в массиве нет.");
    //    }

    //    Console.ReadLine();
    //}
    //class Program
    //{
    //    static void Main()
    //    {

    //        int[] numbers = new int[16];
    //        Random random = new Random();
    //        int replacementsCount = 0;


    //        for (int i = 0; i < 16; i++)
    //        {
    //            numbers[i] = random.Next(1, 101);

    //            if (numbers[i] % 3 == 0)
    //            {
    //                numbers[i] = 0;
    //                replacementsCount++;
    //            }
    //        }


    //        Console.WriteLine("Массив целых чисел после замен:");
    //        foreach (int num in numbers)
    //        {
    //            Console.Write(num + " ");
    //        }

    //        Console.WriteLine($"\n\nКоличество замен: {replacementsCount}");

    //        Console.ReadLine();
    //    }
    //}
    //static void Main()
    //{

    //    double[] numbers = new double[12];
    //    Random random = new Random();


    //    for (int i = 0; i < 12; i++)
    //    {
    //        numbers[i] = random.NextDouble() * 100; 
    //    }


    //    double min = numbers[0];
    //    int minIndex = 0;
    //    for (int i = 1; i < 12; i++)
    //    {
    //        if (numbers[i] < min)
    //        {
    //            min = numbers[i];
    //            minIndex = i;
    //        }
    //    }


    //    numbers[minIndex] *= 3;


    //    double temp = numbers[minIndex];
    //    numbers[minIndex] = numbers[11];
    //    numbers[11] = temp;


    //    Console.WriteLine("Массив действительных чисел до изменений:");
    //    foreach (double num in numbers)
    //    {
    //        Console.Write(num + " ");
    //    }

    //    Console.WriteLine("\n\nМассив действительных чисел после увеличения минимального элемента в три раза и замены с последним:");
    //    foreach (double num in numbers)
    //    {
    //        Console.Write(num + " ");
    //    }

    //    Console.ReadLine();
    //}
    //static void Main()
    //{

    //    double[] numbers = new double[15];
    //    Random random = new Random();


    //    for (int i = 0; i < 15; i++)
    //    {
    //        numbers[i] = random.NextDouble() * 100; 
    //    }


    //    Console.WriteLine("Исходный массив вещественных чисел:");
    //    foreach (double num in numbers)
    //    {
    //        Console.Write(num + " ");
    //    }


    //    Array.Reverse(numbers);


    //    Console.WriteLine("\n\nМассив вещественных чисел после переворота:");
    //    foreach (double num in numbers)
    //    {
    //        Console.Write(num + " ");
    //    }

    //    Console.ReadLine();
    //}
    //static void Main()
    //{

    //    int[] nums = new int[14];
    //    Random random = new Random();
    //    int sumEvenIndices = 0;
    //    long productOddValues = 1; 


    //    for (int i = 0; i < 14; i++)
    //    {
    //        nums[i] = random.Next(-100, 101); 
    //    }


    //    for (int i = 0; i < 14; i++)
    //    {
    //        if (i % 2 == 0) 
    //        {
    //            sumEvenIndices += nums[i];
    //        }
    //        else 
    //        {
    //            productOddValues *= nums[i];
    //        }
    //    }


    //    Console.WriteLine("Массив целых чисел:");
    //    foreach (int num in nums)
    //    {
    //        Console.Write(num + " ");
    //    }

    //    Console.WriteLine($"\n\nСумма элементов с четными индексами: {sumEvenIndices}");
    //    Console.WriteLine($"Произведение элементов с нечетными значениями: {productOddValues}");

    //    Console.ReadLine();
    //}
    //static void Main()
    //{

    //    double[] numbers = new double[12];
    //    Random random = new Random();
    //    double lastElement;
    //    int countLessThanLast = 0;
    //    double sumLessThanLast = 0;


    //    for (int i = 0; i < 12; i++)
    //    {
    //        numbers[i] = random.NextDouble() * 100; 
    //    }


    //    lastElement = numbers[11];


    //    for (int i = 0; i < 11; i++) 
    //    {
    //        if (numbers[i] < lastElement)
    //        {
    //            countLessThanLast++;
    //            sumLessThanLast += numbers[i];
    //        }
    //    }


    //    Console.WriteLine("Массив действительных чисел:");
    //    foreach (double num in numbers)
    //    {
    //        Console.Write(num + " ");
    //    }

    //    Console.WriteLine($"\n\nКоличество чисел, меньших чем последний элемент: {countLessThanLast}");
    //    Console.WriteLine($"Сумма чисел, меньших чем последний элемент: {sumLessThanLast}");

    //    Console.ReadLine();
    //}
    //static void Main()
    //{

    //    int[] originalArray = new int[15];
    //    Random random = new Random();


    //    for (int i = 0; i < 15; i++)
    //    {
    //        originalArray[i] = random.Next(-25, 26); 
    //    }


    //    int sumPositive = 0;
    //    foreach (int num in originalArray)
    //    {
    //        if (num > 0)
    //        {
    //            sumPositive += num;
    //        }
    //    }


    //    int[] newArray = new int[15];
    //    for (int i = 0; i < 15; i++)
    //    {
    //        newArray[i] = originalArray[i] - sumPositive;
    //    }


    //    Console.WriteLine("Исходный массив целых чисел:");
    //    foreach (int num in originalArray)
    //    {
    //        Console.Write(num + " ");
    //    }

    //    Console.WriteLine($"\nСумма положительных элементов: {sumPositive}");

    //    Console.WriteLine("\n\nНовый массив, элементы которого - разность между элементами исходного массива и суммой положительных элементов:");
    //    foreach (int num in newArray)
    //    {
    //        Console.Write(num + " ");
    //    }

    //    Console.ReadLine();
    //}
    //static void Main()
    //{

    //    double[] numbers = new double[15];
    //    Random random = new Random();


    //    for (int i = 0; i < 15; i++)
    //    {

    //        numbers[i] = (random.NextDouble() * 100) - 50;
    //    }


    //    double productPositive = 1;
    //    double productNegative = 1;


    //    foreach (double num in numbers)
    //    {
    //        if (num > 0)
    //        {
    //            productPositive *= num;
    //        }
    //        else if (num < 0)
    //        {
    //            productNegative *= Math.Abs(num);
    //        }
    //    }


    //    double result = productPositive - productNegative;


    //    Console.WriteLine("Массив действительных чисел:");
    //    foreach (double num in numbers)
    //    {
    //        Console.Write(num + " ");
    //    }

    //    Console.WriteLine($"\n\nРазность между произведением положительных элементов и модулей отрицательных: {result}");

    //    Console.ReadLine();
    //}
    //static void Main()
    //{

    //    int[] numbers = new int[19];
    //    Random random = new Random();


    //    for (int i = 0; i < 19; i++)
    //    {
    //        numbers[i] = random.Next(int.MinValue, int.MaxValue); 
    //    }


    //    int maxNumber = int.MinValue; 

    //    foreach (int num in numbers)
    //    {
    //        if (num > maxNumber)
    //        {
    //            maxNumber = num;
    //        }
    //    }


    //    Console.WriteLine("Массив целых чисел:");
    //    foreach (int num in numbers)
    //    {
    //        Console.Write(num + " ");
    //    }

    //    Console.WriteLine($"\n\nМаксимальное число в массиве: {maxNumber}");

    //    Console.ReadLine();
    //}
    //static void Main()
    //{

    //    int[] numbers = new int[17];
    //    Random random = new Random();


    //    for (int i = 0; i < 17; i++)
    //    {
    //        numbers[i] = random.Next(-50, 51); 
    //    }


    //    double sumPositive = 0;
    //    int countPositive = 0;
    //    foreach (int num in numbers)
    //    {
    //        if (num > 0)
    //        {
    //            sumPositive += num;
    //            countPositive++;
    //        }
    //    }

    //    double averagePositive = countPositive > 0 ? sumPositive / countPositive : 0;


    //    int sumGreaterThanAverage = 0;
    //    int countGreaterThanAverage = 0;
    //    foreach (int num in numbers)
    //    {
    //        if (Math.Abs(num) > averagePositive)
    //        {
    //            sumGreaterThanAverage += num;
    //            countGreaterThanAverage++;
    //        }
    //    }


    //    Console.WriteLine("Массив целых чисел:");
    //    foreach (int num in numbers)
    //    {
    //        Console.Write(num + " ");
    //    }

    //    Console.WriteLine($"\n\nСреднее арифметическое положительных элементов: {averagePositive}");
    //    Console.WriteLine($"\nСумма элементов, абсолютное значение которых больше среднего: {sumGreaterThanAverage}");
    //    Console.WriteLine($"Количество таких элементов: {countGreaterThanAverage}");

    //    Console.ReadLine();
    //}

    //static void Main()
    //{

    //    int[] numbers = new int[19];
    //    Random random = new Random();


    //    int sum = 0;
    //    bool negativeFound = false;


    //    for (int i = 0; i < 19; i++)
    //    {
    //        numbers[i] = random.Next(-100, 101); 

    //        if (!negativeFound)
    //        {
    //            if (numbers[i] < 0)
    //            {
    //                negativeFound = true;
    //            }
    //            else
    //            {
    //                sum += numbers[i];
    //            }
    //        }
    //    }


    //    Console.WriteLine("Массив целых чисел:");
    //    foreach (int num in numbers)
    //    {
    //        Console.Write(num + " ");
    //    }

    //    if (negativeFound)
    //    {
    //        Console.WriteLine($"\n\nСумма элементов до первого отрицательного элемента: {sum}");
    //    }
    //    else
    //    {
    //        Console.WriteLine("\n\nВ массиве нет отрицательных элементов.");
    //    }

    //    Console.ReadLine();
    //}

    //static void Main()
    //{

    //    double[] numbers = new double[12];
    //    Random random = new Random();


    //    double min = double.MaxValue;
    //    double max = double.MinValue;

    //    for (int i = 0; i < 12; i++)
    //    {
    //        numbers[i] = random.NextDouble() * 100 - 50; 

    //        if (numbers[i] < min)
    //        {
    //            min = numbers[i];
    //        }

    //        if (numbers[i] > max)
    //        {
    //            max = numbers[i];
    //        }
    //    }


    //    Console.WriteLine("Массив действительных чисел:");
    //    foreach (double num in numbers)
    //    {
    //        Console.Write(num + " ");
    //    }

    //    Console.WriteLine($"\n\nГраницы интервала, в котором находятся значения элементов массива: [{min}, {max}]");

    //    Console.ReadLine();
    // }

    //static void Main()
    //{
    //    Random rnd = new Random();
    //    double[] array = new double[18];


    //    for (int i = 0; i < 18; i++)
    //    {
    //        array[i] = rnd.NextDouble() * 20 - 10; 
    //    }

    //    double productOfPositives = 1;
    //    double sumOfAbsNegatives = 0;


    //    for (int i = 0; i < 18; i++)
    //    {
    //        if (array[i] > 0)
    //        {
    //            productOfPositives *= array[i];
    //        }
    //        else if (array[i] < 0)
    //        {
    //            sumOfAbsNegatives += Math.Abs(array[i]);
    //        }
    //    }

    //    double result;
    //    if (sumOfAbsNegatives == 0)
    //    {
    //        result = double.PositiveInfinity; 
    //    }
    //    else
    //    {
    //        result = productOfPositives / sumOfAbsNegatives;
    //    }

    //    Console.WriteLine("Частное от деления произведения положительных элементов на сумму модулей отрицательных элементов: " + result);
    //}
    //    static void Main()
    //    {

    //        int[] array1 = new int[10];
    //        int[] array2 = new int[10];
    //        int[] newArray = new int[20];

    //        Random random = new Random();


    //        for (int i = 0; i < 10; i++)
    //        {
    //            array1[i] = random.Next(1, 101); 
    //        }


    //        for (int i = 0; i < 10; i++)
    //        {
    //            array2[i] = random.Next(1, 101);
    //        }


    //        for (int i = 0; i < 20; i++)
    //        {
    //            if (i % 2 == 0) 
    //            {
    //                newArray[i] = array1[i / 2 * 2 + 1]; 
    //            }
    //            else 
    //            {
    //                newArray[i] = array2[i / 2 * 2]; 
    //            }
    //        }


    //        Console.WriteLine("Первый массив целых чисел:");
    //        foreach (int num in array1)
    //        {
    //            Console.Write(num + " ");
    //        }

    //        Console.WriteLine("\n\nВторой массив целых чисел:");
    //        foreach (int num in array2)
    //        {
    //            Console.Write(num + " ");
    //        }

    //        Console.WriteLine("\n\nНовый массив, сформированный из двух исходных массивов:");
    //        foreach (int num in newArray)
    //        {
    //            Console.Write(num + " ");
    //        }

    //        Console.ReadLine();
    //    }
    //    static void Main()
    //    {

    //        int[] originalArray = new int[8];
    //        Random random = new Random();


    //        for (int i = 0; i < 8; i++)
    //        {
    //            originalArray[i] = random.Next(10, 100); 
    //        }


    //        int[] newArray = new int[8];


    //        for (int i = 0; i < 8; i++)
    //        {
    //            newArray[i] = originalArray[i] % 10; 
    //        }


    //        Console.WriteLine("Исходный массив двузначных чисел:");
    //        foreach (int num in originalArray)
    //        {
    //            Console.Write(num + " ");
    //        }

    //        Console.WriteLine("\n\nНовый массив, состоящий из цифр в младших разрядах:");
    //        foreach (int num in newArray)
    //        {
    //            Console.Write(num + " ");
    //        }

    //        Console.ReadLine();
    //    }
    //    static void Main()
    //    {

    //        int[] array = new int[17];
    //        Random random = new Random();
    //        int sumOfDigits = 0;


    //        for (int i = 0; i < 17; i++)
    //        {
    //            array[i] = random.Next(10, 100); 
    //        }


    //        foreach (int num in array)
    //        {
    //            int tensDigit = num / 10; 
    //            int onesDigit = num % 10; 

    //            sumOfDigits += tensDigit + onesDigit; 
    //        }


    //        Console.WriteLine("Массив двузначных чисел:");
    //        foreach (int num in array)
    //        {
    //            Console.Write(num + " ");
    //        }

    //        Console.WriteLine("\n\nСумма цифр в массиве: " + sumOfDigits);

    //        Console.ReadLine();
    //    }
    //    static void Main()
    //    {

    //        double[] array1 = new double[9];
    //        double[] array2 = new double[7];
    //        double[] newArray = new double[array1.Length + array2.Length];

    //        Random random = new Random();


    //        for (int i = 0; i < 9; i++)
    //        {
    //            array1[i] = random.NextDouble() * 100; 
    //        }


    //        for (int i = 0; i < 7; i++)
    //        {
    //            array2[i] = random.NextDouble() * 100;
    //        }


    //        Array.Copy(array1, 0, newArray, 0, array1.Length);
    //        Array.Copy(array2, 0, newArray, array1.Length, array2.Length);
    //        Array.Sort(newArray);


    //        Console.WriteLine("Первый массив действительных чисел:");
    //        foreach (double num in array1)
    //        {
    //            Console.Write(num + " ");
    //        }

    //        Console.WriteLine("\n\nВторой массив действительных чисел:");
    //        foreach (double num in array2)
    //        {
    //            Console.Write(num + " ");
    //        }

    //        Console.WriteLine("\n\nТретий массив, состоящий из упорядоченных значений обоих массивов:");
    //        foreach (double num in newArray)
    //        {
    //            Console.Write(num + " ");
    //        }

    //        Console.ReadLine();
    //    }
    //    static void Main()
    //    {

    //        int[] arrayX = new int[10];
    //        int[] arrayY = new int[10];
    //        int[] arrayS = new int[10];

    //        Random random = new Random();


    //        for (int i = 0; i < 10; i++)
    //        {
    //            arrayX[i] = random.Next(1, 101); 
    //        }


    //        for (int i = 0; i < 10; i++)
    //        {
    //            arrayY[i] = random.Next(1, 101);
    //        }


    //        for (int i = 0; i < 10; i++)
    //        {
    //            arrayS[i] = arrayX[i] == arrayY[i] ? arrayX[i] : 0; 
    //        }


    //        Console.WriteLine("Массив X:");
    //        foreach (int num in arrayX)
    //        {
    //            Console.Write(num + " ");
    //        }

    //        Console.WriteLine("\n\nМассив Y:");
    //        foreach (int num in arrayY)
    //        {
    //            Console.Write(num + " ");
    //        }

    //        Console.WriteLine("\n\nМассив S, содержащий одинаковые элементы X и Y:");
    //        foreach (int num in arrayS)
    //        {
    //            Console.Write(num + " ");
    //        }

    //        Console.ReadLine();
    //    }
    //    static void Main()
    //    {

    //        double[] arrayU = new double[12];
    //        double[] newArray = new double[12];


    //        for (int i = 0; i < 12; i++)
    //        {
    //            arrayU[i] = 1 - 2 * i + 19.3 * Math.Cos(i);
    //        }


    //        double sum = 0;
    //        foreach (double num in arrayU)
    //        {
    //            sum += num;
    //        }
    //        double average = sum / arrayU.Length;


    //        int index = 0;
    //        for (int i = 0; i < 12; i++)
    //        {
    //            if (arrayU[i] < average)
    //            {
    //                newArray[index] = arrayU[i];
    //                index++;
    //            }
    //        }

    //        for (int i = 0; i < 12; i++)
    //        {
    //            if (arrayU[i] >= average)
    //            {
    //                newArray[index] = arrayU[i];
    //                index++;
    //            }
    //        }


    //        Console.WriteLine("Массив У:");
    //        foreach (double num in arrayU)
    //        {
    //            Console.Write(num + " ");
    //        }

    //        Console.WriteLine("\n\nНовый массив, где сначала элементы меньше среднего, затем остальные:");
    //        foreach (double num in newArray)
    //        {
    //            Console.Write(num + " ");
    //        }

    //        Console.ReadLine();
    //    }
    //    static void Main()
    //    {

    //        double[] array = new double[16];
    //        Random random = new Random();


    //        for (int i = 0; i < 16; i++)
    //        {
    //            array[i] = random.NextDouble() * 100; 
    //        }


    //        double sumEvenIndices = 0;
    //        for (int i = 0; i < 16; i += 2)
    //        {
    //            sumEvenIndices += array[i];
    //        }


    //        double sumIndicesMultipleOfThree = 0;
    //        for (int i = 0; i < 16; i++)
    //        {
    //            if (i % 3 == 0)
    //            {
    //                sumIndicesMultipleOfThree += array[i];
    //            }
    //        }


    //        double difference = sumEvenIndices - sumIndicesMultipleOfThree;


    //        Console.WriteLine("Массив вещественных чисел:");
    //        foreach (double num in array)
    //        {
    //            Console.Write(num + " ");
    //        }

    //        Console.WriteLine("\n\nСумма элементов с четными индексами: " + sumEvenIndices);
    //        Console.WriteLine("Сумма элементов, индексы которых кратны трем: " + sumIndicesMultipleOfThree);
    //        Console.WriteLine("Разность между суммами: " + difference);

    //        Console.ReadLine();
    //    }
    //    static void Main()
    //    {

    //        int[] arrayR = new int[9];
    //        Random random = new Random();


    //        for (int i = 0; i < 9; i++)
    //        {
    //            arrayR[i] = random.Next(-50, 51); 
    //        }


    //        int maxOddPositiveValue = int.MinValue;
    //        int maxOddPositiveIndex = -1;


    //        for (int i = 0; i < 9; i++)
    //        {
    //            if (arrayR[i] > 0 && arrayR[i] % 2 != 0 && arrayR[i] > maxOddPositiveValue)
    //            {
    //                maxOddPositiveValue = arrayR[i];
    //                maxOddPositiveIndex = i;
    //            }
    //        }


    //        Console.WriteLine("Массив целых чисел:");
    //        foreach (int num in arrayR)
    //        {
    //            Console.Write(num + " ");
    //        }

    //        if (maxOddPositiveIndex != -1)
    //        {
    //            Console.WriteLine("\n\nИндекс наибольшего из нечетных положительных элементов: " + maxOddPositiveIndex);
    //        }
    //        else
    //        {
    //            Console.WriteLine("\n\nВ массиве нет нечетных положительных элементов.");
    //        }

    //        Console.ReadLine();
    //    }
    //    static void Main()
    //    {

    //        int[] arrayX = new int[15];
    //        for (int i = 0; i < 15; i++)
    //        {
    //            Console.Write("Введите элемент массива X[" + i + "]: ");
    //            arrayX[i] = Convert.ToInt32(Console.ReadLine());
    //        }


    //        Random random = new Random();
    //        double G(int input)
    //        {
    //            return random.NextDouble() * input;
    //        }


    //        double[] arrayY = new double[15];
    //        for (int i = 0; i < 15; i++)
    //        {
    //            arrayY[i] = Math.Cos(arrayX[i]) + 2.971 * G(2 * i * i);
    //        }


    //        double[] combinedArray = arrayX.Concat(arrayY).ToArray();
    //        Array.Sort(combinedArray);
    //        Array.Reverse(combinedArray);


    //        Console.WriteLine("\nУпорядоченный по убыванию массив из значений массивов X и Y:");
    //        foreach (var num in combinedArray)
    //        {
    //            Console.Write(num + " ");
    //        }

    //        Console.ReadLine();
    //    }
    //    static void Main()
    //    {

    //        int[] arrayX = new int[17];
    //        for (int i = 0; i < 17; i++)
    //        {
    //            Console.Write("Введите элемент массива X[" + i + "]: ");
    //            arrayX[i] = Convert.ToInt32(Console.ReadLine());
    //        }


    //        double[] arrayY = new double[17];
    //        for (int i = 0; i < 17; i++)
    //        {
    //            if (Math.Cos(arrayX[i]) > 0)
    //            {
    //                arrayY[i] = Math.Pow(arrayX[i], 3) - 7.5;
    //            }
    //            else
    //            {
    //                arrayY[i] = Math.Abs(arrayX[i] - 5 * Math.Sin(arrayX[i]));
    //            }
    //        }


    //        Array.Sort(arrayY);
    //        Array.Sort(arrayX);
    //        Array.Reverse(arrayX);


    //        double[] arrayR = new double[17];
    //        for (int i = 0; i < 17; i++)
    //        {
    //            if (i % 2 == 0)
    //            {
    //                arrayR[i] = arrayX[i] * arrayY[i];
    //            }
    //        }



    //        Console.WriteLine("\nУпорядоченный по возрастанию массив Y:");
    //        foreach (var num in arrayY)
    //        {

    //            Console.Write(num + " ");
    //        }

    //        Console.WriteLine("\n\nУпорядоченный по убыванию массив X:");
    //        foreach (var num in arrayX)

    //        {

    //            Console.Write(num + " ");
    //        }




    //        foreach (var num in arrayR)
    //        {
    //            Console.Write(num + " ");
    //        }

    //        Console.ReadLine();
    //    }
    //    static void Main()

    //    {

    //        int[] originalArray = new int[9];
    //        Random random = new Random();

    //        for (int i = 0; i < 9; i++)
    //        {
    //            originalArray[i] = random.Next(10, 100); 
    //        }


    //        int[] sumDigitsArray = new int[9];


    //        for (int i = 0; i < 9; i++)
    //        {
    //            int number = originalArray[i];
    //            int sumDigits = 0;


    //            while (number > 0)
    //            {
    //                sumDigits += number % 10;
    //                number /= 10;
    //            }

    //            sumDigitsArray[i] = sumDigits; 
    //        }


    //        Console.WriteLine("Исходный массив двузначных чисел:");
    //        foreach (int num in originalArray)
    //        {
    //            Console.Write(num + " ");
    //        }
    //        foreach (int sum in sumDigitsArray)
    //        {
    //            Console.Write(sum + " ");
    //        }

    //        Console.ReadLine();
    //    }
    //    static void Main()
    //    {

    //        float[] array = new float[12];
    //        Random random = new Random();
    //        for (int i = 0; i < 12; i++)
    //        {
    //            array[i] = (float)random.NextDouble() * 100; 
    //        }


    //        Console.WriteLine("Исходный массив:");
    //        foreach (float num in array)
    //        {
    //            Console.Write(num + " ");
    //        }


    //        int swaps = 0;
    //        for (int i = 0; i < 11; i++)
    //        {
    //            for (int j = 0; j < 11 - i; j++)
    //            {
    //                if (array[j] < array[j + 1])
    //                {
    //                    float temp = array[j];
    //                    array[j] = array[j + 1];
    //                    array[j + 1] = temp;
    //                    swaps++;
    //                }
    //            }
    //        }


    //        Console.WriteLine("\n\nМассив, отсортированный по убыванию:");
    //        foreach (float num in array)
    //        {
    //            Console.Write(num + " ");
    //        }

    //        Console.WriteLine("\n\nКоличество произведенных перестановок: " + swaps);

    //        Console.ReadLine();
    //    }
    //    static void Main()
    //    {
    //        int[] array = new int[11];
    //        int sumNegativeOdd = 0;


    //        Console.WriteLine("Введите 11 целых чисел для массива:");
    //        for (int i = 0; i < 11; i++)
    //        {
    //            Console.Write("Элемент " + i + ": ");
    //            array[i] = Convert.ToInt32(Console.ReadLine());


    //            if (array[i] < 0 && Math.Abs(array[i]) % 2 == 1)
    //            {
    //                sumNegativeOdd += array[i];
    //            }
    //        }


    //        for (int i = 0; i < 11; i++)
    //        {
    //            if (array[i] % 3 == 0)
    //            {
    //                array[i] = sumNegativeOdd;
    //            }
    //        }


    //        Console.WriteLine("\nПреобразованный массив:");
    //        foreach (int num in array)
    //        {
    //            Console.Write(num + " ");
    //        }

    //        Console.ReadLine();
    //    }
    //    static void Main()
    //    {
    //        double[] array = new double[14];
    //        Random random = new Random();
    //        int swaps = 0;


    //        for (int i = 0; i < 14; i++)
    //        {
    //            array[i] = random.NextDouble() * 100; 
    //        }


    //        Console.WriteLine("Исходный массив:");
    //        foreach (double num in array)
    //        {
    //            Console.Write(num + " ");
    //        }


    //        for (int i = 0; i < 7; i++)
    //        {
    //            double temp = array[i];
    //            array[i] = array[i + 7];
    //            array[i + 7] = temp;
    //            swaps++;
    //        }


    //        Console.WriteLine("\n\nПреобразованный массив:");
    //        foreach (double num in array)
    //        {
    //            Console.Write(num + " ");
    //        }

    //        Console.WriteLine("\n\nКоличество произведенных перестановок: " + swaps);

    //        Console.ReadLine();
    //    }
    //    static void Main()
    //    {
    //        double[] array = { 10.5, 7.2, 15.8, 3.4, 9.6, 13.2 }; 
    //        double S = 8.0; 
    //        double maxDiff = Math.Abs(array[0] - S);
    //        double closestElement = array[0];
    //        int index = 0;


    //        for (int i = 1; i < array.Length; i++)
    //        {
    //            double diff = Math.Abs(array[i] - S);
    //            if (diff > maxDiff)
    //            {
    //                maxDiff = diff;
    //                closestElement = array[i];
    //                index = i;
    //            }
    //        }


    //        Console.WriteLine("Наиболее удаленный элемент массива от числа S:");
    //        Console.WriteLine("Значение: " + closestElement);
    //        Console.WriteLine("Индекс: " + index);

    //        Console.ReadLine();
    //    }
    //    static void Main()
    //    {
    //        int[] array = new int[10];
    //        int sum = 0;
    //        int count = 0;


    //        Console.WriteLine("Введите 10 целых чисел для массива:");
    //        for (int i = 0; i < 10; i++)
    //        {
    //            Console.Write("Элемент " + i + ": ");
    //            array[i] = Convert.ToInt32(Console.ReadLine());


    //            if (array[i] < 0)
    //            {
    //                break; 
    //            }

    //            sum += array[i]; 
    //            count++; 
    //        }


    //        Console.WriteLine("\nСумма элементов до первого отрицательного числа: " + sum);

    //        Console.ReadLine();
    //    }
    //    static void Main()
    //    {
    //        int[] array = new int[] { 5, 2, 3, 1, 4, 2, 6, 7, 1 }; 
    //        int localMinCount = 0;

    //        for (int i = 1; i < array.Length - 1; i++)
    //        {
    //            if (array[i] < array[i - 1] && array[i] < array[i + 1])
    //            {
    //                localMinCount++;
    //            }
    //        }


    //        Console.WriteLine("Количество локальных минимумов в массиве: " + localMinCount);
    //    }
    //    static void Main()
    //    {
    //        int[] array = new int[] { 3, 7, 2, 9, 5, 6, 5, 8 }; 
    //        int localMaxCount = 0;


    //        for (int i = 1; i < array.Length - 1; i++)
    //        {
    //            if (array[i] > array[i - 1] && array[i] > array[i + 1])
    //            {
    //                localMaxCount++;
    //            }
    //        }


    //        Console.WriteLine("Количество локальных максимумов в массиве: " + localMaxCount);
    //    }
    //    static void Main()
    //    {
    //        int[] Z = new int[] { 3, -7, 1, 5, 0, -2, 4, 6, 0, -1, 8, 9, -3, 7, 2 }; 
    //        int sum = 0;
    //        bool foundNegative = false;
    //        bool foundZero = false;
    //        string sequence = "";


    //        foreach (int num in Z)
    //        {
    //            if (!foundNegative && num < 0)
    //            {
    //                foundNegative = true;
    //            }
    //            else if (foundNegative && !foundZero && num == 0)
    //            {
    //                foundZero = true;
    //                break;
    //            }

    //            if (foundNegative && !foundZero)
    //            {
    //                sequence += num.ToString() + " ";
    //                sum += num;
    //            }
    //        }


    //        Console.WriteLine("Последовательность элементов: " + sequence);
    //    }
    //    static void Main()
    //    {
    //        int[] array = new int[] { 4, 3, 7, 2, 1, 5, 9, 6 }; /
    //        int sequenceStartIndex = 0;
    //        bool inDecreasingSequence = false;

    //        Console.WriteLine("Индексы убывающих последовательностей чисел:");

    //        for (int i = 1; i < array.Length; i++)
    //        {
    //            if (array[i] < array[i - 1])
    //            {
    //                if (!inDecreasingSequence)
    //                {
    //                    sequenceStartIndex = i - 1;
    //                    inDecreasingSequence = true;
    //                }
    //            }
    //            else
    //            {
    //                if (inDecreasingSequence)
    //                {
    //                    for (int j = sequenceStartIndex; j <= i - 1; j++)
    //                    {
    //                        Console.Write(j + " ");
    //                    }
    //                    Console.WriteLine();
    //                    inDecreasingSequence = false;
    //                }
    //            }
    //        }

    //        if (inDecreasingSequence)
    //        {
    //            for (int j = sequenceStartIndex; j <= array.Length - 1; j++)
    //            {
    //                Console.Write(j + " ");
    //            }
    //            Console.WriteLine();
    //        }
    //    }
    //    static void Main()
    //    {
    //        Random rnd = new Random();
    //        int[] array = new int[20]; 


    //        for (int i = 0; i < array.Length; i++)
    //        {
    //            array[i] = rnd.Next(1, 11); 
    //        }

    //        Console.WriteLine("Исходный массив:");
    //        PrintArray(array);


    //        Dictionary<int, int> countDict = new Dictionary<int, int>();
    //        List<int> result = new List<int>();

    //        foreach (int num in array)
    //        {
    //            if (!countDict.ContainsKey(num))
    //            {
    //                countDict[num] = 1;
    //            }
    //            else
    //            {
    //                countDict[num]++;
    //            }

    //            if (countDict[num] <= 2)
    //            {
    //                result.Add(num);
    //            }
    //        }

    //        PrintArray(result.ToArray());
    //    }


    //    static void PrintArray(int[] arr)
    //    {
    //        foreach (int num in arr)
    //        {
    //            Console.Write(num + " ");
    //        }
    //        Console.WriteLine();
    //    }
    //    static void Main()
    //    {
    //        Random rnd = new Random();
    //        int[] array = new int[10]; 
    //        int[] sortedArray = new int[10]; 
    //        int negativeIndex = 0;
    //        int positiveIndex = sortedArray.Length - 1;


    //        for (int i = 0; i < array.Length; i++)
    //        {
    //            array[i] = rnd.Next(-10, 11); 
    //        }

    //        Console.WriteLine("Исходный массив:");
    //        PrintArray(array);


    //        foreach (int num in array)
    //        {
    //            if (num <= 0)
    //            {
    //                sortedArray[negativeIndex] = num;
    //                negativeIndex++;
    //            }
    //            else
    //            {
    //                sortedArray[positiveIndex] = num;
    //                positiveIndex--;
    //            }
    //        }

    //        PrintArray(sortedArray);
    //    }


    //    static void PrintArray(int[] arr)
    //    {
    //        foreach (int num in arr)
    //        {
    //            Console.Write(num + " ");
    //        }
    //        Console.WriteLine();
    //    }

    //    static void Main()
    //    {
    //        Random rnd = new Random();
    //        int[] X = new int[10]; 
    //        double[] Y = new double[10]; 
    //        double P = 1.0;


    //        for (int i = 0; i < X.Length; i++)
    //        {
    //            X[i] = rnd.Next(-10, 11); 
    //        }

    //        Console.WriteLine("Массив X:");
    //        PrintArray(X);


    //        for (int i = 0; i < Y.Length; i++)
    //        {
    //            Y[i] = X[i] + 0.3;
    //        }

    //        Console.WriteLine("\nМассив Y (результат у = х + 0,3):");
    //        PrintArray(Y);


    //        for (int i = 0; i < X.Length; i += 2)
    //        {
    //            P *= X[i] * Y[i + 2];
    //        }


    //        double R = X[0] * Y[0] * X[1] / 2 * X[8] * Y[8];

    //        double remainder = P % R; 
    //        Console.WriteLine("\nP: " + P);
    //        Console.WriteLine("R: " + R);
    //        Console.WriteLine("Остаток от деления P на R: " + remainder);
    //    }


    //    static void PrintArray<T>(T[] arr)
    //    {
    //        foreach (T num in arr)
    //        {
    //            Console.Write(num + " ");
    //        }
    //        Console.WriteLine();
    //    }

    //static void Main()
    //    {

    //        double[] array1 = new double[9];
    //        double[] array2 = new double[7];
    //        double[] newArray = new double[array1.Length + array2.Length];

    //        Random random = new Random();


    //        for (int i = 0; i < 9; i++)
    //        {
    //            array1[i] = random.NextDouble() * 100; 
    //        }


    //        for (int i = 0; i < 7; i++)
    //        {
    //            array2[i] = random.NextDouble() * 100;
    //        }


    //        Array.Copy(array1, 0, newArray, 0, array1.Length);
    //        Array.Copy(array2, 0, newArray, array1.Length, array2.Length);
    //        Array.Sort(newArray);


    //        Console.WriteLine("Первый массив действительных чисел:");
    //        foreach (double num in array1)
    //        {
    //            Console.Write(num + " ");
    //        }

    //        Console.WriteLine("\n\nВторой массив действительных чисел:");
    //        foreach (double num in array2)
    //        {
    //            Console.Write(num + " ");
    //        }

    //        Console.WriteLine("\n\nТретий массив, состоящий из упорядоченных значений обоих массивов:");
    //        foreach (double num in newArray)
    //        {
    //            Console.Write(num + " ");
    //        }

    //        Console.ReadLine();
    //    }

    //    static void Main()
    //    {
    //        Random rnd = new Random();
    //        int[] originalArray = new int[10];
    //        int[] differenceArray = new int[10];


    //        for (int i = 0; i < originalArray.Length; i++)
    //        {
    //            originalArray[i] = rnd.Next(10, 100); 
    //        }

    //        Console.WriteLine("Исходный массив:");
    //        PrintArray(originalArray);


    //        for (int i = 0; i < originalArray.Length; i++)
    //        {
    //            int tens = originalArray[i] / 10; 
    //            int ones = originalArray[i] % 10; 
    //            differenceArray[i] = Math.Abs(tens - ones); 
    //        }

    //        Console.WriteLine("\nНовый массив с разностями цифр:");
    //        PrintArray(differenceArray);
    //    }


    //    static void PrintArray(int[] arr)
    //    {
    //        foreach (int num in arr)
    //        {
    //            Console.Write(num + " ");
    //        }
    //        Console.WriteLine();
    //    }
    //    static void Main()
    //    {
    //        Random rnd = new Random();
    //        int[] array = new int[15]; 


    //        for (int i = 0; i < array.Length; i++)
    //        {
    //            array[i] = rnd.Next(-50, 51); 
    //        }

    //        Console.WriteLine("Исходный массив:");
    //        PrintArray(array);


    //        Array.Sort(array, (x, y) =>
    //        {
    //            if (x < 0 && y < 0) 
    //            {
    //                return x.CompareTo(y);
    //            }
    //            else if (x >= 0 && y >= 0) 
    //            {
    //                return y.CompareTo(x);
    //            }
    //            else 
    //            {
    //                return x < 0 ? -1 : 1; 
    //            }
    //        });

    //        Console.WriteLine("\nУпорядоченный массив:");
    //        PrintArray(array);
    //    }


    //    static void PrintArray(int[] arr)
    //    {
    //        foreach (int num in arr)
    //        {
    //            Console.Write(num + " ");
    //        }
    //        Console.WriteLine();
    //    }
    //    static void Main()
    //    {
    //        Random rnd = new Random();
    //        double[] firstArray = new double[12]; 
    //        double[] secondArray = new double[12]; 


    //        for (int i = 0; i < firstArray.Length; i++)
    //        {
    //            firstArray[i] = rnd.NextDouble() * 100; 
    //            secondArray[i] = rnd.NextDouble() * 100; 
    //        }

    //        Console.WriteLine("Первый массив:");
    //        PrintArray(firstArray);

    //        Console.WriteLine("\nВторой массив:");
    //        PrintArray(secondArray);


    //        for (int i = 0; i < firstArray.Length; i++)
    //        {
    //            if (Array.IndexOf<double>(secondArray, firstArray[i]) != -1)
    //            {
    //                firstArray[i] = 0;
    //            }
    //        }

    //        Console.WriteLine("\nРезультат после замены нулями:");
    //        PrintArray(firstArray);
    //    }

    //    static void Main()

    //    {

    //        int[] originalArray = new int[9];
    //        Random random = new Random();

    //        for (int i = 0; i < 9; i++)
    //        {
    //            originalArray[i] = random.Next(10, 100); 
    //        }


    //        int[] sumDigitsArray = new int[9];


    //        for (int i = 0; i < 9; i++)
    //        {
    //            int number = originalArray[i];
    //            int sumDigits = 0;


    //            while (number > 0)
    //            {
    //                sumDigits += number % 10;
    //                number /= 10;
    //            }

    //            sumDigitsArray[i] = sumDigits; 
    //        }


    //        Console.WriteLine("Исходный массив двузначных чисел:");
    //        foreach (int num in originalArray)
    //        {
    //            Console.Write(num + " ");
    //        }
    //        foreach (int sum in sumDigitsArray)
    //        {
    //            Console.Write(sum + " ");
    //        }

    //        Console.ReadLine();
    //    }


    //    static void PrintArray(double[] arr)
    //    {
    //        foreach (double num in arr)
    //        {
    //            Console.Write(num + " ");
    //        }
    //        Console.WriteLine();
    //    }
    //    static void Main()
    //    {
    //        Random rnd = new Random();
    //        int[] array = new int[15];


    //        for (int i = 0; i < array.Length; i++)
    //        {
    //            array[i] = rnd.Next(-50, 51); 
    //        }

    //        Console.WriteLine("Исходный массив:");
    //        PrintArray(array);

    //        int increasingSegments = CountIncreasingSegments(array);
    //        Console.WriteLine("\nКоличество участков с монотонным возрастанием: " + increasingSegments);
    //    }


    //    static int CountIncreasingSegments(int[] arr)
    //    {
    //        int count = 0;
    //        bool increasing = false;

    //        for (int i = 1; i < arr.Length; i++)
    //        {
    //            if (arr[i] > arr[i - 1])
    //            {
    //                if (!increasing)
    //                {
    //                    increasing = true;
    //                    count++;
    //                }
    //            }
    //            else
    //            {
    //                increasing = false;
    //            }
    //        }

    //        return count;
    //    }


    //    static void PrintArray(int[] arr)
    //    {
    //        foreach (int num in arr)
    //        {
    //            Console.Write(num + " ");
    //        }
    //        Console.WriteLine();
    //    }
    //    static void Main()
    //    {
    //        Random rnd = new Random();
    //        int[] array = new int[15]; 


    //        for (int i = 0; i < array.Length; i++)
    //        {
    //            array[i] = rnd.Next(1, 101); 
    //        }

    //        Console.WriteLine("Исходный массив:");
    //        PrintArray(array);

    //        int result = CalculateRemainder(array);
    //        Console.WriteLine("\nОстаток от деления суммы элементов с четными индексами на сумму элементов с нечетными индексами: " + result);
    //    }


    //    static int CalculateRemainder(int[] arr)
    //    {
    //        int sumEven = 0;
    //        int sumOdd = 0;

    //        for (int i = 0; i < arr.Length; i++)
    //        {
    //            if (i % 2 == 0) 
    //            {
    //                sumEven += arr[i];
    //            }
    //            else 
    //            {
    //                sumOdd += arr[i];
    //            }
    //        }

    //        return sumEven % sumOdd;
    //    }


    //    static void PrintArray(int[] arr)
    //    {
    //        foreach (int num in arr)
    //        {
    //            Console.Write(num + " ");
    //        }
    //        Console.WriteLine();
    //    }
    //    static void Main()
    //    {
    //        Random rnd = new Random();
    //        int[] array = new int[15]; 


    //        for (int i = 0; i < array.Length; i++)
    //        {
    //            array[i] = rnd.Next(1, 101); 
    //        }

    //        Console.WriteLine("Исходный массив:");
    //        PrintArray(array);

    //        double average = CalculateAverage(array);
    //        Console.WriteLine("\nСреднее арифметическое элементов массива: " + average);

    //        int count = CountElementsAboveAverage(array, average);
    //        double percentage = (double)count / array.Length * 100;
    //        Console.WriteLine("Процент элементов, превышающих среднее арифметическое: " + percentage.ToString("0.00") + "%");
    //    }


    //    static double CalculateAverage(int[] arr)
    //    {
    //        int sum = 0;
    //        foreach (int num in arr)
    //        {
    //            sum += num;
    //        }

    //        return (double)sum / arr.Length;
    //    }


    //    static int CountElementsAboveAverage(int[] arr, double average)
    //    {
    //        int count = 0;
    //        foreach (int num in arr)
    //        {
    //            if (num > average)
    //            {
    //                count++;
    //            }
    //        }

    //        return count;
    //    }


    //    static void PrintArray(int[] arr)
    //    {
    //        foreach (int num in arr)
    //        {
    //            Console.Write(num + " ");
    //        }
    //        Console.WriteLine();
    //    }
    //    static void Main()
    //    {
    //        Random rnd = new Random();


    //        double[] array1 = new double[10];
    //        for (int i = 0; i < array1.Length; i++)
    //        {
    //            array1[i] = rnd.NextDouble() * 100;
    //        }


    //        double[] array2 = new double[10];
    //        for (int i = 0; i < array2.Length; i++)
    //        {
    //            array2[i] = rnd.NextDouble() * 100;
    //        }

    //        Console.WriteLine("Первый массив:");
    //        PrintArray(array1);

    //        Console.WriteLine("\nВторой массив:");
    //        PrintArray(array2);

    //        double max1 = FindMax(array1);
    //        double max2 = FindMax(array2);

    //        int indexMax1 = Array.IndexOf(array1, max1);
    //        int indexMax2 = Array.IndexOf(array2, max2);


    //        double temp = array1[indexMax1];
    //        array1[indexMax1] = array2[indexMax2];
    //        array2[indexMax2] = temp;

    //        Console.WriteLine("\nМаксимальный элемент в первом массиве: " + max1);
    //        Console.WriteLine("Максимальный элемент во втором массиве : " + max2);

    //        Console.WriteLine("\nПосле обмена максимальных элементов:");
    //        Console.WriteLine("Первый массив:");
    //        PrintArray(array1);
    //        Console.WriteLine("\nВторой массив:");
    //        PrintArray(array2);
    //    }


    //    static double FindMax(double[] arr)
    //    {
    //        double max = arr[0];
    //        foreach (double num in arr)
    //        {
    //            if (num > max)
    //            {
    //                max = num;
    //            }
    //        }

    //        return max;
    //    }


    //    static void PrintArray(double[] arr)
    //    {
    //        foreach (double num in arr)
    //        {
    //            Console.Write(num + " ");
    //        }
    //        Console.WriteLine();
    //    }
    //static void Main()
    //{

    //    string binaryNumber = "101010";


    //    string hexadecimalNumber = Convert.ToInt32(binaryNumber, 2).ToString("X");


    //    Console.WriteLine($"Число {binaryNumber} в шестнадцатеричной системе равно {hexadecimalNumber}");
    //}
    //static void Main()
    //{

    //    Random random = new Random();

    //    int integerPart = random.Next(0, 1000); 

    //    double fractionalPart = random.NextDouble(); 

    //    string binaryNumber = Convert.ToString(integerPart, 2) + "." + Convert.ToString((int)(fractionalPart * 1000), 2); 


    //    string[] parts = binaryNumber.Split('.');

    //    int decimalIntegerPart = Convert.ToInt32(parts[0], 2);

    //    double decimalFractionalPart = Convert.ToInt32(parts[1], 2) / Math.Pow(2, parts[1].Length);


    //    double decimalNumber = decimalIntegerPart + decimalFractionalPart;

    //    Console.WriteLine($"Двоичное число {binaryNumber} в десятичной системе равно {decimalNumber}");
    //}
    //static void Main()
    //{

    //    Random random = new Random();

    //    int integerPart = random.Next(0, 1000); 

    //    double fractionalPart = random.NextDouble(); 

    //    string binaryNumber = Convert.ToString(integerPart, 2) + "." + Convert.ToString((int)(fractionalPart * 1000), 2); 


    //    string[] parts = binaryNumber.Split('.');

    //    int octalIntegerPart = Convert.ToInt32(parts[0], 2);

    //    double octalFractionalPart = Convert.ToInt32(parts[1], 2) / Math.Pow(2, parts[1].Length) * 8;


    //    double octalNumber = octalIntegerPart + octalFractionalPart;

    //    Console.WriteLine($"Двоичное число {binaryNumber} в восьмеричной системе равно {octalNumber}");
    //}
    //static void Main()
    //{

    //    Random random = new Random();

    //    int integerPart = random.Next(0, 1000); 

    //    double fractionalPart = random.NextDouble(); 

    //    string binaryNumber = Convert.ToString(integerPart, 2) + "." + Convert.ToString((int)(fractionalPart * 1000), 2);  


    //    string[] parts = binaryNumber.Split('.');

    //    int hexIntegerPart = Convert.ToInt32(parts[0], 2);

    //    double hexFractionalPart = Convert.ToInt32(parts[1], 2) / Math.Pow(2, parts[1].Length);


    //    string hexFractionalString = "";

    //    for (int i = 0; i < 3; i++) 
    //    {
    //        hexFractionalPart *= 16; 
    //        int integerPart = (int)hexFractionalPart;
    //        hexFractionalString += integerPart.ToString("X");
    //        hexFractionalPart -= integerPart;
    //    }


    //    string hexNumber = hexIntegerPart.ToString("X") + "." + hexFractionalString;

    //    Console.WriteLine($"Двоичное число {binaryNumber} в шестнадцатеричной системе равно {hexNumber}");
    //}
    //static void Main()
    //{
    //    Random random = new Random();
    //    int[] initialArray = new int[15];


    //    for (int i = 0; i < initialArray.Length; i++)
    //    {
    //        initialArray[i] = random.Next(10, 100);
    //    }

    //    Console.WriteLine("Исходный массив:");
    //    PrintArray(initialArray);


    //    int[] modifiedArray = ModifyArray(initialArray);

    //    Console.WriteLine("\nНовый массив с измененной разрядностью:");
    //    PrintArray(modifiedArray);
    //}

    //static int[] ModifyArray(int[] array)
    //{
    //    int[] modifiedArray = new int[array.Length];

    //    for (int i = 0; i < array.Length; i++)
    //    {
    //        int units = array[i] % 10; 
    //        int tens = array[i] / 10; 

    //        modifiedArray[i] = units * 10 + tens; 
    //    }

    //    return modifiedArray;
    //}

    //static void PrintArray(int[] array)
    //{
    //    foreach (int num in array)
    //    {
    //        Console.Write(num + " ");
    //    }
    //}

    //static void Main()
    //{
    //    Random random = new Random();
    //    int[] octalArray = new int[9];


    //    for (int i = 0; i < octalArray.Length; i++)
    //    {
    //        octalArray[i] = random.Next(10, 100); 
    //    }

    //    Console.WriteLine("Исходный массив в восьмеричной системе:");
    //    PrintArray(octalArray, 8); 


    //    int[] decimalArray = new int[octalArray.Length];
    //    for (int i = 0; i < octalArray.Length; i++)
    //    {
    //        decimalArray[i] = Convert.ToInt32(octalArray[i].ToString(), 8); 
    //    }

    //    Console.WriteLine("\nНовый массив в десятичной системе:");
    //    PrintArray(decimalArray, 10); 
    //}

    //static void PrintArray(int[] array, int numberBase)
    //{
    //    foreach (int num in array)
    //    {
    //        Console.Write(Convert.ToString(num, numberBase) + " "); 
    //    }
    //}

    //static void Main()
    //{
    //    Random random = new Random();
    //    int[] originalArray = new int[7];


    //    for (int i = 0; i < originalArray.Length; i++)
    //    {
    //        originalArray[i] = random.Next(10, 100); 
    //    }

    //    Console.WriteLine("Исходный массив:");
    //    PrintArray(originalArray);


    //    int[] newDigitsArray = ExtractMostSignificantDigits(originalArray);

    //    Console.WriteLine("\nНовый массив из цифр старших разрядов:");
    //    PrintArray(newDigitsArray);
    //}

    //static int[] ExtractMostSignificantDigits(int[] array)
    //{
    //    int[] newDigitsArray = new int[array.Length];

    //    for (int i = 0; i < array.Length; i++)
    //    {
    //        newDigitsArray[i] = array[i] / 10; 
    //    }

    //    return newDigitsArray;
    //}

    //static void PrintArray(int[] array)
    //{
    //    foreach (int num in array)
    //    {
    //        Console.Write(num + " ");
    //    }
    //}

    //static void Main()
    //{
    //    Random random = new Random();

    //    double[] array1 = new double[7]; 
    //    double[] array2 = new double[9]; 


    //    for (int i = 0; i < array1.Length; i++)
    //    {
    //        array1[i] = random.NextDouble() * 100; 
    //    }


    //    for (int i = 0; i < array2.Length; i++)
    //    {
    //        array2[i] = random.NextDouble() * 100; 
    //    }


    //    Console.WriteLine("Первый массив из 7 элементов:");
    //    PrintArray(array1);


    //    Console.WriteLine("\nВторой массив из 9 элементов:");
    //    PrintArray(array2);
    //}

    //static void PrintArray(double[] array)
    //{
    //    foreach (double num in array)
    //    {
    //        Console.Write(num + " ");
    //    }
    //}

    //static void Main()
    //{
    //    Random random = new Random();

    //    double[] array1 = new double[7]; 
    //    double[] array2 = new double[9]; 


    //    for (int i = 0; i < array1.Length; i++)
    //    {
    //        array1[i] = random.NextDouble() * 100; 
    //    }


    //    for (int i = 0; i < array2.Length; i++)
    //    {
    //        array2[i] = random.NextDouble() * 100; 
    //    }


    //    double[] mergedArray = array1.Concat(array2).OrderByDescending(x => x).ToArray();


    //    Console.WriteLine("Третий массив из упорядоченных по убыванию значений:");
    //    PrintArray(mergedArray);
    //}

    //static void PrintArray(double[] array)
    //{
    //    foreach (double num in array)
    //    {
    //        Console.Write(num + " ");
    //    }
    //}

    //static void Main()
    //{
    //    Random random = new Random();
    //    List<int> binaryArray = new List<int>();


    //    for (int i = 0; i < 12; i++)
    //    {
    //        binaryArray.Add(random.Next(0, 2)); 
    //    }

    //    Console.WriteLine("Исходный массив двоичных чисел:");
    //    PrintList(binaryArray);


    //    int limit = 2;
    //    var result = binaryArray.GroupBy(x => x)

    //                            .Where(g => g.Count() <= limit)

    //                            .SelectMany(g => g)

    //                            .ToList();

    //    Console.WriteLine("\nМассив после удаления элементов, встречающихся более двух раз:");

    //    PrintList(result);
    //}

    //static void PrintList(List<int> list)
    //{
    //    foreach (int num in list)
    //    {
    //        Console.Write(num + " ");
    //    }
    //}

    //static void Main()
    //{
    //    Random random = new Random();

    //    List<int> array = GenerateArrayWithTwoDuplicates(random);

    //    Console.WriteLine("Исходный массив:");

    //    PrintList(array);


    //    FindDuplicateIndices(array);
    //}

    //static List<int> GenerateArrayWithTwoDuplicates(Random random)
    //{
    //    List<int> array = new List<int>();

    //    int randomDuplicate = random.Next(10); 

    //    int duplicateCount = 0;

    //    for (int i = 0; i < 10; i++)
    //    {
    //        if (duplicateCount < 2 && random.Next(10) == randomDuplicate)
    //        {
    //            array.Add(randomDuplicate);
    //            duplicateCount++;
    //        }
    //        else
    //        {
    //            array.Add(random.Next(10));
    //        }
    //    }

    //    return array;
    //}

    //static void FindDuplicateIndices(List<int> array)
    //{
    //    Dictionary<int, int> indexMap = new Dictionary<int, int>();

    //    for (int i = 0; i < array.Count; i++)
    //    {
    //        if (indexMap.ContainsKey(array[i]))
    //        {
    //            Console.WriteLine("Повторяющийся элемент " + array[i] + " найден на позициях " + indexMap[array[i]] + " и " + i);
    //            return;
    //        }
    //        else
    //        {
    //            indexMap[array[i]] = i;
    //        }
    //    }

    //    Console.WriteLine("Повторяющихся элементов не найдено.");
    //}

    //static void PrintList(List<int> array)
    //{
    //    foreach (int num in array)
    //    {
    //        Console.Write(num + " ");
    //    }
    //}
    //static void Main()
    //{
    //    Random random = new Random();

    //    int binaryNumber = GenerateRandomBinaryNumber(random);

    //    Console.WriteLine("Исходное двоичное число: " + Convert.ToString(binaryNumber, 2));

    //    int shiftedNumber = PerformLeftShift(binaryNumber, 2);

    //    Console.WriteLine("Результат циклического сдвига влево на две позиции: " + Convert.ToString(shiftedNumber, 2));
    //}

    //static int GenerateRandomBinaryNumber(Random random)
    //{
    //    return random.Next(256); 
    //}

    //static int PerformLeftShift(int number, int positions)
    //{
    //    int shiftedNumber = (number << positions) | (number >> (8 - positions));

    //    return shiftedNumber & 0xFF; 
    //}
    //static void Main()
    //{
    //    Random random = new Random();

    //    List<int> binaryNumbers = GenerateRandomBinaryNumbers(random, 10);

    //    Console.WriteLine("Исходный массив чисел в двоичной системе:");

    //    foreach (int num in binaryNumbers)
    //    {
    //        Console.Write(Convert.ToString(num, 2) + " ");
    //    }


    //    binaryNumbers = binaryNumbers.OrderByDescending(x => x).ToList();

    //    Console.WriteLine("\n\nУпорядоченный массив по убыванию:");

    //    foreach (int num in binaryNumbers)
    //    {
    //        Console.Write(Convert.ToString(num, 2) + " ");
    //    }


    //    int sum = binaryNumbers.Sum();

    //    Console.WriteLine("\n\nСумма чисел в десятичной системе: " + sum);
    //}

    //static List<int> GenerateRandomBinaryNumbers(Random random, int count)
    //{
    //    List<int> binaryNumbers = new List<int>();

    //    for (int i = 0; i < count; i++)
    //    {
    //        binaryNumbers.Add(random.Next(256)); 
    //    }

    //    return binaryNumbers;
    //}

    //static void Main()
    //{
    //    Random random = new Random();

    //    List<int> binaryNumbers = GenerateRandomBinaryNumbers(random, 10);

    //    Console.WriteLine("Исходный массив чисел в двоичной системе:");

    //    foreach (int num in binaryNumbers)
    //    {
    //        Console.Write(Convert.ToString(num, 2) + " ");
    //    }


    //    binaryNumbers = binaryNumbers.OrderBy(x => x).ToList();

    //    Console.WriteLine("\n\nУпорядоченный массив по возрастанию:");

    //    foreach (int num in binaryNumbers)
    //    {
    //        Console.Write(Convert.ToString(num, 2) + " ");
    //    }


    //    double average = binaryNumbers.Average();

    //    Console.WriteLine("\n\nСреднее значение чисел в десятичной системе: " + average);
    //}

    //static List<int> GenerateRandomBinaryNumbers(Random random, int count)
    //{
    //    List<int> binaryNumbers = new List<int>();

    //    for (int i = 0; i < count; i++)
    //    {
    //        binaryNumbers.Add(random.Next(256)); 
    //    }

    //    return binaryNumbers;
    //}
    //static void Main()
    //{
    //    Random random = new Random();
    //    List<int> binaryNumbers = GenerateRandomBinaryNumbers(random, 10);

    //    Console.WriteLine("Исходный массив чисел в двоичной системе:");
    //    PrintBinaryNumbers(binaryNumbers);


    //    int minIndex = binaryNumbers.IndexOf(binaryNumbers.Min());

    //    int maxIndex = binaryNumbers.IndexOf(binaryNumbers.Max());


    //    int temp = binaryNumbers[minIndex];

    //    binaryNumbers[minIndex] = binaryNumbers[maxIndex];

    //    binaryNumbers[maxIndex] = temp;

    //    Console.WriteLine("\n\nМассив после замены:");
    //    PrintBinaryNumbers(binaryNumbers);
    //}

    //static List<int> GenerateRandomBinaryNumbers(Random random, int count)
    //{
    //    List<int> binaryNumbers = new List<int>();

    //    for (int i = 0; i < count; i++)
    //    {
    //        binaryNumbers.Add(random.Next(256)); 
    //    }

    //    return binaryNumbers;
    //}

    //static void PrintBinaryNumbers(List<int> binaryNumbers)
    //{

    //    foreach (int num in binaryNumbers)
    //    {
    //        Console.Write(Convert.ToString(num, 2) + " ");
    //    }
    //}
    //static void Main()
    //{
    //    Random random = new Random();


    //    List<int> binaryNumbers = GenerateRandomBinaryNumbers(random, 10);

    //    Console.WriteLine("Исходный массив чисел в двоичной системе:");

    //    foreach (int num in binaryNumbers)
    //    {
    //        Console.Write(Convert.ToString(num, 2) + " ");
    //    }


    //    binaryNumbers = binaryNumbers.OrderByDescending(x => x).ToList();

    //    Console.WriteLine("\n\nУпорядоченный массив по убыванию:");


    //    foreach (int num in binaryNumbers)
    //    {
    //        Console.Write(Convert.ToString(num, 2) + " ");
    //    }


    //    int sum = binaryNumbers.Sum();

    //    Console.WriteLine("\n\nСумма чисел в десятичной системе: " + sum);
    //}
}