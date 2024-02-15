using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PacktLibrary;

public static class Square
{
    public static double Squarer<T>(T input) where T :IConvertible{
        double d = input.ToDouble(Thread.CurrentThread.CurrentCulture);

        return d* d;
    }
}
