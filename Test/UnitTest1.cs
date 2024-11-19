namespace codecoveragetest;

public class UnitTest1
{
    
    [Fact]
    public void Test1()
    {
        var test1 = Class1.car("test");
        Assert.Equal("test", test1);
    }
    
    [Fact]
    public void Test2()
    {
        var test1 = Class1.car("test3");
        Assert.Equal("test3", test1);
    }
}