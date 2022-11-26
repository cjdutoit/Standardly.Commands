<p align="center">
  <img src="https://github.com/cjdutoit/Standardly.Commands/blob/main/Resources/Banner.png?raw=true">
</p>

[![.NET](https://github.com/cjdutoit/Standardly.Commands/actions/workflows/build.yml/badge.svg)](https://github.com/cjdutoit/Standardly.Commands/actions/workflows/build.yml)
[![Nuget](https://img.shields.io/nuget/v/Standardly.Commands)](https://www.nuget.org/packages/Standardly.Commands)
[![The Standard - COMPLIANT](https://img.shields.io/badge/The_Standard-COMPLIANT-2ea44f)](https://github.com/hassanhabib/The-Standard)
# Standardly.Commands
Standardly.Commands is a small .Net library designed to provide a command execution engine that .Net developers can use to run CLI commands sequentially.

# How It Works

You setup the client and then you can either pass in a single command OR a list of commands to the `ExecuteCommand` method. The output from the CLI commands is collated and returned on completion for logging or presentation.


```cs
    string command = "echo Hello World!";

    using (CommandClient commandClient = new CommandClient("cmd.exe"))
    {
        string result = commandClient.ExecuteCommand(command);
    }
```
**OR**

```cs
    List<string> commands = 
        new List<string>
        {
            "echo Hello World!"
        };

    using (CommandClient commandClient = new CommandClient("cmd.exe"))
    {
        string result = commandClient.ExecuteCommand(commands);
    }
```
