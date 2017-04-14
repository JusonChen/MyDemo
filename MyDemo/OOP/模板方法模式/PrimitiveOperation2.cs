using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.模板方法模式
{
    class PrimitiveOperation2 : AbstractClass
    {
        public override void subAbstractFn1()
        {
            //子类具体的实现方法
            Console.WriteLine("我选择C");
        }
        public override void subAbstractFn2()
        {
            //子类具体的实现方法
            Console.WriteLine("我选择D");
        }
    }
}
