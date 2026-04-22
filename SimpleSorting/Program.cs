using System.Diagnostics;

namespace SimpleSorting;

internal class Program
{
    static void Main(string[] args)
    {
        Random rnd = new(12345);
        for (int N = 100; N < 1000000; N *= 10)
        {
            Record[] arr = new Record[N];
            for (int i = 0; i < N; i++)
                arr[i] = new Record(rnd.Next(0, N * 2),
                                    ((char)('a' + rnd.Next(0, 26))).ToString());
            sort(arr, "Произвольный порядок");

        }
        Console.ReadKey();
    }

    static void sort(Record[] arr, string name)
    {
        Sorting[] sorters = new Sorting[]
        {
            //new HeapSort(),
            //new SelectionSort(),
            new QuickSort(),
            new MergeSort()
        };

        int N = arr.Length;
        Console.WriteLine($"\n{N} элементов");

        foreach (var sort in sorters)
        {
            string algoName = sort.GetType().Name;  

            Record[] copy = new Record[N];
            Array.Copy(arr, copy, N);

            // Замер времени сортирвки
            Stopwatch stopwatch = Stopwatch.StartNew();
            (ulong cmp, ulong chg) = sort.Sort(ref copy);
            stopwatch.Stop();

            double elapsedMs = stopwatch.Elapsed.TotalMilliseconds;

            // Детальный вывод для малых массивов
            if (N < 50)
            {
                for (int i = 0; i < N; i++)
                {
                    Console.WriteLine($"{arr[i]}\t{copy[i]}");
                }
            }

            //Вывод статистики с именем алгоритма
            Console.WriteLine($"\n Статистика для {algoName}:");
            Console.WriteLine($"   Количество сравнений: {cmp}");
            Console.WriteLine($"   Количество обменов: {chg}");
            Console.WriteLine($"   Время: {elapsedMs:F3} мс");
        }
        
    }

    


}


