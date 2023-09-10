using SmartTestAutomation.Core.Helpers;
using SmartTestAutomation.Core.Interfaces;
using SmartTestAutomation.Steps.Core;
using System.Reflection.PortableExecutable;
using SmartTestAutomation.Steps;

namespace SmartTestAutomation.Core.Implementations
{
    public class SmartTestService : ISmartTestService
    {
        public  string StartTheProcess(string inputFile, string projectName, string workingDir)
        {
            workingDir = CreateProject(projectName, workingDir);

            InstallPackages(workingDir);

            CreateFeatures(inputFile, workingDir, projectName);

            BuildTheProjectAndOpentheProject(workingDir);
            return workingDir;
        }
        static string CreateProject(string projectName, string workingDir)
        {
            var command = $"mkdir {projectName}";

            CommandHelpers.RunCommand(command, workingDir);

            workingDir += $@"\{projectName}\";

            CommandHelpers.RunCommand($"dotnet new console -n {projectName}", workingDir);


            workingDir += $@"{projectName}\";
            return workingDir;
        }

        static void InstallPackages(string workingDir)
        {
            CommandHelpers.RunCommand("dotnet add package SpecFlow", workingDir);

            CommandHelpers.RunCommand("dotnet add package SpecFlow.Tools.MsBuild.Generation", workingDir);

            CommandHelpers.RunCommand("dotnet add package Microsoft.NET.Test.Sdk", workingDir);

            CommandHelpers.RunCommand("dotnet add package NUnit", workingDir);

            CommandHelpers.RunCommand("dotnet add package NUnit3TestAdapter", workingDir);

            CommandHelpers.RunCommand("dotnet add package Selenium.WebDriver", workingDir);

            CommandHelpers.RunCommand("dotnet add package Selenium.Support", workingDir);
        }

        static void CreateFeatures(string inputFilePath, string workingDir,string projectName)
        {
            CommandHelpers.RunCommand("mkdir Features", workingDir);

            var lines = FileHelpers.ReadTestCases(inputFilePath);
            var destinationfolder = $"{workingDir}Features";

            FileHelpers.CreateFeatures(lines, destinationfolder);

            CommandHelpers.RunCommand("mkdir StepDefinitions", workingDir);

            FileHelpers.CreateStepDefinitions(lines, destinationfolder, projectName);

        }

        static void BuildTheProjectAndOpentheProject(string workingDir)
        {
            CommandHelpers.RunCommand("dotnet msbuild", workingDir);

            CommandHelpers.RunCommand("start .", workingDir);
        }
        
    }
}
