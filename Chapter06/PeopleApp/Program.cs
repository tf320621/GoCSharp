using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Packt.Shared;
using PacktLibrary;
using static System.Console;


// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// 创建三个person对象
var harry = new Person{Name = "Harry"};
var mary = new Person{Name = "Mary"};
var jill = new Person{Name = "Jill"};

var baby1 = mary.ProcreateWith(harry);
baby1.Name = "Gary";

var baby2 = Person.Procreate(harry,jill);

WriteLine($"{harry.Name} has {harry.Children.Count} children.{JsonConvert.SerializeObject(harry)}");
WriteLine($"{mary.Name} has {mary.Children.Count} children.{JsonConvert.SerializeObject(mary)}");
WriteLine($"{jill.Name} has {jill.Children.Count} children.{JsonConvert.SerializeObject(jill)}");

WriteLine($"{baby1.Name} has {baby1.Children.Count} children.{JsonConvert.SerializeObject(baby1)}");
WriteLine($"{baby2.Name} has {baby2.Children.Count} children.{JsonConvert.SerializeObject(baby2)}");

var baby3 = harry*mary;
WriteLine($"baby3:{JsonConvert.SerializeObject(baby3)}");

var fact =  Person.Factorial(10);

// private static void Harry_Short(object sender,EventArgs e){
//     Person p = (Person)sender;

//     WriteLine($"{p.Name} this angry {p.MyProperty}");
// }

// 测试范型
var t1 = new Thing();
t1.Data = 42;
WriteLine($"t1结果：{t1.Process("42")}");

var t2 = new Thing();
t2.Data = "apple";
WriteLine($"t2结果：{t2.Process("apple")}");

// 因为数字存储的地方不一样，所以推断的结果不一样。

// 使用范型解决上面的问题，泛型
var t3 = new GenericThing<int>();
t3.Data = 42;
WriteLine($"t3结果：{t3.Process(42)}");

var t4 = new GenericThing<string>();
t4.Data = "apple";
WriteLine($"t4结果：{t4.Process("apple")}");

// 泛型做平方计算
string number = "4";
WriteLine("{0}squared is {1}",arg0:number,arg1:Square.Squarer<string>(number));