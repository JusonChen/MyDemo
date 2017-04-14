using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    /// <summary>
    /// 代理类
    /// </summary>
    class Proxy:Subject
    {
        //代理的真实对象
        RealSubject real;
        public override void Request()
        {
            if (real == null)
            {
                real = new RealSubject();
            }
            real.Request();
        }
    }
}
