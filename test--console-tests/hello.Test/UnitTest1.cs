using Xunit;
using FluentAssertions;
using xpt;
using System;
using System.IO;

namespace xpt.test;

public class TestSayMeHello
{
    [Theory]
    [InlineData("Rahel", "Hey, Hello Rahel")]
    [InlineData("Marina", "Hey, Hello Marina")]
    [InlineData("Luiz", "Hey, Hello Luiz")]
    [InlineData("Arthur", "Hey, Hello Arthur")]
    [InlineData("Livia", "Hey, hello Livia")]
    public void TestHello(string entry, string expected)
    {
        using(var stringWriter = new StringWriter())        //1
        {     
            Console.SetOut(stringWriter);                    //2
            SayMeHello.Hello(entry);                         //3

            var response = stringWriter.ToString().Trim();   //4
            response.Should().Be(expected);                  //5                                              
        }

    }
}