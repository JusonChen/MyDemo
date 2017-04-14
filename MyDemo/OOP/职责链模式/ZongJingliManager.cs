using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.职责链模式
{
    /// <summary>
    /// 总经理的职责管理类;
    /// </summary>
    class ZongJingliManager : Manager
    {
        public ZongJingliManager(string name) : base(name)
        { }

        public override void GetResult(int checkNum)
        {
            if (checkNum <1000)
            {
                Console.WriteLine("总经理批准了！");
            }
            else if (_manage != null)
            {
                _manage.GetResult(checkNum);
            }
        }
    }
}
