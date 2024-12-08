using System.Management.Automation;
using System.Management.Automation.Runspaces;

namespace PwshStandardModule.Test;

public class TestSampleCmdletTests : IDisposable
{
    private Runspace _runspace;

    public TestSampleCmdletTests()
    {
       _runspace = InitRunspace();
    }

    private Runspace InitRunspace()
    {
        var initialSessionState = InitialSessionState.CreateDefault();
        initialSessionState.Commands.Add(new SessionStateCmdletEntry("Test-SampleCmdlet", typeof(TestSampleCmdlet),
            null));

        var runspace = RunspaceFactory.CreateRunspace(initialSessionState);
        runspace.Open();
        return runspace;
    }
    
    [Fact]
    public void ProcessRecord_ShouldWriteFavoriteStuff()
    {
        // Arrange
        using var powershell = PowerShell.Create(_runspace);
        var cmd = new Command("Test-SampleCmdlet");
        cmd.Parameters.Add("FavoriteNumber", 42);
        cmd.Parameters.Add("FavoritePet", "Cat");
        powershell.Commands.AddCommand(cmd);

        // Act
        var result = powershell.Invoke<FavoriteStuff>()[0];

        // Assert
        Assert.IsType<FavoriteStuff>(result);
        Assert.Equal(42, result.FavoriteNumber);
        Assert.Equal("Cat", result.FavoritePet);
    }

    public void Dispose()
    {
        _runspace.Close();
        _runspace.Dispose();
        GC.SuppressFinalize(this);
    }
}