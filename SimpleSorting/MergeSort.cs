namespace SimpleSorting;

internal class MergeSort : Sorting
{
    public override (ulong, ulong) Sort(ref Record[] arr)
    {
        ulong cmp = 0, chg = 0;
        mergeSort(ref arr, 0, arr.Length - 1, ref cmp, ref chg);
        return (cmp, chg);
    }

    private void mergeSort(ref Record[] arr, int L, int R,
                           ref ulong cmp, ref ulong chg)
    {
        if (L >= R) return;
        int M = (L + R) / 2;
        mergeSort(ref arr, L, M, ref cmp, ref chg);
        mergeSort(ref arr, M + 1, R, ref cmp, ref chg);
        merge(ref arr, L, M, R, ref cmp, ref chg);
    }
    private void merge(ref Record[] arr, int L, int M, int R,
                       ref ulong cmp, ref ulong chg)
    {
        Record[] T = new Record[R - L + 1];
        int a = L, b = M + 1, m = 0;
        while (a <= M && b <= R)
        {
            cmp++;
            chg++;
            if (arr[a] > arr[b])
                T[m++] = arr[b++];
            else
                T[m++] = arr[a++];
        }
        while (a <= M)
        {
            chg++;
            T[m++] = arr[a++];
        }
        while (b <= R)
        {
            chg++;
            T[m++] = arr[b++];
        }
        for (int i = L; i <= R; i++)
            arr[i] = T[i - L];
    }

}
