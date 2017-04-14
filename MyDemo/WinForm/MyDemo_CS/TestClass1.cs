using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDemo_CS
{
    public  partial class TestCZS:ICloneable
    {
        public object Clone()
        {
            return null;
        }

        public string TestFn()
        {
            return "1";
        }
    }
}
