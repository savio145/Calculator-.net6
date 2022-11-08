using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
   //Use of Class Factory Design Pattern
    public class OperationsFactory
    {
        public IOperations Solve(string expression)
        {
            if (expression.Contains('/'))
            {
                return new Divide(expression);
            }
            else if (expression.Contains('*'))
            {
                return new Multiply(expression);
            }
            else if (expression.Contains('+'))
            {
                return new Plus(expression);
            }
            else if (expression.Contains('-'))
            {
                return new Minus(expression);
            }
            else if (expression.Contains('^'))
            {
                return new Power(expression);
            }
            else
                return null;
        }
    }
}
