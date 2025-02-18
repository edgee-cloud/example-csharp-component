<div align="center">
<p align="center">
  <a href="https://www.edgee.cloud">
    <picture>
      <source media="(prefers-color-scheme: dark)" srcset="https://cdn.edgee.cloud/img/component-dark.svg">
      <img src="https://cdn.edgee.cloud/img/component.svg" height="100" alt="Edgee">
    </picture>
  </a>
</p>
</div>

<h1 align="center">Example dotnet component for Edgee</h1>

This is an example of a C# Edgee Component.

## Setup
Requirements:
- [edgee-cli](https://github.com/edgee-cloud/edgee)
- dotnet SDK 9.0
- Modify the csproj file to match your OS:
    - On Linux
```dotnet add package runtime.linux-x64.microsoft.dotnet.ilcompiler.llvm --prerelease```
    - On Windows
```dotnet add package runtime.win-x64.microsoft.dotnet.ilcompiler.llvm --prerelease```

## Building

```shell
$ make build
```
