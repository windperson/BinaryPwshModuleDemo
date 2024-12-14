# Binary PowerShell Module Demo

This repository contains two demo projects:

1. **MinimalPwshModuleDemo**: Simplest PowerShell v7+ binary cmdlet.
2. **PwshStandardModule**: Binary cmdlet project that uses [PowerShell standard NuGet](https://www.nuget.org/packages/PowerShellStandard.Library/), so it can run both on PowerShell v7+ and Windows PowerShell 5.1.

Use pre-crafted launch.json to debug these two binary cmdlet, for detail step by step instruction, see: [Using Visual Studio Code to debug compiled cmdlets]((https://learn.microsoft.com/powershell/scripting/dev-cross-plat/vscode/using-vscode-for-debugging-compiled-cmdlets)

**Note:** the second debug entry in launch.json is for Windows only.