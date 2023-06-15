namespace ExamFinal;

    public struct PersonStructs
    {
        //its avalue type interduce in c# 7.2
        //its a struct
        //its a value type
        //Structs do not support inheritance
        //there is no need for the extra memory management steps involved in heap allocation and garbage collection.
        public string Name { get; set; }
        public int Age { get; set; }
        // constructor
        public PersonStructs(string name, int age)
        {
            Name = name;
            Age = age;
        }
        //method tostring
        public override string ToString()
        {
            return $"This PersonStructs name is {Name} and age is {Age}";
        }
    }
