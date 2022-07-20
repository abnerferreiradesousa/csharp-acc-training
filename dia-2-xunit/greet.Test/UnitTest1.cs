
// using Xunit;
using FluentAssertions;

namespace greet.Test;
public class UnitTest1
{
    [Theory(DisplayName = "Deve retornar um \"Olá\"")]
    [InlineData("Olá")]
    public void TestGreet(string expected)
    {
        var result = Class1.Greet();
        result.Should().Be(expected);
        result.Should().StartWith("O").And.EndWith("á").And.Contain("l").And.HaveLength(3);
        
    }
}