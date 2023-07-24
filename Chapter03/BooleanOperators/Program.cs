using static System.Console;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

bool a = true;
bool b = false;

WriteLine($"AND |a  |b");
WriteLine($"a   |{a&a,-5}   |   {a&b,-5}");
WriteLine($"b   |{b&a,-5}   |   {b&b,-5}");
WriteLine();
WriteLine($"OR  |a  |b");
WriteLine($"a   |{a|a,-5}   |   {a|b,-5}");
WriteLine($"b   |{b|a,-5}   |   {b|b,-5}");
WriteLine();
WriteLine($"XOR |a  |b");
WriteLine($"a   |{a^a,-5}   |   {a^b,-5}");
WriteLine($"b   |{b^a,-5}   |   {b^b,-5}");

static bool DoStuff(){
    WriteLine("i am dong 此方法！");
    return true;
}

static bool DoStuff2(){
    WriteLine("i am dong 此DoStuff2方法！");
    return false;
}

WriteLine($"短路测试：{a && DoStuff()}");
// 执行此句时不用管方法是否执行，b是false,判定时不用管后面是什么，肯定返回false。
// 即&&时会造成后的被短路，||时，前面为true，后面的也不需要判定，肯定返回true了。
WriteLine($"短路测试：{b && DoStuff()}");

WriteLine($"短路测试：{a||DoStuff2()}");
WriteLine($"短路测试：{b||DoStuff2()}");