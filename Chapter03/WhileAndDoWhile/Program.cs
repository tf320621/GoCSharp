using static System.Console;
using static System.Convert;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// while
int i = 10;
while(i> 1){
    WriteLine($"执行{i}次");

    i--;
}

// dowhile
// int count = 10;
// string pa = string.Empty;
// do
// {
//     WriteLine($"第{count}次输入密码");
//     pa = ReadLine();
// } while (pa == "111");

double g = 9.8;
int h = ToInt32(g);
WriteLine($"g:{g},h:{h}");

// C# 特有圆整，银行家圆整法
double [] doubles = new[]{9.49,9.5,9.51,10.49,10.5,10.51};
foreach (var item in doubles)
{
    WriteLine($"ToInt({item} is {ToInt32(item)})");
}

// 改变圆整策略，变成普通圆整法。
foreach (var item in doubles)
{
    WriteLine(format:
     "Math.Round({0},0,MidpointRounding.AwayFromZero) is {1}",
     arg0:item,
     arg1:Math.Round(value:item,digits:0,mode:MidpointRounding.AwayFromZero)
    );
}

// Math.Round(9.49,0,MidpointRounding.AwayFromZero) is 9
// Math.Round(9.5,0,MidpointRounding.AwayFromZero) is 10
// Math.Round(9.51,0,MidpointRounding.AwayFromZero) is 10
// Math.Round(10.49,0,MidpointRounding.AwayFromZero) is 10
// Math.Round(10.5,0,MidpointRounding.AwayFromZero) is 11
// Math.Round(10.51,0,MidpointRounding.AwayFromZero) is 11
