using System;
using System.IO;
using System.Threading.Tasks;

namespace ExamFinal.Advance
{
    public class mainAdvance
    {
        //task is a bridge between synchronous and asynchronous operations
        public static void mainAdvance1()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n" + new string('*', 10) + "Async and Await" + new string('*', 10));
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n" + new string('*', 10) + "Explicit Task Handling" + new string('*', 10));
            Console.ResetColor();
            
            
            
            calculate();
            
            
            

            static void calculate()
            {
                var task1 = Task.Run(() =>
                {
                    return calculate1();
                });
                var awaiter1 = task1.GetAwaiter();
                awaiter1.OnCompleted(() =>
                {
                    var result1 = awaiter1.GetResult();
                    calculate2(result1);
                });
                
                calculate3();
            }

            static int calculate1()
            {
                Thread.Sleep(1000);
                Console.WriteLine("calculate1");
                return 100;
            }

            static int calculate2(int result1)
            {
                Console.WriteLine("calculate2");
                return result1 * 2;
            }

            static int calculate3()
            {
                Console.WriteLine("calculate3");
                return 300;
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n" + new string('*', 10) + "Implicit Task Handling" + new string('*', 10));
            Console.ResetColor();
            
            calculateAsync().Wait();
            
            
            static async Task calculateAsync()
            {
                var result1A = await calculate1Async();
                calculate2A(result1A);
                calculate3A();
            }

            static async Task<int> calculate1Async()
            {
                await Task.Delay(1000);
                Console.WriteLine("calculate1Async");
                return 100;
            }

            static void calculate2A(int result1)
            {
                Console.WriteLine("calculate2Async");
                var result2A = result1 * 2;
                // Do something with result2
            }

            static void calculate3A()
            {
                Console.WriteLine("calculate3Async");
                // Do something
            }
        }
    }
}









