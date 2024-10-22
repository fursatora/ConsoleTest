internal class Program
{
    private static void Main(string[] args)
    {
        MyList myList= new MyList();
        myList.Add(0);
        myList.Add(1);
        myList.Add(2);
        myList.Add(3);
        myList.Add(4);

        myList.Insert(0, -1);
        myList.Remove(2);
        myList.RemoveAt(4);
        //myList.Clear();
        
        Console.WriteLine(myList.ToString());
    }
}