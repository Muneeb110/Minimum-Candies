using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumCandies
{
    class Program
    {

        public static void Main(string[] args)
        {
            

            List<int> arr = new List<int>();

            int n = 4;
            arr = new List<int>() { 2,0,2,2 };
            long result = Result.candies(n, arr);
            Console.WriteLine(result);
            Console.ReadLine();
        }

       
    }

    class Result
    {

        /*
         * Complete the 'candies' function below.
         *
         * The function is expected to return a LONG_INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER n
         *  2. INTEGER_ARRAY arr
         */

        public static long candies(int n, List<int> arr)
        {
            long totalcandies = 1;
            int currentCandyCount = 1;
            if (arr.Count() == 1)
                return totalcandies;
            long[] tmparr = new long[n];
            tmparr[0] = 1;
            for (int i = 1; i < n; i++)
            {
                if (arr[i] > arr[i - 1])
                    currentCandyCount++;
                else
                    currentCandyCount = 1;

                tmparr[i] = currentCandyCount;
            }
            for (int i = n-2; i >= 0; i--)
            {
                if (arr[i] > arr[i+1] && tmparr[i] <= tmparr[i+1])
                {
                    tmparr[i] = tmparr[i + 1] + 1;
                    
                }
                
            }
            return tmparr.Sum();
        }

    }
}
