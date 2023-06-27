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


    
    
    void Iluxery.luxery(string message)
    {

        Console.WriteLine("this is luxery method from interface"+message);

    }
    void Iluxery2.luxery2(string message)
    {

        Console.WriteLine("this is luxery2 method from interface"+message);

    }
    public void ConsolePrint(string text)
    {
        Console.WriteLine("this is console print method"+text);
    }
    
    //deligate is a part of functional programming which is used to pass a method as a parameter
    public mainAbstract.SimpleDelegate delegateBike1;
    
    
    //change lowcase to lowercase
    public mainAbstract.SimpleDelegate delegateBike2 = (string param) => Console.WriteLine(param.ToLower());
    
    //change lowcase to uppercase 
    public mainAbstract.SimpleDelegate delegateBike3 = (string param) => Console.WriteLine(param.ToUpper());
    // speed limit 30km/h
    public mainAbstract.SimpleDelegate2 delegateBike4 = (int param) => Console.WriteLine(param>30?"Speed limit exceeded":"Speed limit not exceeded");
    
    
    




}