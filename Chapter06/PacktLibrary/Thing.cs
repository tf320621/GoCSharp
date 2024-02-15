using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Packt.Shared;

public class Thing
{
    public object Data = default(object);

    public string Process(object input){
        if (Data == input)
        {
            return "相同";
        }else{
            return "不同";
        }
    }
}
