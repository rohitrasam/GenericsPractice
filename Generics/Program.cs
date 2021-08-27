using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Comparator<int> comparator = new Comparator<int>();
            string result = comparator.Compare(1, 2);

            GenericList<string> list = new GenericList<string>();
            list.Add("Rohit");
            Console.WriteLine(result);
        }
    }
}
