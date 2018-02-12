using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWcfConsumer {
    class Program {
        static void Main(string[] args) {
            using(SayMyNameService.Service1Client client = new SayMyNameService.Service1Client()) {
                Console.WriteLine(client.SayMyName());

                Console.Read();
            }
        }
    }
}
