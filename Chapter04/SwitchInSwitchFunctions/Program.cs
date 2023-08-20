using static System.Console;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// 编写switch嵌套switch

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

bool isNumber;
do
{
    isNumber = int.TryParse(ReadLine(),out int numb);
    if (isNumber)
    {
       var ret =  CardinalToOrdinal(numb);
       WriteLine(ret);
    }else{
        WriteLine("hehe");
    }
} while (isNumber);