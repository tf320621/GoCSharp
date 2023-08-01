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