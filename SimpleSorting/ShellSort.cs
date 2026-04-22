namespace SimpleSorting;

internal class ShellSort:Sorting
{
    public override (ulong, ulong) Sort(ref Record[] arr)
    {
        ulong cmp = 0, chg = 0;
        for (int gap = arr.Length / 2; gap > 0; gap /= 2)
        {
            for (int j = gap; j < arr.Length; j++)
            {
                for (int i = j; i >= gap; i -= gap)
                {
                    cmp++;
                    if (arr[i - gap] <= arr[i])
                        break;
                    chg++;
                    swap(ref arr, i - gap, i);
                }
            }
        }
        return (cmp, chg);
    }

}
