using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.中介者模式
{
    class ColleagueChildB : Colleague
    {
        public ColleagueChildB(Mediator mediator) : base(mediator)
        { }

        public override void Send(string msg)
        {
            _mediator.Send(msg, this);
        }

        public override void Notify(string msg)
        {
            Console.WriteLine("同事ColleagueChildB得到消息:" + msg);
        }
    }
}
