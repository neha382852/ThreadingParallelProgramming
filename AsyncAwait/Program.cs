using System;
using System.Threading;
using System.Threading.Tasks;
/// <summary>
/// Parallel programming example .Threading example
/// </summary>
namespace AsyncAwait
{
    public class ThreadDemo
    {
        public void SayHello()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Hi: " + i);
                Thread.Sleep(1000);
            }
        }
        public void SayBye()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Bye: " + i);
                Thread.Sleep(1000);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ThreadDemo th = new ThreadDemo();

            //th.SayHello();
            //th.SayBye();

            ThreadStart ts = new ThreadStart(th.SayHello);
            ThreadStart ts1 = new ThreadStart(th.SayBye);
            Thread th1 = new Thread(ts);
            Thread th2 = new Thread(ts1);
            th1.Start();
            th2.Start();
            Console.ReadKey();
        }
    }
}