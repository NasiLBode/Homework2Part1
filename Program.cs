/* File Name: Part 1
Programmer: Nasi Bode
Date: 4th September 2021
Problem Statement: Create a program that starts with the string variable that is first set to a first name, and the last set of string variable to the last name. Both names should be lowercase. Using those two string variable sets, create a new string that contains the full name in pig latin, with the first letter capitalized for the first and last name. Use the pig latin rules of moving the first letter to the end of the word and adding "ay". Output the new pig latin name to the screen. Use Subtstring and ToUpper methods to construct the new name. 
Overall Plan: 
1. Print welcome message to the screen
2. Prompt user to enter their first name
3. Save name in string set
4. Prompt user to enter their last name
5. Save name in second string set
6. Format first string to find the first letter of the string
7. Create a string for the rest of the word
8. Add "ay" to the end of the string
9. Save to a new string variable for final pig latin translation
10. Repeat for second name
11. Output new pig latin name to the screen
*/


using System;

class Program
{
    public static void Main(string[] args)
    {

        //print welcoming message to the screen
        Console.WriteLine("Hello! This program will create a pig latin name for you!\n");
        //prompt user to enter their first name
        Console.WriteLine("Please enter your first name: \n");
        //create string variable for the first name
        string firstName = "";
        //get string name from user
        firstName = Console.ReadLine();
        //Console.WriteLine ("You entered '{0}'", firstName);
        //prompt user to enter last name
        Console.WriteLine("\nPlease enter your last name: \n");
        //prompt user for last name
        string lastName = "";
        lastName = Console.ReadLine();
        //Console.WriteLine ("You entered '{0}'", lastName);
        Console.WriteLine("\nYour original name was {0} {1}", firstName, lastName);
        //Console.WriteLine ("Your Pig Latin name is '{0}','{1}'", firstPigName, lastPigName);

        //create string variables for first and last name
        string PigLatinFirst = ""; //final result
        string PigLatinSecond = ""; //final result
        string firstLetterName = "";
        string firstLetter2Name = "";
        string firstEnding = "";
        string secondEnding = "";

        //finds the first letter of the string
        firstLetterName = firstName.Substring(0, 1);
        //saves the rest of the word to the string
        firstEnding = firstName.Substring(1);
        //create actual pig latin word
        PigLatinFirst = firstEnding + firstLetterName + "ay";

        //repeat for last name
        firstLetter2Name = lastName.Substring(0, 1);
        secondEnding = lastName.Substring(1);
        PigLatinSecond = secondEnding + firstLetter2Name + "ay";

        //output the new name to the screen
        Console.WriteLine("\nYour Pig Latin Name is: {0} {1}", PigLatinFirst, PigLatinSecond);
        //extra space at the end of program
        Console.WriteLine();

    }
}
