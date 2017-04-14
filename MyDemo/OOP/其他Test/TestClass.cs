using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class TestClass
    {
        public int I { get; set; }
        public string Name { get; set; }

        public string GetName()
        {
            return Name ?? "czs";
        }
    }
}
