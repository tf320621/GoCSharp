using System.Linq;
using System.Reflection;
using System.Xml;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, C#!");

//#error version
double z = 23.4;
Console.WriteLine("Temperature on {0:D} is {1}度",DateTime.Today,z);



// 查看当前多少个类型
foreach (var r in Assembly.GetEntryAssembly().GetReferencedAssemblies()){

System.Data.DataSet ds;

    var a = Assembly.Load(new AssemblyName(r.FullName));

    // 方法的数量
    int methodCount =0;

    foreach(var t in a.DefinedTypes){
        methodCount += t.GetMethods().Count();
    }

    Console.WriteLine(
        "{0:N0} types with {1:N0} methods in {2} assembly.",
        arg0:a.DefinedTypes.Count(),
        arg1:methodCount,
        arg2:r.Name
    );
}