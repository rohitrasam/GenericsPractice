using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Comparator<T>
    {

        public string Compare(T value1, T value2)
        {
            if (value1.Equals(value2))
            {
                return "Both the values are equal";
            }
            return "Values are not equal";
        }
    }
}
