using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    //只允许出现在方法上AttributeTargets.Method
    //不允许出现多条AllowMultiple =false
    //该特性不能继承
    [AttributeUsage(AttributeTargets.Class,AllowMultiple =false,Inherited =false)]
    public class MyClassAttribute : Attribute
    {
        public MyClassAttribute(string msg) {
            Documentation = msg;
        }

        public string Documentation { get; set; }
    }
}
