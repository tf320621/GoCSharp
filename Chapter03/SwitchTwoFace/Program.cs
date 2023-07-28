using static System.Console;
using System.IO;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// part one
// 普通switch写法
string path = "/Users/mac/Project/CodeProject/C#入门经典/Code/Chapter03";
WriteLine("Press R for readonly or W for write:");

ConsoleKeyInfo key = ReadKey();
WriteLine();

Stream s = null;
if(key.Key == ConsoleKey.R){
    // 读或者写权限
    s = File.Open(Path.Combine(path,"file.txt"),FileMode.OpenOrCreate,FileAccess.Read);
}else{
    s = File.Open(Path.Combine(path,"file.txt"),FileMode.OpenOrCreate,FileAccess.Write);
}

string message = string.Empty;
switch (s)
{
    case FileStream writeableFile when s.CanWrite:
    message = $"writeableFile:{writeableFile}这个是干嘛用的呢？";
    break;
    case FileStream readOnlyFile:
    message = $"这个意思是s的状态和FileStream的状态是一样的吗？";
    break;
    case MemoryStream ms:
    message = "这个又是什么意思呀，memoryStream";
    break;
    default:
    message = "默认情况是啥呢";
    break;
    case null:
    message = "在default之后还是可以匹配的吗，奇怪了";
    break;
}

WriteLine(message);