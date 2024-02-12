namespace CalculatorLibUnitTTests;
//using Packt;
using Xunit;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        double a = 2;
        double b = 2;
        double eexpected = 4;
        var calc = new Calculator();

        double actual = calc.Add(a,b);

        Assert.Equal(eexpected,actual);

    }
}