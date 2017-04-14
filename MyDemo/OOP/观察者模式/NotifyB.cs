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
    class NotifyB : NotifyBase
    {
        public event Update update;
        public override void Notify()
        {
            update();
        }
    }
}
