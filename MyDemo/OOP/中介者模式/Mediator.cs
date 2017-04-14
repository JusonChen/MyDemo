using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.中介者模式
{
    abstract class Mediator
    {
        public abstract void Send(string msg, Colleague _colleague);
    }
}
