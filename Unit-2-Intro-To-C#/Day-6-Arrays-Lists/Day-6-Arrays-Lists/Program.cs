﻿namespace Day_6_Arrays_Lists;

// This program will ask for three numbers
//      add them together and display the total

class Program
{
    static void Main(string[] args)
    {
        // Define an array to hold 3 numbers
        int[] numbers = new int[3]; // numvers.Length =3; 2 is the largest allowable index
        
        
        // Define an array to hold 5 numbers
        int[] numbers = new int = [5]; // numvers.Length=5; 4 is the largest allowable index

        Console.WriteLine("--- Starting program ---");

        // Normally we process an array from beginning to end
        // (from the first element to the last element, one at a time)
        //
        // a for-loop will loop through a process counting as it does so
        // a for-loop is an excellent tool for processing and array from start to end
        //
        // Standard syntax: for(i=0; i < arrayName.Length; i++)
        //
        // arrayName.Length represents the number of elements in the array
        
        // index                loop as
        // start                long as the index         increment the
        // at 0                 is not outside the array  index for each loop
        for (int i = 0; i < numbers.Length; i++) // i =0, 1, 2 inside the loop and 3 when exit loop
        {
            Console.WriteLine("Please enter a number: "); // Asking for the number
            numbers[i] = int.Parse(Console.ReadLine());    // get a string from keyboard
                                                          // convert it to an int
                                                          // store it in numbers[i]
        }
            // Verify the array received the numbers correctly
            // Go through the array one element at a time and display the element
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Element #" + i + "is: " + numbers[i]);
                sum = sum + numbers[1]; // add the current number in the array to sum 
            }
                
            
             
        // Ask for the numbers one at time using the C# Console object
        //     which represents the keyboard and screen
        // Console.ReadLine() returns a string from keyboard - cannot store in an int
        Console.WriteLine("Please enter a number:  "); // Asking for the number
        string theResponse; // Define a string to hold the line of input from the keyboard
        theResponse = Console.ReadLine(); // Get a line from the keyboard
      
        // int.Parse(string) will convert a string to an int
        //number1 = int.Parse(theResponse);

        //Console.WriteLine("Please enter a number:  ");
        //theResponse = Console.ReadLine(); // Reuse theResponse define above
        //number2 = int.Parse(theResponse);

        //Console.WriteLine("Please enter a number:  ");
        //theResponse = Console.ReadLine(); // Reuse theResponse define above
        //number3 = int.Parse(theResponse);
        
        //Console.WriteLine("Please enter a number:  ");
        //theResponse = Console.ReadLine(); // Reuse theResponse define above
        //number4 = int.Parse(theResponse);
        
        //Console.WriteLine("Please enter a number:  ");
        //theResponse = Console.ReadLine(); // Reuse theResponse define above
        //number5 = int.Parse(theResponse);

        // Add the numbers together create a sum/total
        //sum = number1 + number2 + number3 + number4 + number5;
       
        // Tell the requester the sum/total (display)
        Console.WriteLine("The sum is: " + sum);

        Console.WriteLine("--- Ending program ---");
    }
}