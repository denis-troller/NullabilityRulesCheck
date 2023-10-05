using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullabilityRulesCheckLibrary
{
    public class PassAround
    {
        public string Name { get; set; }

        public void Method1(string name)
        {
            Console.Out.WriteLine($"{Name}-{name}");
        }
    }
}
