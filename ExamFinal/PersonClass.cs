﻿namespace ExamFinal;

public class PersonClass
//seald class can not be in haritantas a parents class but  can be a child class
//sealed public class PersonClass
//partial class can be in different files and can have two or more partial class
{
    //THIS IS A AUTO IMPLIMENT PROPERTY WHICH IS A SHORTCUT FOR THE BELOW CODE AND IS ONLY USED WHEN YOU DONT NEED TO DO
    //ANYTHING ELSE IN THE GET AND SET
    //its a refrance type so it has a default value of null
    public string Name { get; set; }
    public int Age { get; set; }
//STATIC IS BELONG TO THE CLASS NOT THE OBJECTAND no object has onership of it
    public static int NumberofPeople;
    // constructor
    public PersonClass(string name, int age)
    {
        Name = name;
        Age = age;
        NumberofPeople++;
    }

    /*public string name;
    public int age;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }*/

    
    //constructor
    /*public PersonClass(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }*/
    
    
    
    

    // tostring method
    public virtual string GetInfo()
    {
        return $"This PersonClass name is {Name} and age is {Age}";
    }
    //walk 
    public static void Walking()
    {
        Console.WriteLine($"there is {NumberofPeople} people walking");
    }
    
}