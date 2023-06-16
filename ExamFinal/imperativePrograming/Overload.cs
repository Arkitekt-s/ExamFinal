namespace ExamFinal
{
    public class Overload
    {
        public double cm {get ; set;}
        public double inch {get ; set;}
        // C# introduces the concept of nullable value types through the use of the nullable modifier ?.
        //// Nullable int with a value of null
        public int ? nullableInt = null; 
        // Nullable int with a value of 10
        public Nullable<int> nullableInt2 = null;

        //The null-coalescing 
        //operator ?? returns the value of its left-hand operand if it isn't null; otherwise, it evaluates the right-hand operand and returns its result.
        //If the nullable expression is not null, the operator returns its value. Otherwise, it returns the default value.
        public int? nullableInt1 => nullableInt?? 0;
        
        
        //null Propagation
        //The null-conditional operator ?. allows you to access members and elements only when the receiver is not-null, providing a null result otherwise.
        public int? nullableInt3 => nullableInt2?.CompareTo(10);


        //getter and setter
        
        


        public Overload()
        {
            this.cm = 0;
            this.inch = 0;
        }

        public Overload(double cm, double inch)
        {
            this.cm = cm;
            this.inch = inch;
        }
        public string ConvertToCm()
        {
            //STRING INTERPOLATION
            return $"{inch } inch = {inch * 2.54} cm";
        }
        //When you overload an operator for a custom type, you are defining how that operator should behave when applied to objects of that type. 
        public static Overload operator -(Overload a, Overload b)
        {
            return new Overload(a.cm - b.cm, a.inch - b.inch);
        }
        //pathern matching
        //type pattern is keyword followed by the type to check (double in this case) and the variable name (i in this case).
        public static void TypePattern(object o)
        {
            if (o is double i)
            {
                Console.WriteLine($"{i} is an double!");
            }
            else
            {
                Console.WriteLine($"{o} is not an double!");
            }
        }
        //switch pattern is keyword followed by the type to check (double in this case) and the variable name (i in this case).
        public static void SwitchPattern(object o)
        {
            switch (o)
            {
                case double i:
                    Console.WriteLine($"{i} is an double!");
                    break;
                case string s:
                    Console.WriteLine($"{s} is an string!");
                    break;
                default:
                    Console.WriteLine($"{o} is not an double or string!");
                    break;
            }
        }
        //property pattern is keyword followed by the type to check (Overload in this case) and the property pattern { cm: 0, inch: 0 }. The property pattern specifies the desired values for the properties cm and inch, which should both be 0.
        //is keyword followed by the type to check (Overload in this case) and the property pattern { cm: 0, inch: 0 }. The property pattern specifies the desired values for the properties cm and inch, which should both be 0.
        public static void PropertyPattern(object o)
        {
            if (o is Overload { cm: 10, inch: 10})
            {
                Console.WriteLine($"{o} is an Overload with cm and inch 10!");
            }
            else
            {
                Console.WriteLine($"{o} is not an Overload with cm and inch 10!");
            }
        }
    }
}