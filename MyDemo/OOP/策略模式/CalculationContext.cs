using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class CalculationContext
    {
        private CalculationBase calculationBase = null;
        public CalculationContext(string type,double numberA,double numberB)
        {
            switch (type)
            {
                case "-":
                    calculationBase = new SubtractionCalculation();
                    break;
                case "+":
                    calculationBase = new AddCalculation();
                    break;
            }
            calculationBase.numberA = numberA;
            calculationBase.numberB = numberB;
        }

        public double GetResult()
        {
            return calculationBase.GetResult();
        }
    }
}
