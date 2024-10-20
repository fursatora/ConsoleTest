
public class MyList
{
    private int[] _array = new int[4];
    private int _count = 0;

    public int Count 
    {
        get { return _count; }
    }

    public void Add(int item) {}

    public void Remove(int item) {}

    public void RemoveAt(int index) {}

    public void Insert(int index, int item) {}

    public void Clear() {}

    public string ToString() 
    { 
        return string.Join(", ", _array); 
    }
}