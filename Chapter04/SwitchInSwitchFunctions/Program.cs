using static System.Console;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// 编写switch嵌套switch

/// <summary>
/// 用来接受一个数字，该数字如果是11，12，13则特殊处理，
/// 如果是其他数字，则取余数，然后再添上后缀
/// 方法的目的是使用两个switch进行嵌套，类似于if里面嵌套if的功能
/// 最上面的switch先做小的处理，外面的再做大的处理
/// 本质是没有if里面嵌套if便于理解
/// </summary>
/// <param name="number">123</param>
/// <returns></returns>
static string CardinalToOrdinal(int number){
    switch (number)
    {
        case 11:
        case 12:
        case 13:
        return $"{number}th";
        default:
        int lastDigit = number%10;
        string suffix = lastDigit switch{
            1=>"st",
            2=>"nd",
            3=>"rd",
            _=>"th"
        };
        return $"{number}{suffix}";
    }
}

Console.WriteLine("Hello, World222222222!");

bool isNumber;
do
{
    isNumber = int.TryParse(ReadLine(),out int numb);
    if (isNumber)
    {
        var ret = CardinalToOrdinal(numb);
        //_ = CardinalToOrdinal(numb);
       WriteLine(ret);
    }else{
        WriteLine("hehe");
    }
} while (isNumber);