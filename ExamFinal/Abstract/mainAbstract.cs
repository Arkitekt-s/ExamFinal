namespace ExamFinal.Abstract;

public class mainAbstract
{
    public static void Abstractmain1()
    {
        // Abstract
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n" + new string('*', 10) + "Interface" + new string('*', 10));
        Console.ResetColor();
            
        Car car = new Car(2,4,100);
        Bicycle bicycle = new Bicycle(2,20,50);
        Boat boat = new Boat(0,100,50);
        //Vehicle vehicle = new Vehicle();
        //bike is run method 
        bicycle.luxery();
        bicycle.luxery2();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n" + new string('*', 10) + "Deligates" + new string('*', 10));
        Console.ResetColor();
        bicycle.delegateBike1("soheil ride bike");
        bicycle.delegateBike2("soheil ride bike");
        bicycle.delegateBike3("soheil ride bike");
        bicycle.delegateBike4(30);
        bicycle.delegateBike4.Invoke(80);
        //add deligate together 
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n" + new string('*', 10) + "Event handling" + new string('*', 10));
        Console.ResetColor();
            
        static void ProcessCompliet1(object sender, EventArgs e)
        {
            Console.WriteLine("Process compliet");
        }

        // Subscribe ProcessCompliet1 method to the eventHandler event
        car.eventHandler += ProcessCompliet1;
        // Call the StartProcess method of the bicycle object 
        car.StartProcess();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n" + new string('*', 10) + "Lambda" + new string('*', 10));
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
        
    }
}