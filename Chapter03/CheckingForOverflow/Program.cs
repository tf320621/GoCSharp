using static System.Console;
using static System.Convert;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//检测溢出和不检测溢出
// checked
// {
//     int x = int.MaxValue-1;
//     Console.WriteLine($"Initial value:{x}");
//     x++;

//     Console.WriteLine($"After incrementing:{x}");
//     x++;

//     Console.WriteLine($"After incrementing:{x}");
//     x++;

//     Console.WriteLine($"After incrementing:{x}");
//     x++;
// }
//int z = int.MaxValue+1;

// unchecked
// {
//     int y = int.MaxValue+1;
// }

// for(;true;){

// }

for (int i = 1; i <= 100; i++)
{
    if (i%3==0 && i%5==0)
    {
        Console.Write("fizzbuzz,");
        continue;
    }
    if(i%3==0){
        Console.Write("fizz,");
        continue;
    }
    if (i%5 ==0)
    {
        Console.Write("buzz,");
        continue;
    }
    Console.Write(i+",");
}

string a = ReadLine();
string b = ReadLine();
