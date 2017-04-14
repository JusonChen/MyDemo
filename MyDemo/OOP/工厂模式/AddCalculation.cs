using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class AddCalculation:CalculationBase
    {
        public override double GetResult()
        {
            return numberA + numberB;
        }
    }
}
