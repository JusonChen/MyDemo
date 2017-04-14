using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.职责链模式
{
    /// <summary>
    /// 总监的职责管理类
    /// </summary>
    class ZongJianManager : Manager
    {
        public ZongJianManager(string name) : base(name)
        { }

        public override void GetResult(int checkNum)
        {
            if (checkNum < 100)
            {
                Console.WriteLine("总监批准了！");
            }
            else if (_manage != null)
            {
                _manage.GetResult(checkNum);
            }
        }
    }
}
