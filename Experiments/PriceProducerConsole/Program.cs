using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceProducerConsole
{
    class Program
    {
        static void Main(string[] args)
        {            //this sample produce the shared memory object and stay active enabling the ConsumerConsole to read the object values.

            Console.WriteLine("SharedMemory.SharedArray:");
            using (var producer
                = new SharedMemory
                .SharedArray<int>("PovEURUSDm5", 10))

            using (var consumer
                = new SharedMemory.SharedArray<int>("PovEURUSDm5"))
            {
                producer[0] = 123;
                producer[producer.Length - 1] = 456;

                Console.WriteLine(consumer[0]);
                Console.WriteLine(consumer[consumer.Length - 1]);
                Console.WriteLine("Press a key to close the SMem server");
                Console.ReadKey();
            }
        }
    }
}
