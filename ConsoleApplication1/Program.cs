using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReferenceTest.Service1Client service1Client = new ServiceReferenceTest.Service1Client();
            Console.WriteLine(String.Format("Received from Web Service: {0}", service1Client.sum(1, 4)));
            Console.ReadLine();
        }
    }
}
