using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.观察者模式
{
    /// <summary>
    /// 观察者抽象类
    /// </summary>
    abstract class Observer
    {
        protected NotifyBase notify;
        protected  string name;

        public Observer(NotifyBase _notify, string _name)
        {
            name = _name;
            notify = _notify;
        }


        public abstract void Update();
        
    }
}
