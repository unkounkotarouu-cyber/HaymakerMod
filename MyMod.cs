name: Build MelonMod
on: [push]

jobs:
  build:
    runs-on: windows-latest
    steps:
    - uses: actions/checkout@v4
    - name: Setup .NET
      uses: microsoft/setup-dotnet@v4
      with:
        dotnet-version: 6.0.x
    - name: Build
      run: |
        dotnet new classlib -n TempProject
        cd TempProject
        dotnet add package MelonLoader --version 0.6.1
        copy ../MyMod.cs ./Class1.cs
        dotnet build --configuration Release
    - name: Upload
      uses: actions/upload-artifact@v4
      with:
        name: MyCompiledMod
        path: TempProject/bin/Release/net6.0/*.dll
