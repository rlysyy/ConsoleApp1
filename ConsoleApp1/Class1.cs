using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class1
    {
        static Barrier barrier = new Barrier(3, barrier =>
        {
            Console.WriteLine("All Sub Task Finished");
            string[] results = concurrentBag.ToArray();
            foreach(string result in results)
            {
                Console.WriteLine(result);
            }
        });

        static ConcurrentBag<string> concurrentBag = new ConcurrentBag<string>();

        static void Main(string[] args)
        {
            Task.Factory.StartNew(() => takePicAndShowResult());
            Console.WriteLine("Main Task Finished");
            Console.ReadKey();
        }

        private static string takePicAndShowResult()
        {
            Random random = new Random();
            
            Task<string> task1 =Task.Factory.StartNew(() => getAIresult(1));
            Thread.Sleep(random.Next(100, 200));
            Task<string> task2 = Task.Factory.StartNew(() => getAIresult(2));
            Thread.Sleep(random.Next(100, 200));
            Task<string> task3 = Task.Factory.StartNew(() => getAIresult(3));
            return "ok";
        }

        private static string getAIresult(int i)
        {
            Random random = new Random();
            Thread.Sleep(random.Next(1000,2000));
            string result;
            if (random.Next(1, 3) == 1)
            {
                result = "ok";
            } else {
                result = "ng";
            };
            Console.WriteLine("Thread id:" + Thread.CurrentThread.ManagedThreadId + " Result:" + result);
            concurrentBag.Add(result);
            barrier.SignalAndWait();
            return result;
        }
    }
}
;