namespace NullabilityRulesCheckLibrary
{
    public class Class1
    {
        public void Method1(PassAround arg1)
        {
            arg1.Method1();
        }

        public void Method2(PassAround? arg1)
        {
            arg1.Method1();
        }
    }
}