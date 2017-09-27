using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var consumer
                = new SharedMemory.SharedArray<int>("MySharedArray"))
            {
       ;

                Console.WriteLine(consumer[0]);
                Console.WriteLine(consumer[consumer.Length - 1]);
            }
        }
    }
}
