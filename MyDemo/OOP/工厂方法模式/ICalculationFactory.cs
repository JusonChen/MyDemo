using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.工厂方法模式
{
    /// <summary>
    /// 工厂类继承的接口
    /// </summary>
    interface ICalculationFactory
    {
         SunFaBase GetCalculation();
    }
}
