using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ProjectEulerSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = Stopwatch.StartNew();

            // begin problem execution!
            new Problem13();

            sw.Stop();
            Console.WriteLine("Execution time: {0}ms", sw.Elapsed.Milliseconds);
            Console.ReadLine();
        }
    }
}
