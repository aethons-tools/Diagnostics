var	solutionToBuild = "../Diagnostics.sln";
var testProjects = GetFiles("../test/**/*.csproj");
var projectsToPackage = GetFiles("../src/**/*.csproj");

#load "AethonsTools.cake"
