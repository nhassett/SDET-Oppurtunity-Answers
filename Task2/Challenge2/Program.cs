using System;

/*
*   C# Program for the presecribed challenge 2:
*       Finding the most common character in a string
*   author: Nathan Hassett   
*/

namespace Challenge2
{
    class Program
    {
        //Method that will determine the most occurring char from the passed string and return that char
        static char determineOccuringChar(string userInput)
        {
            //make a copy of the string all lowercase (because we are ignoring case)
            string userInputLowerCase = userInput.ToLower();
            //creat the char to return and make it the first char in the string
            char returnChar = userInputLowerCase[0];
            //create an int to count how many times a char occurs in a string 
            int occuranceCounter = 0;
            //create an int to keep track of how many times the highest current occuring char occurs 
            int prevMax = 0;

            //iterate through the string checking how many times a character occurs with the inner foreach loop
            foreach(char c in userInputLowerCase)
            {
                 //reset the counter to check how many times it occurs
                occuranceCounter = 0;

                //each time we check a char, we check it against the whole string
                foreach(char cToCheck in userInputLowerCase)
                {
                    //if we find a match increase the counter (we will find 1 match each time when the char checks itself)
                    if(c == cToCheck)
                    {
                        //increment the occuranceCounter because we found a match 
                        occuranceCounter++;
                    }
                }
                //if the occurance counter is greater than the previous highest total we have a new highest occuring char
                if(occuranceCounter > prevMax)
                {
                    //store the new Char in the char we are returning from the method
                    returnChar = c;
                    //store the new max in the prev max variable
                    prevMax = occuranceCounter;
                }                    
            }
            return returnChar;
        }

        static void Main(string[] args)
        {
            //create the string that will store the user's input
            string? input;
            //create the char for storing the most common char from the string
            char mostComChar;
            
            //prompt the user to enter the word(string) they want to check
            Console.WriteLine("Enter the string that you want to check:");
            //read from the console to store the input
            input = Console.ReadLine();
            
            //if the input is not null and the length is greater than 0 we can determing the most occuring char
            if(input != null && input.Length > 0)
            {
                //Pass the string to the function that figures out the most occuring char.
                mostComChar = determineOccuringChar(input);
                //print the most common char out
                Console.WriteLine("Highest occuring char is: " + mostComChar);
            }
            else //else report to the user no input was detected
            {
                Console.WriteLine("no input detected");
            }            
        }
    }
}