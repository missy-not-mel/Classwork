namespace FirstProgram;

// The Program will ask for three number
//     add them together and display the total

// Programming Solution - Human Thinking
// Identify the detailed steps
//
// Ask for the numbers one at a time
// Write down each number as it's given
// Add the numbers together to create a sum/total
// Tell the total (display)
//
// Now that we have the steps in our solution 
// Identify any data you need for the steps
//
// 1. A place to write down each number - a variable in a program
// 2. A place to hold the sum/total - a variable in a program
// 3. A way to ask for the numbers - a method in a program (object.method())
// 4. A way to receive the numbers - a method in a program (object.method())
// 5. A way to report the sum/total - a method in a program (object.method())
//
//Place the steps in the order and provide more detail if necessary 
// 1. Ask for the numbers one at a time
//   a. Tell whoever is giving us the number to give me the first number
//   b. Receive the first number from the sender
//   c. Write down each number 
//   d. Tell whoever is giving us the number to give me the second number
//   e. Receive the second number from the sender
//   f. Write down second number 
//   g. Tell whoever is giving us the number to give me the third number
//   h. Receive the third number from the sender
//   i. Write down third number 
//
// 2. Add the numbers together to create a sum/total
//    a. Add the first number to a sum/total
//    b. Add the second number to a sum/total
//    c.Add the third number to a sum/total
//
// 3. Tell the requester the sum/total(display)
//

//Commonly used data types in C#
// int - Numeric data that is a whole number between +/- 2 billion
// long - A whole number greater than +/- 2 billion 
//double - numeric value with decimal places
// char - a single alpha-numeric character
// string - a series o alpha-numeric characters (words or sentence)
// bool - true or false for condition 

// Variable names in C# are usually spelled in camelCase

class Program
{
    static void Main(string[] args)
    {
        int number1 = 0;
        int number2 = 0;
        int number3 = 0;
        
        int sum = 0;
        
        Console.WriteLine("--- Starting Program ---");

        Console.WriteLine("Please enter a number;"); //Asking for a number
        string aLine; // Define a String to hold the line of input from the keyboard
        aLine = Console.ReadLine();
        // we need an int to store our numbers
        // Console.ReadLine() only returns a string from keyboard
        // So we need to convert the string from Console.ReadLine() to an int
        // int.Parse(string) will convert a string to an int
        
        number1 = int.Parse(aLine);
        
        // Just to verify we are getting data from the keyboard
        //Let's display it
        // '+' with a string it concatenates the strings (sticks them together)
        Console.WriteLine("Please enter a number;");
        aLine = Console.ReadLine(); // Reuse aLine define above
        number2 = int.Parse(aLine);
        
        Console.WriteLine("Please enter a number;");
        aLine = Console.ReadLine(); // Reuse aLine define above
        number3 = int.Parse(aLine);
        
        // Add the numbers together to create a sum/total
        sum = number1 + number2 + number3;
        //Alternate coding method
        // However you code, as long as you get a correct solution
        //         and you understand it, it is right
        // sum = sum + number1
        // sum = sum + number2
        // sum= sum + number3
        
        
        Console.WriteLine("The sum is: " + sum);
        
        Console.WriteLine("--- Ending Program ---");
    }
}