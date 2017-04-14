using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.观察者模式
{
    /// <summary>
    /// 通知者A，集成抽象类
    /// </summary>
    class Notify_A : NotifyBase
    {
        public event Update ToNotify;
        public override void Notify()
        {
            ToNotify();
        }
    }
}
