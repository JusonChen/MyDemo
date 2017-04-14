using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.访问者模式
{
    class Woman : Person
    {
        public override void Action(Action _action)
        {
            _action.WomenAction(this);
        }
    }
}
