var arg1 = new NullabilityRulesCheckLibrary.PassAround();

var cl1 = new NullabilityRulesCheckLibrary.Class1();

cl1.Method1(null);
cl1.Method1(arg1);

cl1.Method2(null);
cl1.Method2(arg1);
