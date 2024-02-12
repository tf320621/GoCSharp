using ClassLibrary1;

namespace TestProject1;


public class UnitTest1
{
    [Fact]
    public void Test1()
    {

        // arrange
        double a = 2;
        double b = 2;
        double eexpected = 4;
        var calc = new Class1();

        // act
        double actual = calc.Add(a,b);

        // assert
        Assert.Equal(eexpected,actual);
    }
}