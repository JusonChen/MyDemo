using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.中介者模式
{
    /// <summary>
    /// 同事抽象类
    /// </summary>
    abstract class Colleague
    {
        protected Mediator _mediator;
        /// <summary>
        /// 认识中介类
        /// </summary>
        /// <param name="mediator"></param>
        public Colleague(Mediator mediator)
        {
            _mediator = mediator;
        }

        public abstract void Send(string msg);

        public abstract void Notify(string msg);
    }
}
