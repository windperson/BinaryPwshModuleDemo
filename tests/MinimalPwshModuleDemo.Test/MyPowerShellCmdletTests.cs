namespace MinimalPwshModuleDemo.Test;

public class MyPowerShellCmdletTests
{
    [Fact]
    public void ProcessRecord_ShouldWriteHelloMessage()
    {
        // Arrange
        var cmdlet = new MyPowerShellCmdlet();

        // Act
        var output = cmdlet.Invoke().OfType<string>().ToList();

        // Assert
        Assert.Single(output);
        Assert.Equal("Hello, C# Cmdlet!", output[0]);
    }
}