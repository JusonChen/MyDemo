using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.模板方法模式
{
    abstract class AbstractClass
    {
        public void CommonFn()
        {
            //一些公共方法的提取存放处
            Console.WriteLine("一些公共方法的提取存放处");
            //...

            subAbstractFn1();
            subAbstractFn2();

        }
        public abstract void subAbstractFn1();

        public abstract void subAbstractFn2();
    }
}
