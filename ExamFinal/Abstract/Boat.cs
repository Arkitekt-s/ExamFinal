namespace ExamFinal.Abstract;

public class Boat:Vehicle
{
    public int wheels;
    public int maxSpeed;
    public Boat(int wheels, int maxSpeed,int speed):base(speed)
    {
        this.wheels = wheels;
        this.maxSpeed = maxSpeed;
    }
    
}