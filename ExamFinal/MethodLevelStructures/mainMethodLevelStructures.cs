using System.Diagnostics;

namespace ExamFinal.MethodLevelStructures;

public class mainMethodLevelStructures
{
    public static void mainMethodLevelStructures1()
    {
        Console.WriteLine("***************************************out,ref,in  ***********************************");
        //out and ref help to give a varaible by reference to a method
        //in this case exact value of the number pass and coppy to the method
        int number = 10;
        addNumber(number);
        static void addNumber(int number)
        {
            number = number + 10;
            Console.WriteLine("Number is(VALUE): " + number);
        }
        
        //refrence type is a refrance to the memory location of the object
        //the caller is responsible for providing the arguments or parameters, and the callee is responsible for
        //performing the desired operations using those arguments.
        //REFRENCE ITS SEND DATA TO caler to the calee and the calee can change the value of the variable
        //allocated in stack and heap
        int numberR = 20;
        addNumberR(ref numberR);

        static void addNumberR(ref int numberR)
        {
            numberR = numberR + 10;
            Console.WriteLine("Number is(REFRENCE two-way communication): " + numberR);
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


        
        
        
        
        
        Console.WriteLine("***************************************THIS IS TUPLES***********************************");

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

        Console.WriteLine(
            "***************************************THIS IS Exception Handling***********************************");
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
        
        Console.WriteLine(
            "***************************************System.Attribute***********************************");
        
       

    }
    
}