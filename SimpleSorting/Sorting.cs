namespace SimpleSorting;

internal class Sorting
{
    protected static void swap(ref Record[] arr, int i, int j)
    {
        Record temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

    public virtual (ulong, ulong) Sort(ref Record[] arr)
    {
        return default;
    }

    public virtual (ulong, ulong) SortOptimized(ref Record[] arr)
    {
        return default;
    }

    public virtual string GetName() => this.GetType().Name;
}
