using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Calculator
{
    // this service contract implemented the events for this class.
    // For example, this service contract has implemented the event of 
    // a user to perform basic arithmetric. 
    [ServiceContract]
    public interface ICalculatorService
    {
        // operation contracts are used to define the methods of the service contract
        // this operation contract is that it will add the numbers that were exchanged
        [OperationContract]
        double Add(double n1, double n2);

        // this operation contract is that it will subtract the numbers that were exchanged
        [OperationContract]
        double Subtract(double n1, double n2);

        // this operation contract is that it will multiply the numbers that were exchanged
        [OperationContract]
        double Multiply(double n1, double n2);

        // this operation contract is that it will divide the numbers that were exchanged
        [OperationContract]
        double Divide(double n1, double n2);
    }
}
