using FluentAssertions;
namespace rocket.Test;

public class UnitTest1
{
    [Fact]
    public void TestClassRocket()
    {
        var trybeRocket = new Rocket();
        trybeRocket.Should().NotBeNull();
        trybeRocket.Should().BeOfType<Rocket>();
    }
}