using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.工厂方法模式
{
    /// <summary>
    /// 减法功能类
    /// </summary>
    public class SubtractionCalculation:SunFaBase
    {
        public override double GetResult()
        {
            return numberA - numberB;
        }
    }
}
