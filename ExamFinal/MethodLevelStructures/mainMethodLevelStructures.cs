using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;

namespace ExamFinal.MethodLevelStructures;

public class mainMethodLevelStructures
{
    public static void mainMethodLevelStructures1()
    {



        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("\n" + new string('*', 10) + "out,ref,in" + new string('*', 10));
        Console.ResetColor();
        
        
        //out and ref help to give a varaible by reference to a method
        //in this case exact value of the number pass and coppy to the method
        //in is a read only variable and can not be changed in the method
        int number = 200;
        addNumber(number);
        void addNumber(in int number1)
        {
            number = number1 + 10;
            Console.WriteLine("Number is(VALUE): " + number);
        }
        
        //refrence type is a refrance to the memory location of the object
        //the caller is responsible for providing the arguments or parameters, and the callee is responsible for
        //performing the desired operations using those arguments.
        //REFRENCE ITS SEND DATA TO caler to the calee and the calee can change the value of the variable
        //allocated in stack and heap12
        int numberR = 20;
        addNumberR(ref numberR);

        static void addNumberR(ref int number)
        {
            number= number + 10;
            Console.WriteLine("Number is(REFRENCE two-way communication): " + number);
        }
        //OUT is also the refrance type but the deference is that we dont need to initialize the variable
        //out is one way only from calee to the caller
        int numberO = 30;
        addNumberO(out numberO);

        static void addNumberO(out int numberO)
        {
            numberO = 30;
            numberO = numberO + 10;
            Console.WriteLine("Number is(OUT one-way communication): " + numberO);
        }
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("\n" + new string('*', 10) + "Defult value and optional paramiter " + new string('*', 10));
        Console.ResetColor();
        
        
        //[optional] is a keyword that we can use to make a paramiter optional
         void MyMethod(int x, int y = 10)
        {
            Console.WriteLine("x is: " + x);
            Console.WriteLine("y is: " + y);
        }

         void MyMethod2(int xx, int yy , [Optional] String name)
         {
             Console.WriteLine("xx is: " + xx);
             Console.WriteLine("yy is: " + yy);
             Console.WriteLine("name is: " + name);
         }
         
             


        
        
        
        
         Console.ForegroundColor = ConsoleColor.DarkRed;
         Console.WriteLine("\n" + new string('*', 10) + "THIS IS TUPLES" + new string('*', 10));
         Console.ResetColor();
       

        //a decounstructer is a method that takes a tuple and breaks it into its parts and assign them to variables 
        (string message, bool isValid) = ValidateAddress("123 stran");
        if (isValid)
        {
            Console.WriteLine($"Your validated address is {message}");
        }
        else
        {
            Console.WriteLine("That is an invalid adress.");
        }


        //Tuples is a data structure that contains a sequence of elements of different data types
        //with _ caracter we can ignore the value of tuple and only care about the second value
        //primerly useful for returning multiple values from a method without using out parameters

        (string address, bool isValid) ValidateAddress(string address)
        {
            if (address.Equals("123 stran"))
            {
                return ("123 stran street", true);

            }
            else
            {
                return (address, false);
            }

        }
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("\n" + new string('*', 10) + "System.Attribute" + new string('*', 10));
        Console.ResetColor();
        
        var assembly = Assembly.GetExecutingAssembly().GetTypes()
            . Where(t => t.GetCustomAttributes<AttributeExample.SampleAttribute>().Any()).ToList();
        Console.WriteLine("NAME OF THE ASSEMBLY: " + assembly[0].Name);
        
        AttributeExample.SampleAttribute sampleAttribute1 = 
            new AttributeExample.SampleAttribute(1, 80, "M", "Student@gmail.com");
        
        var context = new ValidationContext(sampleAttribute1);
        var results = new List<ValidationResult>();
        bool ok = Validator.TryValidateObject(sampleAttribute1, context, results, true);
        Console.WriteLine("Dave validion is : " + ok);
        
        
        
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("\n" + new string('*', 10) + "THIS IS Exception Handling" + new string('*', 10));
        Console.ResetColor();

        
        int x;
        int y;
        double result;

        //exception is and error that occurs during the execution of a program
        try
        {
            Console.WriteLine("Enter a number1:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a number2:");
            y = Convert.ToInt32(Console.ReadLine());

            result = x / y;
            Console.WriteLine("Result is: " + result);
        }
        //CATCH EVERYTHING BUT ITS A BAD PRACTICE its better user know what is the problem
        /*catch (Exception e)
        {
            Console.WriteLine("Error: Enter only number please " + e.Message);
        }*/
        catch (DivideByZeroException e)
        {
            Console.WriteLine("Error: Cannot divide by zero " + e.Message);
        }
        catch (FormatException e)
        {
            Console.WriteLine("Error: Enter only number please " + e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: Something went wrong " + e.Message);
        }
        //finaly block is always executed no matter what
        
        finally
        {
            Console.WriteLine("Finally block is executed");
        }

// is used to wait for the user to press a key before the program exits.
        Console.ReadKey();
        
        
        
    }
    
}