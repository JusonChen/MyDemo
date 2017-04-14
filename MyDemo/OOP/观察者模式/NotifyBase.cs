using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.观察者模式
{
    delegate void Update() ;
    /// <summary>
    /// 通知者，抽象类
    /// </summary>
    abstract  class NotifyBase
    {
        public string NotifyMessage { get; set; }
        public abstract void Notify();
        
    }
}
