using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.访问者模式
{
    class FaileAction : Action
    {
        public override void ManAction(Man man)
        {
            Console.WriteLine(string.Format( "{0}{1}时，闷头喝酒，谁也不用劝",man.GetType().Name,this.GetType().Name));
        }

        public override void WomenAction(Woman woman)
        {
            Console.WriteLine(string.Format("{0}{1}时，眼泪汪汪，谁也劝不了", woman.GetType().Name, this.GetType().Name));
        }
    }
}
