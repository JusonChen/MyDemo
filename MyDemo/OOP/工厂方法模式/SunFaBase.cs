using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.工厂方法模式
{
    /// <summary>
    /// 抽象类，基类
    /// </summary>
    public class SunFaBase
    {
        public double numberA { get; set; }

        public double numberB { get; set; }

        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }
    }
}
