using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 事件和委托例子
{
    //我定义的事件
    public class MyEvents
    {
        //申明一个MyDelegate委托类型的事件
        public event Action<int> czsThreeClick;

        //事件触发的方法
        public void Excute(int b)
        {
            if (czsThreeClick != null)
            {
                czsThreeClick(b);
            }
        }
    }
}
