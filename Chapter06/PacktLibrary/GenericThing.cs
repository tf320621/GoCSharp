using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PacktLibrary;

public class GenericThing<T> where T:IComparable
{
    public T Data = default(T);

    public string Process(T input){
        if (Data.CompareTo(input) == 0)
        {
            return "相同";
        }else
        {
            return "不同";
        }
    }
}
