using System;
using System.Collections.Generic;
using static System.Console;
namespace Packt.Shared;

public class Person
{
    // fields
    public string Name;

    public int MyProperty { get; set; }

    public DateTime DateofBirth;

    public List<Person> Children = new List<Person>();

    // methods
    public void WriteToConsole(){
        WriteLine($"{this.Name} was born on a {this.DateofBirth:dddd}.");
    }

    // 添加一个实例方法和一个静态方法

    /// <summary>
    /// 静态方法生孩子
    /// </summary>
    /// <param name="p1">父</param>
    /// <param name="p2">母</param>
    /// <returns></returns>
    public static Person Procreate(Person p1,Person p2){
        var baby = new Person{
            Name = $"Baby of {p1.Name}父亲 and {p2.Name}母亲"
        };

        p1.Children.Add(baby);
        p2.Children.Add(baby);

        return baby;
    }

    /// <summary>
    /// 添加一个方法
    /// 自己本身和传入的对象
    /// </summary>
    /// <param name="partnet">结婚的对象</param>
    /// <returns></returns>
    public Person ProcreateWith(Person partnet){
        return Procreate(this,partnet);
    }

    /// <summary>
    /// 自定义了个乘法运算
    /// 运算p1,p2两个对象
    /// </summary>
    /// <param name="p1"></param>
    /// <param name="p2"></param>
    /// <returns></returns> <summary>
    public static Person operator * (Person p1,Person p2){
        // 调用委托
        var d = new DelegateWithMatchingSignature(p1.MethodIWantToCall);

        int answer = d("test");

        p1.MyProperty = answer;

        return Procreate(p1,p2);
    }

    // method with a local function

    /// <summary>
    /// 局部函数实现功能
    /// 递归和局部函数
    /// 阶乘
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    public static int Factorial(int number){
        if (number < 0)
        {
            throw new ArgumentException($"{nameof(number)} cannot be less than zero.");
        }

        return LocalFactorial(number);

        int LocalFactorial(int number){
            if (number < 1) 
            {
                return 1;
            }

            return number * LocalFactorial(number - 1);
        }
    }

    /// <summary>
    /// 普通方法
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public int MethodIWantToCall(string input){
        return input.Length;
    }

    /// <summary>
    /// 定义了一个委托
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns> <summary>
    delegate int DelegateWithMatchingSignature(string s);

    // 使用微软自定义的委托
    public EventHandler Short;

    public void Poke(){
        MyProperty++;
        if (MyProperty >= 3)
        {
            // if (Short != null)
            // {
            //     Short(this,EventArgs.Empty);
            // }

            Short?.Invoke(this,EventArgs.Empty);
        }
    }

    
}
