using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.工厂方法模式
{
    /// <summary>
    /// 加法工厂类
    /// </summary>
    class AddCalculationFactory:ICalculationFactory
    {
        public SunFaBase GetCalculation()
        {
            return new AddCalculation();
        }
    }
}
