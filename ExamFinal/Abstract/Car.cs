namespace ExamFinal.Abstract;

public class Car:Vehicle
{
    public int wheels=4;
    public int maxSpeed = 500;
    //build in deligate EventHandler
    public event EventHandler? eventHandler;


    public Car(int speed, int wheels, int maxSpeed) : base(speed)
    {
        this.wheels = wheels;
        this.maxSpeed = maxSpeed;
    }
    
    //use event handler for this deligate
    //event is a notification mecanisem witch is depents on deligate
    //evenent can not creat without deligate
    public  EventHandler eventHandlerCar = (object sender, EventArgs e) => 
        Console.WriteLine("car is  succesfully run(complieted!!)");
    
    //ProcessCompliet(EventArgs e): This method is responsible for processing the completion of an operation related to
    //the bicycle. It prints a message indicating that the bicycle is on process and invokes the eventHandler event if there are any subscribers.
    public void OnProcessCompliet( EventArgs e)
    {
        Console.WriteLine("car is on process");
        eventHandler?.Invoke(this,  e);
        
    }
    
    
    public void StartProcess()
    {
        Console.WriteLine("Car is starting......");
        OnProcessCompliet(EventArgs.Empty);
    }
}