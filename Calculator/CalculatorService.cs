using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Calculator
{
    // this will specify the behaviour of the service and will create a single instance of the service.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class CalculatorService : ICalculatorService
    {
        public double Add(double n1, double n2)
        {
            return n1 + n2;
        }

        public double Divide(double n1, double n2)
        {
            return n1 / n2;
        }

        public double Multiply(double n1, double n2)
        {
            return n1 * n2;
        }

        public double Subtract(double n1, double n2)
        {
            return n1 - n2;
        }
    }
}
