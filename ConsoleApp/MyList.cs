public class MyList<T> where T : IComparable<T>
{
    private T[] _array = new T[4];
    private int _count = 0;
    
    public int Count 
    {
        get { return _count; }
    }

    public void Add(T item) 
    {
        if (_count >= _array.Length)
        {
            T[] _new_array = new T[_array.Length * 2];
            for (int i = 0; i < _array.Length; i++)
            {
                _new_array[i] = _array[i];
            }
            _array = _new_array;
        }

        _array[_count] = item;
        _count++;  
    }

    public void Remove(T item) 
    {
        int _remove_index = -1;

        for (int i = 0; i < _count; i++)
        {
            if (_array[i].Equals(item))
            {
                _remove_index = i;
                break;  
            }
        }

        if (_remove_index == -1)
        {
            return;
        }

        for (int i = _remove_index; i < _count - 1; i++)
        {
            _array[i] = _array[i + 1];
        }

        _count--;
    }

    public void RemoveAt(int index)
    {
        if (index < 0 || index >= _count)
        {
            Console.WriteLine("Ошибка введения индекса");
            return;
        }

        for (int i = index; i < _count - 1; i++)
        {
            _array[i] = _array[i + 1];
        }

        _count--;
    }

    public void Insert(int index, T item)
    {
        if (index < 0 || index > _count)
        {
            Console.WriteLine("Ошибка введения индекса");
            return;
        }

        if (_count >= _array.Length)
        {
            T[] _new_array = new T[_array.Length * 2];
            for (int i = 0; i < _array.Length; i++)
            {
                _new_array[i] = _array[i];
            }
            _array = _new_array;
        }

        for (int i = _count; i > index; i--)
        {
            _array[i] = _array[i - 1];
        }

        _array[index] = item;
        _count++;
    }

    public void Clear() 
    {
        _count = 0;
        _array = new T[4]; 
    }

    public void ForEach(Action<T> action) 
    { 
        for (int i = 0; i < _count; i++) 
        { 
            action(_array[i]); 
        } 
    }

    public int IndexOf(T item) 
    { 
        for (int i = 0; i < _count; i++) 
        { 
            if (_array[i].Equals(item)) 
            { 
                return i;
            }
        }
        return -1;
    } 

    public T Find(Predicate<T> match)
    {
        T foundItem = default; 
        bool itemFound = false; 

        ForEach(item => 
        {
            if (match(item))
            {
                foundItem = item; 
                itemFound = true; 
            }
        });

        if (itemFound)
        {
            return foundItem; 
        }

        Console.WriteLine("значение не найдено");
        return default(T); 
    }

public void Sort()
{
    for (int i = 0; i < _count - 1; i++)
    {
        for (int j = 0; j < _count - 1 - i; j++)
        {
            if (_array[j].CompareTo(_array[j + 1]) > 0)
            {
                T _temp = _array[j];
                _array[j] = _array[j + 1];
                _array[j + 1] = _temp;
            }
        }
    }
}


    public override string ToString() 
    { 
        T[] tempArray = new T[_count];
        Array.Copy(_array, tempArray, _count);
        return string.Join(", ", tempArray);
    }


}