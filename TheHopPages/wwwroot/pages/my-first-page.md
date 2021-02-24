# .NET CLI

### Creating new projects
```sh
$ dotnet new <type>
```
Possible Types: 
| Type | Description |
| ------ | ------ |
| classlib | .NET Core Class Library |
| webapi | .NET Core Web API |
| xunit | XUnit Test Project |
| gitignore | C#.NET specific gitignore file |

### Solutions and projects
Create a solution file
```sh
$ dotnet new sln --name NameOfSolution
```
Add projects to a solution
```sh
$ dotnet sln NameOfSolution.sln add ./Path/To/ProjectName
```
Add a project as reference to another project
```sh
$ dotnet add path/to/web-app.csproj reference path/to/class-library.csproj
```

### (NuGet) Packages
Add a NuGet package to a project
```sh
$ dotnet add package Name.Of.Package --version 1.2.3
```

### Building projects
Restore the projects dependencies
```sh
$ dotnet restore
```

Build the project
```sh
$ dotnet build
```
