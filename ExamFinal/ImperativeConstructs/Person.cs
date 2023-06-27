namespace ExamFinal;


    public class Person
    {
        //Under the hood, using the ? modifier for nullable types is equivalent to using the Nullable<T> struct.
        public string? Name { get; set; }
        public int Age { get; set; }
        //The decimal type is a 128-bit data type that can represent decimal values with up to 28-29 significant digits.
        //It is suitable for scenarios where exact decimal representation is required, such as financial calculations,
        //currency conversions, or any situation where rounding errors can have significant impact.
        public decimal Salary { get; set; }

        public Person(string name, int age, decimal salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }
        

        public Person()
        {
        }

        public void GetPossibleName()
        {
            //Null Coalescing Operator (??): If the value of the first operand is null, the operator returns the value
            //of the second operand, otherwise it returns the value of the first operand.
            Console.WriteLine($" This object name is {Name ?? "Anonymus"}");
        }
    }
