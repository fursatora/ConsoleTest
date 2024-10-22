
public class MyList
{
    private int[] _array = new int[4];
    private int _count = 0;

    public int Count 
    {
        get { return _count; }
    }

    public void Add(int item) 
    {
         if (_count >= _array.Length)
        {
            int[] _new_array = new int[_array.Length + 1];
            
            for (int i = 0; i < _array.Length; i++)
            {
                _new_array[i] = _array[i];
            }
            _array = _new_array;
        }

        _array[_count] = item;
        _count++;  
    }

    public void Remove(int item) {
        int _remove_index = -1;

        for (int i = 0; i < _count; i++)
        {
            if (_array[i] == item)
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

        

        int[] _new_array = new int[_array.Length - 1];
        for (int i = 0; i < _new_array.Length; i++)
        {
            _new_array[i] = _array[i];
        }

        _array = _new_array;
        
    }
        

    public void RemoveAt(int index)
    {
        if (index<0 || index>_array.Length-1)
        {
            Console.WriteLine("Ошибка введения индекса");
            return;
        }
       
        for (int i = index; i < _count - 1; i++)
        {
            _array[i] = _array[i + 1];
        }

        int[] _new_array = new int[_array.Length - 1];
        for (int i = 0; i < _new_array.Length; i++)
        {
            _new_array[i] = _array[i];
        }

        _array = _new_array;
        _count--;

    }

    public void Insert(int index, int item)
    {   if (index<0 || index>_array.Length)
        {
            Console.WriteLine("Ошибка введения индекса");
            return;
        }

        if (index==_array.Length){
            Add(item);
            return;
        }
        if (index<_array.Length)
        {
            int[] _new_array = new int[_array.Length + 1];
            for (int i=0; i<index; i++)
            {
                _new_array[i]=_array[i];
            }

            _count++;
            _new_array[index]=item;

            for (int i=index; i<_array.Length; i++)
            {
                _new_array[i+1]=_array[i];
            }

            _array = _new_array;
        }
    }


    public void Clear() {
        for (int i=0; i<_array.Length+1; i++){
            RemoveAt(i);
            _count--;
        }
        return;
    }

    public string ToString() 
    { 
        return string.Join(", ", _array); 
    }
}