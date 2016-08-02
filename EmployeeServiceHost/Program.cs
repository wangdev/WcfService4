using EmployeeWcfService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeServiceHost {
    class Program {
        static void Main(string[] args) {
            using (ServiceHost host = new ServiceHost(typeof(EmployeeService))) {
                host.Open();
                Console.WriteLine("EmployeeService started @ " + DateTime.Now.ToString());
                Console.ReadLine();
            }
        }
    }
}
