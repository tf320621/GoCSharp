using System;
using System.Threading;


// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


static void PrintNumbers(){
    Console.WriteLine("strating......");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}
}


Thread t = new Thread(PrintNumbers);
t.Strat():

PrintNumbers():