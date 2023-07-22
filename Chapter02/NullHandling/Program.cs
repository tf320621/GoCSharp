#nullable disable
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int a = 4;
//thisCannotBeNull = null;

int? thisCouldBeNull = null;

Console.WriteLine(thisCouldBeNull);
Console.WriteLine(thisCouldBeNull.GetValueOrDefault());

thisCouldBeNull = 7;
Console.WriteLine(thisCouldBeNull);
Console.WriteLine(thisCouldBeNull.GetValueOrDefault());

// 判定空值或处理
string anotherName = null;
int x = anotherName.Length;
int? y = anotherName?.Length;

var z = anotherName ?? "3";
