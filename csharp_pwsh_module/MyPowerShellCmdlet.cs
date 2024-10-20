using System.Management.Automation;

namespace csharp_pwsh_module;

[Cmdlet(VerbsCommon.Get, "Hello")]
public class MyPowerShellCmdlet : Cmdlet
{
    protected override void ProcessRecord()
    {
        WriteObject("Hello, C# Cmdlet!");
    }
}
