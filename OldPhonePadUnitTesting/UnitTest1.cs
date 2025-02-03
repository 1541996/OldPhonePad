using System;
using Xunit;

public class OldPhonePadTests
{
    [Fact]
    public void ShouldReturnCorrectText_WhenValidInputIsProvided()
    {
        // Arrange
        var input1 = "33#";
        var input2 = "227*#";
        var input3 = "4433555 555666#";
        var input4 = "8 88777444666*664#";

        // Act
        var result1 = Phone.OldPhonePad(input1);
        var result2 = Phone.OldPhonePad(input2);
        var result3 = Phone.OldPhonePad(input3);
        var result4 = Phone.OldPhonePad(input4);

        // Assert
        Assert.Equal("E", result1);
        Assert.Equal("B", result2);
        Assert.Equal("HELLO", result3);
        Assert.Equal("TURING", result4);
    }

    [Fact]
    public void ShouldHandleEdgeCases_WhenInputIsEmpty()
    {
        // Arrange
        var input = "";

        // Act
        var result = Phone.OldPhonePad(input);

        // Assert
        Assert.Equal("", result); // Should return empty string for empty input
    }

}
