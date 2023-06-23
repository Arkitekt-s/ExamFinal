namespace ExamFinal.Abstract;

public class Bicycle:Vehicle,Iluxery,Iluxery2
{
    public int wheels;
    public int maxSpeed;
    
    

//INHARITE FROM VEHICLE CLASS
    public Bicycle(int wheels, int maxSpeed,int speed): base (speed)
    {
        this.wheels = wheels;
        this.maxSpeed = maxSpeed;
    }
    public Bicycle(int speed): base (speed)
    {
        
    }


    
    
    public void luxery()
    {
        Console.WriteLine("Luxery Bike1");
    }
    public void luxery2()
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
    
    
    




}