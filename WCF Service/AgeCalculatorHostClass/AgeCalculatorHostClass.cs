using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace AgeCalculatorHostClass
{
    class AgeCalculatorHostClass
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(AgeCalculatorService.AgeCalculatorServiceClass)))
            {
                host.Open();
                Console.WriteLine("Host started the service");
                Console.ReadKey();
            }
        }
    }
}
