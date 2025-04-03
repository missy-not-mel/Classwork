﻿namespace StringExamples;

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
         * C# provides several methods to operate in Stringd
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
                
        if (string1.CompareTo(string2) > 0) // if these are equals
        {
            Console.WriteLine("string1 is greater than string2");
        }
        else
        {
            Console.WriteLine("string1 is NOT greater than string2");
        }
        if (string1.CompareTo(string2) == 0) // if these are equals
        {
            Console.WriteLine("string1 is equal than string2");
        }
        else
        {
            Console.WriteLine("string1 is NOT equal than string2");
    } // End of Main()
}   //End of class Program