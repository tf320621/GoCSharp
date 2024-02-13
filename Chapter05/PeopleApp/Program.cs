using Newtonsoft.Json;
using Packt.Shared;
using PacktLibrary;
using static System.Console;


// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
var perSon = new Person();
perSon.Name = "张三";
perSon.Birthday = new DateTime(1965, 12, 22);
perSon.wondersOfTheAncientWorld = WondersOfTheAncientWorld.name1;
perSon.BucketList = WondersOfTheAncientWorld.name2|WondersOfTheAncientWorld.name3;

WriteLine(perSon.ToString());
WriteLine(JsonConvert.SerializeObject(perSon));
WriteLine(format: $@"{perSon.Name}was bron on 
{perSon.Birthday:dddd,d MMMM yyyy},
name{perSon.wondersOfTheAncientWorld},
intName{(int)perSon.wondersOfTheAncientWorld},backlist{perSon.BucketList}");

int a= 10;
int b = 20;
int c = 30;

perSon.PassingParameters(a,ref b,out c);
WriteLine($"a:{a}-b:{b}-c:{c}");