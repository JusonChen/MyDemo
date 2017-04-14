using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.工厂模式
{
    public class CalculationBase
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
