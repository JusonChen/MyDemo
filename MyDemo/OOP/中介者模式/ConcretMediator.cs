using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.中介者模式
{
    /// <summary>
    /// 具体中介类
    /// </summary>
    class ConcretMediator: Mediator
    {
        ColleagueChildA colleagueA;
        ColleagueChildB colleagueB;

        public ColleagueChildA ColleagueA
        {
            set { colleagueA = value; }
        }

        public ColleagueChildB ColleagueB
        {
            set { colleagueB = value; }
        }

        public override void Send(string msg, Colleague _colleague)
        {
            if (_colleague == colleagueA)
            {
                colleagueB.Notify(msg);
            }
            else if (_colleague == colleagueB)
            {
                colleagueA.Notify(msg);
            }
        }
    }
}
