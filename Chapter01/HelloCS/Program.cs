﻿using System.Linq;
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

// 定义一些常见的变量
uint naturalNumber = 23;
int integerNumber = -23;
float realNumber = 2.3F;
double anotherRealNumber = 2.3D;

//测试常见的二进制，十六进制转换
int decimalNotation = 2_000_000;
int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
int hexadecimalNotation = 0x_001E_8480;

Console.WriteLine($"decimalNotation={decimalNotation},binaryNotation={binaryNotation},hexadecimalNotation={hexadecimalNotation}");

// 查看实数存储的空间
Console.WriteLine($"size{sizeof(int)},minValue{int.MinValue:N0},maxValue{int.MaxValue:N0}");

Console.WriteLine($"doubleSize内存:{sizeof(double)},decimal内存:{sizeof(decimal)}");

double c = 0.1;
double d = 0.2;
if(c+d == 0.3){
    Console.WriteLine("相同");
}else{
    Console.WriteLine("不同");
}

decimal e = 0.1m;
decimal f = 0.2m;
if(e+f == 0.3m){
    Console.WriteLine("相同");
}else{
    Console.WriteLine("不同");
}