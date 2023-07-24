using static System.Console;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//++a 和 a++区别
int a = 3;
int b = a++;

int c = 3;
int d = ++c;
//a=4,b=3,c=4,d=4
WriteLine($"a={a},b={b},c={c},d={d}");

// 二元运算符
int e = 11;
int f = 3;
WriteLine($"e+f:{e + f},e-f:{e - f},e*f:{e * f},e/f:{e / f},e%f:{e % f}");

double g = 11.0D;
WriteLine($"g/f:{g / f}");

// e+f:14,e-f:8,e*f:33,e/f:3,e%f:2
// g/f:3.6666666666666665
// 如果第一个操作数是浮点数，比如变量g，是11.0，那么除法运算符也将返回一个浮点数，而不是一个整数
