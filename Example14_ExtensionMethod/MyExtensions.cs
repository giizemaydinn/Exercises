using System.Collections;
using System.Reflection;

namespace Example14
{
    public static class MyExtensions
    {
        public static void DisplayAssemblyInfo(this object obj)//obje bütün tipleri de kapsadığından hepsinde geçerlidir.
        {
            Console.WriteLine("Object Type: {0}, Assembly: \n",
                obj.GetType().Name,
                Assembly.GetAssembly(obj.GetType()).GetName().Name);
        }

        public static int Square(this int i)
        {
            return i * i;
        }

        public static void ShowItems(this IEnumerable iterator)
        {
            foreach (var item in iterator)
            {
                Console.WriteLine(item);
            }
        }

        //public static void ShowProp(this Class1)
        //{

        //}
    }
}
