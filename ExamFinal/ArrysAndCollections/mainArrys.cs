namespace ExamFinal.ArrysAndCollections;

public class mainArrys
{
    public static void mainArry1()
    {
        
        //Generics
        
        //tree different type of array
        //int array
        int [] intArray = new int [] {1000,2000,3000,4000,5000};
        //string array
        string [] stringArray = new string [] {"leo","jack","sara"};
        //double array
        double [] doubleArray = new double [] {10.1,20.2,30.3,40.4,50.5};
        //object array
        object [] objectArray = new object [] {10,20,30,40,50,"soheil","sara","jack",10.1,20.2,30.3,40.4,50.5};
        
        displayElementI(intArray);
        //if i need to accept my double i need complitly different argument for double 
        displayElementD(doubleArray);
        
        displayElementS(stringArray);
        
        
        
         static void displayElementI(int[]array)
        {
            foreach (int item in array)
            {
                Console.WriteLine(item+" ");
            }
        }
         static void displayElementD(double[]array)
         {
             foreach (double item in array)
             {
                 Console.WriteLine(item+" ");
             }
             
         }
         static void displayElementS(string[]array)
         {
             foreach (string item in array)
             {
                 Console.WriteLine(item+" ");
             }
             
         }
         //generic method so accept all type of array
            static void displayElementT<Thing>(Thing[]array)
            {
                foreach (Thing item in array)
                {
                    Console.WriteLine(item+" ");
                }
                
            }
            displayElementT(stringArray);
            displayElementT(objectArray);
            //array in c sharp is  called covariant 
            string[] s = new string[10];
            object[] o = s;
            o[0]="soheil";
            //this attempt is ok in compiles fine and fail in runntime
            //o[1]=10;
            Console.WriteLine(s[0]);
            
            
            
            Parent parent = new Parent("soheil");
            Parent parent1 = new MaleChild("jack","usa",12);
            MaleChild malechild= new MaleChild("alex","usa",22);
            FemailChild femailchild = new FemailChild("anja","uk",33);
            //can not creat parents object from child class
            //Child c1 = new Parent("leo"); invalid
            
            parent.ParentMethod();
            parent1.ParentMethod();
            //can not access to child method from parent class
            //p1.ChildMethod();
            malechild.ParentMethod();
            malechild.MaleChildMethod();
            
            parent= malechild; //covariant where child is a parent
            //This line demonstrates covariance, where you assign an instance of MaleChild (cm) to a variable of type Parent (p).
            //Covariance is allowed because MaleChild is derived from Parent, and assigning a derived type object to a
            //base type reference is permissible.
            
           //malechild=parent; //contravariant where parent is a child its not allowed
            MaleChild[] objectMaleChildrenArray={new MaleChild("jack","usa",12),new MaleChild("alex","usa",22)};
            //give me complie time error
            //Parent[] objectParentArray = objectMaleChildrenArray;
            //objectParentArray[0] = new FemailChild("anja","uk",33);
            
            //read as a list
            //objectParentArray.ToList().ForEach(s=>Console.WriteLine(s));
            
            // convartion, but not safe
            //safe approach IEnumerable<T> provides only read-only access
            IEnumerable<Parent> objectParentArray = objectMaleChildrenArray;
            
            
            
             
            //runtime error give to me 
            //objectParentArray[0] = new FemailChild("anja","uk",33);
            
            //read as a list
            //objectParentArray.ToList().ForEach(s=>Console.WriteLine(s));
    }
}