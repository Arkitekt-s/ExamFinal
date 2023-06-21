namespace ExamFinal.Abstract;

public class Bicycle:Vehicle,Iluxery,Iluxery2
{
    public int wheels=2;
    public int maxSpeed = 50;
    //built-in delegate in C#
    public event EventHandler? eventHandler;


    public Bicycle(int wheels, int maxSpeed)
    {
        this.wheels = wheels;
        this.maxSpeed = maxSpeed;
    }
    public Bicycle()
    {
        
    }


    //ProcessCompliet(EventArgs e): This method is responsible for processing the completion of an operation related to
    //the bicycle. It prints a message indicating that the bicycle is on process and invokes the eventHandler event if there are any subscribers.
    public void ProcessCompliet( EventArgs e)
    {
        Console.WriteLine("Bicycle is on process");
        eventHandler?.Invoke(this,  e);
        
    }
    
    
    public void StartProcess()
    {
        Console.WriteLine("Bicycle is starting");
        ProcessCompliet(EventArgs.Empty);
    }
    
    public void luxery()
    {
        Console.WriteLine("Luxery Bike1");
    }
    public  void luxery2()
    {
        Console.WriteLine("Luxery Bike2");
    }
    //deligate is a part of functional programming which is used to pass a method as a parameter
    public Iluxery.SimpleDelegate delegateBike1 = (string param) => Console.WriteLine(param);
    
    //change lowcase to lowercase
    public Iluxery.SimpleDelegate delegateBike2 = (string param) => Console.WriteLine(param.ToLower());
    
    //change lowcase to uppercase 
    public Iluxery.SimpleDelegate delegateBike3 = (string param) => Console.WriteLine(param.ToUpper());
    // speed limit 30km/h
    public Iluxery.SimpleDelegate2 delegateBike4 = (int param) => Console.WriteLine(param>30?"Speed limit exceeded":"Speed limit not exceeded");
    
    
    //use event handler for this deligate
    //event is a notification mecanisem witch is depents on deligate
    //evenent can not creat without deligate
    public  EventHandler eventHandlerBike = (object sender, EventArgs e) => Console.WriteLine("Event Handler Bike");




}