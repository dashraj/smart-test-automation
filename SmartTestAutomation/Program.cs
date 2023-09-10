using SmartTestAutomation.Core.Implementations;
using SmartTestAutomation.Core.Interfaces;

var inputFile = "test_data.csv";
var projectName = "RajaSeleniumSpecFlowProject";
var workingDir = @"C:\Raja\Official\Workshop\Projects\POC\Test\";

ISmartTestService service = new SmartTestService();

service.StartTheProcess(inputFile, projectName, workingDir);




// Wait for the user to press a key
//Console.ReadKey();

