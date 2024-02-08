// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");



static double Add(double a, double b){
    return a + b;
}

double a = 4.5;
double b = 2.5;
double answer = Add(a, b);

Console.WriteLine($"{a}+{b}={answer}");

// 命令式和函数式的表达方式

static int FibImperative(int term){
    if (term == 1)
    {
        return 0;
    }
    else if (term == 2)
    {
        return 1;
    }else
    {
        return FibImperative(term -1) +FibImperative(term -2);
    }
}

static void RunFibImperative(){
    for (int i = 0; i < 30; i++)
    {
        Console.WriteLine("{0},{1:NO}",arg0:1,arg1:FibImperative(term:i));
    }
}