using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.访问者模式
{
   abstract class Action
    {
       public abstract void ManAction(Man man);

        public abstract void WomenAction(Woman woman);
    }
}
