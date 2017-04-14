using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    //结构只能继承接口，也不能被继承
    public struct StruckTest: ITest
    {
        public int I { get; set; }
        public string Name { get; set; }

        public string GetName()
        {
            return Name??"czs";
        }
    }
}
