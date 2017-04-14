using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class TestFn
    {
        private readonly static TestFn fn = new TestFn();

        public string Name { get; set; }

        private TestFn()
        {
            Name = "czs";
        }

        public static TestFn GetInstrace()
        {
            return fn;
        }
    }
}
