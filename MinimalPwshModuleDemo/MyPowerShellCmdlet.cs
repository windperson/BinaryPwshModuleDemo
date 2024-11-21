using System.Management.Automation;

namespace MinimalPwshModuleDemo;

[Cmdlet(VerbsCommon.Get, "Hello")]
public class MyPowerShellCmdlet : Cmdlet
{
    protected override void ProcessRecord()
    {
        WriteObject("Hello, C# Cmdlet!");
    }
}
