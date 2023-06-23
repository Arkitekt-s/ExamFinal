namespace ExamFinal;

public class Ufo : PersonClass
{
    public string Planet { get; set; }

    public PersonClass[] abductedPeople;

    // constructor
    //This is achieved using the base keyword followed by the appropriate arguments to pass to the base class constructor. 
    public Ufo(string name, int age, string planet) : base(name, age)
    {
        Planet = planet;
    }

    public override string GetInfo()
    {
        return $"This Ufo name is {Name} and age is {Age} and planet is {Planet}";
    }

    //list of ufo
    public void DepartmentApducted()
    {
        abductedPeople = new PersonClass[5];
        abductedPeople[0] = new PersonClass("ali1", 21);
        abductedPeople[1] = new PersonClass("ali2", 22);
        abductedPeople[2] = new PersonClass("ali3", 23);
        abductedPeople[3] = new PersonClass("ali4", 24);
        abductedPeople[4] = new PersonClass("ali5", 25);
    }

    public void ColectedItem()
    {
        MyItem[] myItems = new MyItem[5];
        myItems[0] = new MyItem("item1");
        myItems[1] = new MyItem("item2");
        myItems[2] = new MyItem("item3");
        
    }


    public PersonClass this[int index]
    {
        get { return abductedPeople[index]; }
        set { abductedPeople[index] = value; }
    }
}


       