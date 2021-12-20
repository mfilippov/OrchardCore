using Xunit;
using Xunit.Abstractions;

namespace OrchardCore.Tests.Demo;

public class DemoTest
{
    private const string TEST_CONST = "My const";
    private readonly ITestOutputHelper _testOutputHelper;

    public DemoTest(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void Test1()
    {
        Assert.True(true);
    }

    [Fact]
    public void Test5()
    {
        Assert.True(true);
    }

    [Fact]
    public void Test2()
    {
        Assert.True(true);
    }

    [Fact]
    public void Test3()
    {
        Assert.True(true);
    }

    [Fact]
    public void Test6()
    {
        Assert.True(true);
    }

    [Fact]
    public void Test7()
    {
        Assert.True(true);
    }

    [Fact]
    public void Test8()
    {
        _testOutputHelper.WriteLine(TEST_CONST);
        Assert.True(true);
    }
}
