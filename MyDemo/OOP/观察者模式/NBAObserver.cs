using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.观察者模式
{
    class NBAObserver 
    {
        private NotifyBase notify;
        private string name;

        public NBAObserver(NotifyBase _notify, string _name)
        {
            name = _name;
            notify = _notify;
        }

        public  void CloseNBA()
        {
            Console.WriteLine(string.Format("通知者信息:{0},不要再看NBA了,{1}", name, notify.NotifyMessage));
        }
    }
}
