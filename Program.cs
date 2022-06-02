using System;
using System.Diagnostics;

namespace SelectionAndHeap_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] n = new int[] {1,16,13,5,3,9,5,3,4 };

            int n = 10;

            for (int i = 0; i < 6; i++)
            {
                n = n * 10;

                TimeTest(n);
            }



        }

        private static void TimeTest(int n)
        {
            Random r = new Random();
            var unsort = new int[n];
            for (int i = 0; i < n; i++)
            {
                unsort[i] = r.Next(0, n);
            }


            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            //Sort.SelectionSort(unsort);
            Sort.HeapSort(unsort);


            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);

            Console.WriteLine("RunTime {0} {1} = {2}", "HeapSort", unsort.Length, elapsedTime);

            /*
            foreach (int i in unsort)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine($"");
            */
        }
    }
}
