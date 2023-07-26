using static System.Console;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// 循环控制，不要省略大括号，除了没有优点，其他的都是缺点
if (args.Length == 0)
{
    WriteLine("shuai");
}else
{
    WriteLine("henshuai");
}

// 可以对object类型进行判定，做出指定的类型处理
object a = "10";
object b = "10";

int c = 2;
if (a is int aa)
{
    WriteLine($"是int类型:{aa*c}");
}else if(b is string)
{
    WriteLine(b);
}else
{
    WriteLine("此种方法位模糊匹配！");
}
