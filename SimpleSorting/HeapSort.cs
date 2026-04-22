namespace SimpleSorting;

internal class HeapSort : Sorting
{
    public override string GetName() => "HeapSort";

    ulong cmp = 0, chg = 0;
    // упорядочивание локального поддерева
    private void heapify(ref Record[] arr, int root, int size)
    {
        int p = root;
        int l = 2 * p + 1;
        int r = 2 * p + 2;
        cmp += 2;
        if (l < size && arr[l] > arr[p]) p = l;
        if (r < size && arr[r] > arr[p]) p = r;
        if (p == root)
            return;
        chg++;
        swap(ref arr, root, p);
        heapify(ref arr, p, size);
    }
    private void heap(ref Record[] arr)
    {
        for (int i = arr.Length / 2 - 1; i >= 0; i--)
            heapify(ref arr, i, arr.Length);

    }

    public override (ulong, ulong) Sort(ref Record[] arr)
    {
        //Обнуляем счетчики
        ulong cmp = 0, chg = 0;

        heap(ref arr);
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            swap(ref arr, 0, i);
            chg++;
            heapify(ref arr, 0, i);
        }
        return (cmp, chg);
    }

}
