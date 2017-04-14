using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.工厂模式
{
    public class AddCalculation:CalculationBase
    {
        public override double GetResult()
        {
            return numberA + numberB;
        }
    }
}
