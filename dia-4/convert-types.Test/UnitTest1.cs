using FluentAssertions;
namespace convert_types.Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Class1 instance = new();
        var response = instance.someString is string;
        response.Should().Be(true);
    }
    [Fact]
    public void TestVariableConversion()
    {
        Class1 instance = new();

        instance.intEntry.Should().Be(42);
        var intTypeCheck = instance.intEntry is int;
        intTypeCheck.Should().Be(true);

        instance.Transform();

        instance.doubleResponse.Should().Be(42.0);
        var floatTypeCheck = instance.doubleResponse is double;
        floatTypeCheck.Should().Be(true);
    }
    [Theory(DisplayName = "Testa se converte o tipo int pra string")]
    [InlineData("42", 42)]
    [InlineData("235", 235)]
    [InlineData("57", 57)]
        public void TestVariableConversionToInt(string entry, int expected)
    {
        Class1 instance = new();

        instance.strEntry = entry;
        var strgTypeCheck = instance.strEntry is string;
        strgTypeCheck.Should().Be(true);

        instance.DoConversion();

        instance.intResponse.Should().Be(expected);
        var intTypeCheck = instance.intResponse is int;
        intTypeCheck.Should().Be(true);
    }

    
}