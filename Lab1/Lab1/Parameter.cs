using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1;

public class Parameter<T>
    where T : struct
{
    public static T Multiplication (T first, T second)
    {
        dynamic f = first;
        dynamic s = second;
        return (T)  (f * s);
    }
}
