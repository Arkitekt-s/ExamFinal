namespace ExamFinal.Abstract;
//abstract class is prevented from being instantiated in main and not allow to create an object
//its a missing component or incomplete implementation and give littele bit of security
abstract public class Vehicle
{
    public int speed;

    protected Vehicle(int speed)
    {
        this.speed = speed;
    }

    public void Go()
    {
        Console.WriteLine("this vehicle is moving");
    }
}