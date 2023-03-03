class Program
{
    /// <summary>
    /// Generic classes.
    /// </summary>
    /// <param name="args"></param>
    public static void Main(string[] args)
    {
        MyList<string> list = new MyList<string>();
        list.Add("Gizem");
        list.Add("Aydın");

        Console.WriteLine(list.Get().GetType());
    }
}

class MyList<T>
{
    public List<T> list = new List<T>();
    public void Add(T t)
    {
        list.Add(t);
    }

    public T Get()
    {
        return list[0];
    }

    
}