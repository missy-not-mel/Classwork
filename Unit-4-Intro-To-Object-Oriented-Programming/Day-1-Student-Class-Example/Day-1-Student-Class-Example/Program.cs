using System.Xml.Schema;

namespace Day_1_Student_Class_Example;

class Program
{
    
    // This is an application program
    // It instantiates and uses objects to perform processing
    // Every application has exactly one method called Main()
    
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Student Class");
        
        // Instantiate (define) a Student class object 
        // A class is a data type 
        // Define an object of the class like you do any other variable with a slight difference
        
        // data-type name = initializer; int sum = 0
        
        // A class is instantiated with the new keyword
        //         is initialized using one of its constructors
        //className name = new className(initializer);

        // We need to be sure we have all the data we want to store in our object
        // Before we instantiate the object
        List < int.scores = new List<int>();
        scores.Add(100);
        scores.Add(90);
        scores.Add(80);
        
        // Instantiate a Student using the data we want to store in the Student object
        Student aStudent = new Student("Frank");

        // Display the Student object we created
        // Console.WriteLine() does not know how to display an object of our class
        Console.WriteLine("aStudent: " + aStudent);
        
        // Use the Student class method to display Student class object
        //
        //object.method() <--- object oriented notations
        aStudent.ShowStudent();
        
        Console.WriteLine(aStudent.StudentName);
    }
}