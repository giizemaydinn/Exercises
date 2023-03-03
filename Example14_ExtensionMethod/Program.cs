using Example14;
using System.Collections;

class Program
{
    /// <summary>
    /// Extension Methods
    /// static olmak zorunda
    /// parametre olarak this almalı (parametre olarak verilenin extension'ıdır.
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        object obj = new object();
        obj.DisplayAssemblyInfo();

        int x = 3;
        Console.WriteLine(x.Square());

        ArrayList list = new ArrayList();
        list.Add("test1");
        list.Add("test2");
        list.ShowItems();

        Class1 c1 = new Class1();
        c1.DisplayAssemblyInfo();


    }
}