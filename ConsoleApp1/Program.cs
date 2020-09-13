using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //static void Main(string[] args)
        //{
            //Thread t = new Thread(WriteY);
            //t.Start();
            //for (int i = 0; i <= 1000; i++) Console.Write("x");
            //Console.ReadKey();

            //传递参数
            //Thread t = new Thread(() => Print("Hello From t"));
            //t.Start();

            //.NET 4.0写法
            //Task.Factory.StartNew(() => Console.WriteLine("Foo"));
            //Console.ReadLine();

            //返回值
            //Task<int> task = Task.Factory.StartNew(() => { Console.WriteLine("Foo"); return 3; });
            //int result = task.Result;
            //Console.WriteLine(result);
            //Console.ReadKey();

            List<Task> taskList = new List<Task>();
            TaskFactory taskFactory = new TaskFactory();

            //for(int i = 0; i < 5; i++)
            //{
            //    string name = string.Format("button_Click{0}", i);
            //    {
            //        Task task = new Task(()=> {
            //            TestThread2(i.ToString(), i.ToString());
            //        }
            //        );
            //        task.Start();
            //        taskList.Add(task);
            //    }
            //}
            #region 01-WaitAny
            //{
            //    Task.WaitAny(taskList.ToArray());
            //    Console.WriteLine("执行完毕： Task.WaitAny 线程id为：{0}", Thread.CurrentThread.ManagedThreadId);
            //}
            #endregion
            #region 01-WaitAll
            //{
            //    Task.WaitAll(taskList.ToArray());
            //    Console.WriteLine("执行完毕： Task.WaitAll 线程id为：{0}", Thread.CurrentThread.ManagedThreadId);
            //}
            #endregion
            #region 01-WaitAll
            //{
            //    Task.Factory.ContinueWhenAny(taskList.ToArray(),(m) => { Console.WriteLine("执行完毕： ContinueWhenAny 线程id为：{0}", Thread.CurrentThread.ManagedThreadId); });
            //}
            #endregion

        //}

        /// <summary>
        /// 执行动作:耗时而已
        /// </summary>
        private static void TestThread0()
        {
            Console.WriteLine("线程开始：当前线程的id为:{0}，当前时间为：{1},", System.Threading.Thread.CurrentThread.ManagedThreadId, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff"));
            long sum = 0;
            for (int i = 1; i < 999999999; i++)
            {
                sum += i;
            }
            Console.WriteLine("线程结束：当前线程的id为::{0}，当前时间为：{1}", System.Threading.Thread.CurrentThread.ManagedThreadId, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff"));
        }

        /// <summary>
        /// 执行动作:耗时而已
        /// </summary>
        private static void TestThread(string threadName)
        {
            Console.WriteLine("线程开始：线程名为：{2}，当前线程的id为:{0}，当前时间为：{1},", System.Threading.Thread.CurrentThread.ManagedThreadId, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff"), threadName);
            long sum = 0;
            for (int i = 1; i < 999999999; i++)
            {
                sum += i;
            }
            Console.WriteLine("线程结束：线程名为：{2}，当前线程的id为::{0}，当前时间为：{1}", System.Threading.Thread.CurrentThread.ManagedThreadId, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff"), threadName);
        }

        /// <summary>
        /// 执行动作:耗时而已
        /// </summary>
        private static void TestThread2(string threadName1, string threadName2)
        {
            Console.WriteLine("线程开始：线程名为：{2}和{3}，当前线程的id为:{0}，当前时间为：{1},", System.Threading.Thread.CurrentThread.ManagedThreadId, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff"), threadName1, threadName2);
            long sum = 0;
            for (int i = 1; i < 999999999; i++)
            {
                sum += i;
            }
            Console.WriteLine("线程结束：线程名为：{2}和{3}，当前线程的id为::{0}，当前时间为：{1}", System.Threading.Thread.CurrentThread.ManagedThreadId, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff"), threadName1, threadName2);
        }

        private static void Print(string v)
        {
            Console.WriteLine(v);
            Console.ReadKey();
        }

        private static void WriteY()
        {
            for (int i = 0; i <= 1000; i++) Console.Write("y");
        }
    }
}
