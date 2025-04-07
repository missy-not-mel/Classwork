namespace MethodsExamples;

class Program
{
    /********************************************************************************
     *Demonstrate the use of Programmer defined methods
     *
     * a method is a program that processes data and usually returns a value
     *
     * a method starts with a method signature. A method signature identifies the name of the method
     *                                                                        what type of data it returns
     *                                                                        what data is will accept for processing
     * Method signature:  return-type Name(data-it-will-accept)
     *
     *     return-type - the type of data returned from the method
     *                   use void if the methocd does not return data
     *
     *     Name() - name of the method - method names are in PascalCase
     *                               PascalCase - the first letter of every work is capitalized
     *
     *     (data-it-will-accept) - data-type and anem of any parameters
     *
     *     parameter is a piece of data passed/given to a method for it processing
     * ***********************************************************************************/
    // Every Application has one and only one method called Main()
    //
    // Main() method signature 
    //
    // static - indicates there can only be one of this in an application 
    //
    //     return 
    //     type name (parameters-it-may-accept)
    static void Main(string[] args) //Main is a method that returns nothing and receives a string[]
    {
        Console.WriteLine("Hello, World!");
        int mySum = Addem(4, 5); // Send number 4 & 5 to Addem to get the sum
        // Addem() will be executed with the numbers 4 & 5
        // It will return the sum 
        // Which will be stored in the variable mySum

        int yoda = 97;
        int obiWan = 420;
            
            
        Console.WriteLine("The sum of 4 & 5 is: " + mySum);
        Console.WriteLine("The sum of 3 & 4 is; " + Addem(3, 4));
        Console.WriteLine("The sum of yoda and obiWan is: " + Addem(yoda, obiWan)); // Calling Addem with 2 ints
                                                                                    // Run the Addem that takes 2 ints
        Console.WriteLine("The sum of 3 & 4 is: " + Addem(3.1, 4.5)); // Calling Addem with 2 doubles
                                                                      // Run the Addem that takes 2 doubles
        Console.WriteLine("The sum of 3 & 4 is: " + Addem(3, 4.5));   // Calling Addem with an int and a double
                                                                      // We don't have an Addem that takes an int and a double
                                                                      // It ran the Addem that takes 2 doubles 
                                                                      // C# converts the int to a double
                                                                      // so now it can run the Addem that takes 2 doubles
        
    } // End of Main()

// After a method you may define other methods that method can use
// "Helper Methods" - help a method to perform a specific task

    // Define a method to receive two numbers and return the sum
    //
    // If a method will be used by a static method, it must be static itself
    // Any method used by Main() must be static because Main() is static
//        return
//        type name(parameters)

// Addem is a method that receives two ints that its call num1 & num2 
//                   and returns the sum of the ints as an int
    static int Addem(int num1, int num2)
    {
        Console.WriteLine("Addem was called with " + num1 + ", " + num2);
        return num1 + num2; // Add the two parameters and return the sum
    }
    static double Addem(double num1, double num2)
    {
        Console.WriteLine("Addem (double, double) was called with " + num1 + ", " + num2);
        return num1 + num2; // Add the two parameters and return the sum
        //     double + double - result is a double
        // return type must be a double
    }
}