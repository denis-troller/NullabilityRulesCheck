// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var arg1 = new NullabilityRulesCheckLibrary.PassAround();

var cl1 = new NullabilityRulesCheckLibrary.Class1();

cl1.Method1(null);
cl1.Method1(arg1);
