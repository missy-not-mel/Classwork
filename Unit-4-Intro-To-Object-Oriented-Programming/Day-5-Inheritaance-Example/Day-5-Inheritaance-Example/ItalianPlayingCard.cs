namespace Day_5_Inheritance_Example;

// This is a subclass of a PlayingCard

public class ItalianPlayingCard
{
    // Define a default constructor that calls the base class constructor
    public ItalianPlayingCard() : base(0, "Joker", "Black"){}
    
    // Define a 2-arg constructor for value and suit
    public ItalianPlayingCard(int theValue, string theSuit, string theColor) 
        : base(theValue, theSuit, theColor){}
}