using System;
using PacktLibrary;
namespace Packt.Shared;

public class Person:Object
{
    public string Name { get; set; } = "";

    public DateTime Birthday { get; set; }

    public WondersOfTheAncientWorld wondersOfTheAncientWorld { get; set; }

    /// <summary>
    /// 多个枚举选项
    /// </summary>
    /// <value></value>
    public WondersOfTheAncientWorld BucketList { get; set; }

    /// <summary>
    /// 参数，ref参数，out参数
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <param name="z"></param>
    public void PassingParameters(int x,ref int y,out int z){
        z= 99;

        x++;
        y++;
        z++;
    }
}
