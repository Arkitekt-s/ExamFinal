namespace ExamFinal.Abstract;

public class mainAbstract
{
    public delegate void SimpleDelegate(string param);
    public delegate void SimpleDelegate2(int param);
    public static void Abstractmain1()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n" + new string('*', 50) + "Abstraction" + new string('*', 50));
        Console.ResetColor();
        // Abstract
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n" + new string('*', 10) + "Interface" + new string('*', 10));
        Console.ResetColor();
            
        Car car = new Car(2,4,100);
        Bicycle bicycle = new Bicycle(2,20,50);
        Boat boat = new Boat(0,100,50);
        //Vehicle vehicle = new Vehicle();
        //bike is run method 
        Iluxery bicycleAsIluxery = bicycle;
        bicycleAsIluxery.luxery(" soheil ride nice bike");
        
        Iluxery2 bicycleAsIluxery2 = bicycle;
        bicycleAsIluxery2.luxery2(" soheil ride bike");
       
        
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n" + new string('*', 10) + "Deligates" + new string('*', 10));
        Console.ResetColor();
        bicycle.delegateBike1=bicycle.ConsolePrint;
        bicycle.delegateBike1("this is delegate bike1");
        
        bicycle.delegateBike2("soheil ride bike");
        bicycle.delegateBike3("soheil ride bike");
        bicycle.delegateBike4(30);
        bicycle.delegateBike4.Invoke(80);
        //add deligate together 
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n" + new string('*', 10) + "Event handling" + new string('*', 10));
        Console.ResetColor();
            
        static void ProcessCompleiet(object? sender, EventArgs e)
        {
            Console.WriteLine("Process compliet");
        }

        // Subscribe ProcessCompliet1 method to the eventHandler event
        car.eventHandler += ProcessCompleiet;
        // Call the StartProcess method of the car object 
        car.StartProcess();
        
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n" + new string('*', 10) + "Lambdas" + new string('*', 10));
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n" + new string('*', 10) + "Expression Lambdas" + new string('*', 10));
        Console.ResetColor();
        //[] for bike 
        List<Bicycle> bicycleList = new List<Bicycle>
        {
            new Bicycle(2,20,2),
            new Bicycle(2,40,2),
            new Bicycle(2,60,2),
        };
        //sort by speed
        var sortedBicycleList = bicycleList.OrderBy(b=>b.maxSpeed);
        //print the list
        foreach (var item in sortedBicycleList)
        {
            Console.WriteLine(item.maxSpeed);
        }
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n" + new string('*', 10) + "Statement Lambdas" + new string('*', 10));
        Console.ResetColor();
        
        var filteredBicycleList = bicycleList.Where(b =>
        {
            return b.maxSpeed > 30;
        });

        // print the filtered list
        foreach (var item in filteredBicycleList)
        {
            Console.WriteLine(item.maxSpeed);
        }
         
        //print the list
        
    }
}