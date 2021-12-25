using safe_code_demo.Exceptions;
using safe_code_demo.Extensions;
using Xunit;

namespace safe_code_demo_tests;

public class UnitTests
{
    [Theory]
    [InlineData("w;r;t",true)]
    [InlineData("w;r;11111111111",false)]
    [InlineData("23;r;11111111111",true)]
    [InlineData("abc;45t;11111111111",true)]
    [InlineData("25;45;11111111111",true)]
    public void InputTests(string line,bool shouldFail)
    {
        if(shouldFail)
            Assert.Throws<InvalidInputException>(line.ValidateInput);
        else
            Assert.Equal(line.ValidateInput(),line);
    }

    [Theory]
    [InlineData("w,r,t",true)]
    [InlineData("w r,11111111111",false)]
    [InlineData("23 r,11111111111",true)]
    [InlineData("abc 45t,11111111111",true)]
    [InlineData("25 45,11111111111",true)]
    public void OutputTests(string csvLine,bool shouldFail)
    {
        if(shouldFail)
            Assert.Throws<InvalidOutputException>(csvLine.ValidateOutput);
        else
            Assert.Equal(csvLine.ValidateOutput(),csvLine);
    }
}