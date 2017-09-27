using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceConsumerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string mname = "PovEURUSDm5" ;
            using (var consumer
    = new SharedMemory.SharedArray<int>(mname))
            {
                ;

                Console.WriteLine(consumer[0]);
                Console.WriteLine(consumer[consumer.Length - 1]);
            }
        }
    }
    
}
