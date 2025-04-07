namespace StringExamples;

class Program
{
    static void Main(string[] args)
    {
        /**********************************************************
         *
         * Strings in C# are a special data type - They don't work like you think they should
         *
         * String literals are enclosed in " "
         *
         *  A literal is something that says what it is: 1 1.24 "Bob"
         *
         *
         * string variables sometimes require special processing
         *        you can't use < > to compare strings
         *        Beware: Early versions of C# do not allow use of == with strings
         *
         *a method() is a program that processes data in an object/variable
         *
         * C# provides several methods to operate in Strings:
         *
         *       .Equals(string) - compare the string to left of the . to string inside () for equals
         *       .CompareTo(string) - return a number indicating how to first string relates to the second.
         *                            return a negative number if first string is less than the second
         *                            return a zero if first string is equal to the second
         *                            return a positive number if first string is grated than the second.
         ***********************************************************/
        // if (condition) {
        //    What to do if condition is true
        //}
        // else {
        //   What to do if condition is false
        // }
        string string1 = "a";
        string string2 = "b";

        Console.WriteLine("string1 is: " + string1);
        Console.WriteLine("string2 is: " + string2);

        if (string1.CompareTo(string2) > 0) // if the first string is greater than second string
        {
            Console.WriteLine("string1 is greater than string2");
        }
        else
        {
            Console.WriteLine("string1 is NOT greater than string2");
        }

        if (string1.CompareTo(string2) < 0) // if the first string is greater than second string
        {
            Console.WriteLine("string1 is less than string2");
        }
        else
        {
            Console.WriteLine("string1 is NOT less than string2");
        }

        if (string1.CompareTo(string2) == 0) // if these are equals
        {
            Console.WriteLine("string1 is equal than string2");
        }
        else
        {
            Console.WriteLine("string1 is NOT equal than string2");
            // Some methods that process strings
            // to see a list of all methods available to an object - just type objectName.
            // .Length - returns the number of characters in a string
            // .Contains(string) - return true if the string given is inside a string
            // .Substring(start-index,length) - extract characters from the string starting at the start-index
            //                                  for the number characters indicated by the length
            //                                  start-index starts at 0 NOT 1
            //                                  whenever you see the word index - starts counting at 0
            //                                  whenever you see position - starts counting at 1
            // .StartsWith(string) - returns true is string starts with the specified characters (case-sensitive)
            // .EndsWith(string) - returns true is string ends with the specified characters (case-sensitive)
            // .Trim() - remove any leading or trailing spaces

            //string1.
            //
            string sentence = "     My name is Frank and I attempt teach C#     ";
            Console.WriteLine("There are " + sentence.Length + " characters in the sentence");

            bool containsFrank = sentence.Contains("Frank");
            Console.WriteLine("Does sentence contain Frank: " + containsFrank);

            string nameInSentence = sentence.Substring(11, 5); // Extract the 5 characters starting at position 12
            Console.WriteLine("The name is " + nameInSentence);

            Console.WriteLine("Does sentence start with My? " + sentence.StartsWith("My"));
            Console.WriteLine("Does sentence start with my? " + sentence.StartsWith("my"));
            Console.WriteLine("Does sentence end with C#? " + sentence.StartsWith("C#"));

            Console.WriteLine("Results when sentence.Trim() is used to remove leading and trialing spaces");
            Console.WriteLine("Does sentence start with My? " + sentence.Trim().StartsWith("My"));
            Console.WriteLine("Does sentence start with my? " + sentence.Trim().StartsWith("my"));
            Console.WriteLine("Does sentence end with C#? " + sentence.Trim().StartsWith("C#"));
            
            // When C# sees a statement with chained operations (operations separated by .)
            // 1. C# process the statement from left to right one operation at a time
            // Uses the result of operation in the next one
            // 
            // sentence.Trim().EndsWith("C#)
            
            // 1. sentence.Trim() - return a string with the leading and tailing spaces removed
            // 2. result from first step .EndsWith/90/ - return true or false depending on if string ends with character


        } // End of Main()
    } //End of class Program
}