namespace SimpleSorting;

internal class SelectionSort : Sorting
{
    public override string GetName() => "SelectionSort";

    public override (ulong,ulong) Sort (ref Record[] arr)
    {
        ulong cmp = 0, chg = 0;
        for(int i = 0; i < arr.Length - 1; i++)
        {
            int min = i;
            for(int j = i+1; j < arr.Length; j++)
            {
                cmp++;
                if (arr[j] < arr[min])
                    min = j;
            }
            chg++;
            swap(ref arr, i, min);
        }
        return (cmp, chg);
    }
}
