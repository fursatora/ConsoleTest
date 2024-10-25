internal class Program
{
    private static void Main(string[] args)
    {
       MyList<int> myList = new MyList<int>();
        myList.Add(0);
        myList.Add(1);
        myList.Add(2);
        myList.Add(3);
        myList.Add(4);
        myList.Add(6);


        myList.Insert(2, -1);
        myList.Remove(2);
        myList.RemoveAt(4);
        myList.Sort();
        int found_element = myList.Find(x => x % 2 == 0);


        Console.WriteLine(myList.ToString());
        Console.WriteLine(found_element);

    }
}