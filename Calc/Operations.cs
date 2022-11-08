using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public interface IOperations
    {
        string expression { get; set; }
        double result { get; set; }
        string ToString();
    }
    public class Plus : IOperations
    {
        public string expression { get; set; }
        public double result { get; set ; }

        public Plus(string exp)
        {
            expression = exp;
            result = Convert.ToDouble(exp.Split('+')[0]) + Convert.ToDouble(exp.Split('+')[1]);
            
        }
        public override string ToString()
        {
            return (expression+ " = " + result.ToString());
        }
    }
    public class Minus : IOperations
    {
        public string expression { get; set; }
        public double result { get; set; }

        public Minus(string exp)
        {
            this.expression = exp;
            this.result = result = Convert.ToDouble(exp.Split('-')[0]) - Convert.ToDouble(exp.Split('-')[1]);
            
        }
        public override string ToString()
        {
            return (expression + " = " + result.ToString());
        }
    }
    public class Multiply : IOperations
    {
        public string expression { get; set; }
        public double result { get; set; }

        public Multiply(string exp)
        {
            expression = exp;
            result = Convert.ToDouble(exp.Split('*')[0]) * Convert.ToDouble(exp.Split('*')[1]);
           
        }
        public override string ToString()
        {
            return (expression + " = " + result.ToString());
        }
    }
    public class Divide : IOperations
    {
        public string expression { get; set; }
        public double result { get; set; }

        public Divide(string exp)
        {
            expression = exp;
            result = Convert.ToDouble(exp.Split('/')[0]) / Convert.ToDouble(exp.Split('/')[1]);
            
        }
        public override string ToString()
        {
            return (expression + " = " + result.ToString());
        }
    }
    public class Power : IOperations
    {
        public string expression { get; set; }
        public double result { get; set; }

        public Power(string exp)
        {
            expression = exp;
            result = Math.Pow(Convert.ToDouble(exp.Split('^')[0]), Convert.ToDouble(exp.Split('^')[1]));
           
        }
        public override string ToString()
        {
            return (expression + " = " + result.ToString());
        }
    }
}
