using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class CalculationFactory
    {
        CalculationBase calculationBase = null;
        public CalculationBase GetCalculation(string type)
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
            return calculationBase;
        }
    }
}
