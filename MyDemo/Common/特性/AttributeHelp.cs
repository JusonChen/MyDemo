using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [MyClass("我测试的特性，类")]
    public class AttributeHelp
    {
        [MyMethod("我测试的特性，方法")]      
        public void TestAtt()
        {

        }
    }
}
