namespace SimpleSorting;

internal class Record
{
    int key;
    string value;
    public int Key { get { return key; } }
    public string Value { get { return value; } }

    public Record(int key, string value)
    {
        this.key = key;
        this.value = value;
    }

    public override string ToString()
    {
        return key.ToString().PadLeft(3, ' ') + ": " + value;
    }

    public static bool operator <(Record a, Record b)
    {
        return a.key < b.key;
    }

    public static bool operator >(Record a, Record b)
    {
        return a.key > b.key;
    }

    public static bool operator ==(Record a, Record b)
    {
        return a.key == b.key;
    }

    public static bool operator !=(Record a, Record b)
    {
        return !(a.key == b.key);
    }

    public static bool operator <=(Record a, Record b)
    {
        return a.key <= b.key;
    }

    public static bool operator >=(Record a, Record b)
    {
        return a.key >= b.key;
    }
}
