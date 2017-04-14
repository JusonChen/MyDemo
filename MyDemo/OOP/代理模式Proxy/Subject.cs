using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    /// <summary>
    /// 定义了代理类和真实类公用的接口
    /// </summary>
    abstract class Subject
    {
        public abstract void Request();
    }
}
