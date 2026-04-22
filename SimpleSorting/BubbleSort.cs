namespace SimpleSorting;

internal class BubbleSort : Sorting
{
    public override (ulong, ulong) Sort (ref Record[] arr)
    {
        ulong cmp = 0, chg = 0;
        for (int i=0; i<arr.Length - 1; i++)
        {
            for(int j=arr.Length - 1; j > i; j--)
            {
                cmp++;
                if (arr[j] < arr[j - 1])
                {
                    chg++;
                    swap(ref arr, j, j - 1);
                }
            }
        }
        return (cmp, chg);
    }

    public override (ulong, ulong) SortOptimized(ref Record[] arr)
    {
        ulong cmp = 0, chg = 0;
        bool flag = false;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            flag = false;
            for (int j = arr.Length - 1; j > i; j--)
            {
                cmp++;
                if (arr[j] < arr[j - 1])
                {
                    flag = true;
                    chg++;
                    swap(ref arr, j, j - 1);
                }
            }

            if (flag == false)
                break;
        }
        return (cmp, chg);
    }
}
