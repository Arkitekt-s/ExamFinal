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
                Task task3 = Task.Run(() =>
                {
                    calculate3A();
                });
                var result1A = await calculate1Async();
                calculate2A(result1A);

                await task3;
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
            
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n" + new string('*', 10) + "Functional Programing" + new string('*', 10));
            Console.ResetColor();
            
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n" + new string('*', 10) + "Builder Design Pattern" + new string('*', 10));
            Console.ResetColor();
            
            var productBuilder = new ProductBuilder();
            Product product3=productBuilder.setName("Product3").setPrice(300).Build();
            Console.WriteLine($"Product3:{product3.Name} {product3.Price}");
            
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n" + new string('*', 10) + "Extension methods" + new string('*', 10));
            Console.ResetColor();
            var ShoppingCart = new ShoppingCart();
            ShoppingCart.Products.Add(new Product { Name = "Product1", Price = 100 });
            ShoppingCart.Products.Add(new Product { Name = "Product2", Price = 200 });
            //add product 3 in the shopping cart    
            ShoppingCart.Products.Add(product3);
            //we can use it as a regular method as well
            //use extention method in order to dont touch the original api 
            Console.WriteLine($"Total in card:{ShoppingCart.CalculateTotalPrice()}");
            ShoppingCartExtensions.CalculateTotalPrice(ShoppingCart);
            Console.WriteLine($"Different way to access to Total Price:{ShoppingCartExtensions.CalculateTotalPrice(ShoppingCart)}");
            
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n" + new string('*', 10) + "Records" + new string('*', 10));
            Console.ResetColor();
            
            AdvanceRECORD advanceRecord=new AdvanceRECORD{Name = "AdvanceRECORDStruct", Age = 30};
            AdvanceRECORD advanceRecord2=new AdvanceRECORD{Name = "AdvanceRECORDStruct", Age = 30};
            Console.WriteLine(advanceRecord);
            Console.WriteLine(advanceRecord2);
            Console.WriteLine($"Record can check the property and if its true return true:{advanceRecord==advanceRecord2}");
            
            Product product1=new Product{Name = "Product1", Price = 100};
            Product product2=new Product{Name = "Product1", Price = 100};
            Console.WriteLine($"Two class even if they have the same property are not equal:{product1==product2}");

            var advanceRecordClassButDifferent = advanceRecord with {Age = 40};
            
            Console.WriteLine(advanceRecordClassButDifferent);
            Console.WriteLine(advanceRecord);
            Console.WriteLine(advanceRecord2);
            Console.WriteLine($"Record can check the property and if its true return true:{advanceRecord==advanceRecordClassButDifferent}");
            





















        }
    }
}









