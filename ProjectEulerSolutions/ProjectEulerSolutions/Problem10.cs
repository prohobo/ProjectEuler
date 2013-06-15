using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolutions
{
    class Problem10
    {
        // The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
        // Find the sum of all the primes below two million.

        public Problem10()
        {
            long sum = 0;
            Boolean[] sieveList = new Boolean[2000000];

            for (int i = 2; i < sieveList.Length; i++)
                sieveList[i] = true;

            for (int i = 2; i < sieveList.Length; i++)
            {
                if (sieveList[i] == true)
                {
                    sum += i;

                    for (int j = i + i; j < sieveList.Length; j += i)
                        sieveList[j] = false;
                }
            }

            Console.WriteLine("Result: " + sum);
        }
    }
}
