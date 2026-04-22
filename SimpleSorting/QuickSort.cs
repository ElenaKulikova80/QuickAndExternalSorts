namespace SimpleSorting;

internal class QuickSort : Sorting
{
    private void qsort(ref Record[] arr, int L, int R,
                      ref ulong cmp, ref ulong chg)
    {
        if (L >= R) return;
        int M = split(ref arr, L, R, ref cmp, ref chg);
        qsort(ref arr, L, M - 1, ref cmp, ref chg);
        qsort(ref arr, M + 1, R, ref cmp, ref chg);
        return;
    }

    public override (ulong, ulong) Sort(ref Record[] arr)
    {
        ulong cmp = 0, chg = 0;
        qsort(ref arr, 0, arr.Length - 1, ref cmp, ref chg);
        return (cmp, chg);
    }

    private int split(ref Record[] arr, int L, int R,
                      ref ulong cmp, ref ulong chg)
    {
        Record pivot = arr[R];
        int M = L - 1;
        for (int j = L; j <= R; j++)
        {
            cmp++;
            if (pivot >= arr[j])
            {
                M++;
                if (M != j)
                {
                    chg++;
                    swap(ref arr, M, j);
                }
            }
        }
        return M;
    }

}
