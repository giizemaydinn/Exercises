class Program
{
    /// <summary>
    /// Generic delegates.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="obj"></param>
    delegate void MyGenericDelegate<T>(T obj);
    static void Main(string[] args)
    {
        MyGenericDelegate<int> myGenericDelegate = IntT;
        myGenericDelegate(4);

        MyGenericDelegate<string> strDelegate = new MyGenericDelegate<string>(StringT);
        strDelegate("Gizem");
    }

    static void StringT(string s)
    {
        Console.WriteLine("arg: " + s);
    }

    static void IntT(int i)
    {
        Console.WriteLine("arg: " + i);
    }
}
