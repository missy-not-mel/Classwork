﻿namespace Day_1_Student_Class_Example;

class Program
{
    // This is an application program 
    // It instantiates and uses objects to perform processing
    // Every application has exactly one method called Main()
    
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Student Class Example");
        
    // Instantiate (define) a Student class object       
    // A class is data type
    // Define an object of a class liek any other variable with a slight difference
    
    // data-type name = initializer;  int sum = 0;
    
    // A class is instantiated with the new keyword 
    //         is initiaized using one of its constructors
    // className name = new className(initializers);
    
    // We need to be sure have all the data we want to store in our object
    // Before we instantiate the object
    List<double> scores = new List<double>();
    scores.Add(100);
    scores.Add(90);
    scores.Add(80);
    
    List<double> scores2 = new List<double>();
    scores2.Add(100);
    scores2.Add(100);
    scores2.Add(100);
    
    // Defining an object of a class is very similar to defining any other datatype
    
    // data
    // type name = initial value;
    int x = 10;

    // Instantiate a Student using the data we want to store in the Student object
    // ClassName objName = new ClassName(initial-name, initial-scores)
    Student aStudent = new Student("Frank", scores);    // Calling the 2-arg constructor that takes a name and scores
    Student aStudent2 = new Student("Marquise", scores2); // Calling he 2-arg that constructor that takes a name and scores
    
    // Display the Student object we created
    // Console.WriteLine() does not now how to display an object of our class
    Console.WriteLine("aStudent: " + aStudent);
    
    // Use the Student class method to display Student class object
    //
    // object.method() <--- object oriented notations
    aStudent.ShowStudent();
    aStudent2.ShowStudent();
    
    // Define a student with no scores
    Student johnTheStudent = new Student("John");
    johnTheStudent.ShowStudent();
    
    // Add some score to johnTheStudent
    johnTheStudent.AddScore(86);
    johnTheStudent.AddScore(90.5);
    johnTheStudent.AddScore(26);
    johnTheStudent.AddScore(67);
    johnTheStudent.AddScore(98);
    
    johnTheStudent.ShowStudent();
    
    Console.WriteLine($"\nThe sum of scores: {johnTheStudent.sumofScores}");

    //Console.WriteLine(aStudent.studentName);
    }
}