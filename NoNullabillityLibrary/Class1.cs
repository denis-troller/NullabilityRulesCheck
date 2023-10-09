namespace NullabilityRulesCheckLibrary
{
    public class Class1
    {
        public void Method1(PassAround arg1)
        {
            if(arg1 is null)
            {
                throw new ArgumentNullException(nameof(arg1));
            }

            arg1.Method1(Name); 
        }    

        public string Name { get; set; }
    }
}