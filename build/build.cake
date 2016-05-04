var	solutionToBuild = "../Diagnostics.sln";
var testProjects = GetFiles("../test/**/*.csproj");
var projectsToPackage = GetFiles("../src/**/*.csproj");

#load "../../Commontools/AethonsTools.CakeBuild/tools/AethonsTools.cake"
