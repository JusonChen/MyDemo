using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.观察者模式
{
    /// <summary>
    /// 股票的观察者，继承观察者抽象类
    /// </summary>
    class GuPiaoObserver 
    {
        private NotifyBase notify;
        private string name;

        public GuPiaoObserver(NotifyBase _notify, string _name)
        {
            name = _name;
            notify = _notify;
        }

        public  void CloseGuPiao()
        {
            Console.WriteLine(string.Format("通知者信息:{0},不要再看股票了,{1}", name, notify.NotifyMessage));
        }
    }
}
