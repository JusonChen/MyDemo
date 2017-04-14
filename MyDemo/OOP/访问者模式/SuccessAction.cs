using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.访问者模式
{
    class SuccessAction : Action
    {
        public override void ManAction(Man man)
        {
            Console.WriteLine(string.Format( "{0}{1}时，背后多半有一个伟大的女人",man.GetType().Name,GetType().Name));           
        }

        public override void WomenAction(Woman woman)
        {
            Console.WriteLine(string.Format( "{0}{1}时，背后多半有一个不成功的男人",woman.GetType().Name,GetType().Name));
        }
    }
}
