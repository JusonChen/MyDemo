using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.职责链模式
{
    /// <summary>
    /// 抽象管理类
    /// </summary>
    abstract class Manager
    {
        protected Manager _manage;
        private string _name;
        public Manager(string name)
        {
            _name = name;
        }
        public void SetManager(Manager manage)
        {
            this._manage = manage;
        }

        public abstract void GetResult(int checkNum);
    }
}
