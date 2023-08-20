using static System.Console;


// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// 静态方法
static void TimesTable(byte number){
    WriteLine($"1111111111");

    for (int i = 1; i < number; i++){
        WriteLine($"row:{i} * number{number} = {i*number}");
        
    }
}

static void RunTimesTable(){
    bool isNumber;
    do
    {
        Write("请输入0-255之间的数字");
        isNumber = byte.TryParse(ReadLine(),out byte number);

        if (isNumber)
        {
            TimesTable(number);
        }else{
            WriteLine("hehe");
        }
    } while (isNumber);
}

RunTimesTable();

