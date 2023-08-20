using static System.Console;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int a = 10; //0000 1010
int b = 6; // 0000 0110
WriteLine($"a&b:{a&b}");
WriteLine($"a|b:{a|b}");
WriteLine($"a^b:{a^b}");

WriteLine($"a<<3:{a<<3}");
WriteLine($"a*8:{a*8}");
WriteLine($"b>>1:{b>>1}");


// a&b:2
// a|b:14
// a^b:12
// a<<3:80
// a*8:80
// b>>1:3