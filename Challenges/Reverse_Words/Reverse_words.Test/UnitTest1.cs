using System;
using Xunit;
using Reverse_Words;



public class UnitTest1
{
    [Fact]
    public void Case1()
    {

        string input = "csharp is programming language";
        string output = "language programming is csharp";

        var result = Program.ReversWord(input);

        Assert.Equal(output, result);


    }
    [Fact]
    public void Case2()
    {
        string input = "Reverse the words in this sentence";
        string output = "sentence this in words the Reverse";

         var result = Program.ReversWord(input);

        Assert.Equal(output, result);
    }
     [Fact]
    public void Case3()
    {
        string input = "challenges and data structures";
        string output = "structures data and challenges";

        var result = Program.ReversWord(input);

        Assert.Equal(output, result);
    }
}