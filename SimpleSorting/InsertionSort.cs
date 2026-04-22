namespace SimpleSorting;

internal class InsertionSort : Sorting
{
    public override (ulong, ulong) Sort(ref Record[] arr)
    {
        ulong cmp = 0, chg = 0;
        for (int i = 1; i < arr.Length; i++)
        {
            int index = i - 1;
            while (index >= 0)
            {
                cmp++;
                if (arr[index] <= arr[index + 1])
                    break;
                chg++;
                swap(ref arr, index, index + 1);
                index--;
            }
        }
        return (cmp, chg);
    }

    public override (ulong, ulong) SortOptimized(ref Record[] arr)
    {
        ulong cmp = 0, chg = 0;
        for (int i = 1; i < arr.Length; i++)
        {
            int index = i;
            Record record = arr[i];
            while (index > 0)
            {
                cmp++;
                if (arr[index - 1] <= record)
                    break;
                chg++;
                arr[index] = arr[index - 1];
                index--;
            }
            arr[index] = record;
        }
        return (cmp, chg);
    }
}
