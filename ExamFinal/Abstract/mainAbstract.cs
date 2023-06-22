namespace ExamFinal.Abstract;

public class mainAbstract
{
    public static void Abstractmain1()
    {
        // Abstract
            
        Car car = new Car();
        Bicycle bicycle = new Bicycle();
        Boat boat = new Boat();
        //Vehicle vehicle = new Vehicle();
        //bike is run method 
        bicycle.luxery();
        bicycle.luxery2();
        bicycle.delegateBike1("soheil ride bike");
        bicycle.delegateBike2("soheil ride bike");
        bicycle.delegateBike3("soheil ride bike");
        bicycle.delegateBike4(30);
        bicycle.delegateBike4.Invoke(80);
        //add deligate together 
            
        static void ProcessCompliet1(object sender, EventArgs e)
        {
            Console.WriteLine("Process compliet");
        }

        // Subscribe ProcessCompliet1 method to the eventHandler event
        bicycle.eventHandler += ProcessCompliet1;
        // Call the StartProcess method of the bicycle object 
        bicycle.StartProcess();
            
        //[] for bike 
        List<Bicycle> bicycleList = new List<Bicycle>
        {
            new Bicycle(2,20),
            new Bicycle(2,40),
            new Bicycle(2,60),
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