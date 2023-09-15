// Practice C# - Calculating the Average of three numbers, defined by the user.
// 15/09/2023
//     Prompt the user to enter three numbers.
//     Read and store the three numbers.
//     Calculate the average of the three numbers.
//     Display the calculated average.
//
﻿using System.Linq;

while (true) // Loop back to start if conditions are not met.
{
//  Start the program - Prompt user to write three numeric values, seperated by commas. (i.e "3, 8, 10")
    Console.WriteLine("Enter three numbers seperated by commas (,)");
    #pragma warning disable CS8600 // Couldn't figure out how to suppress "Converting null literal or possible null value to non-nullable type." error. So I disabled it.
    string userInput = Console.ReadLine();
    if (userInput == "stop") // Stop the program if user writes "stop"
    {
        break;
    }
    else
    {
        if (userInput != null) // If the input returns null, restart.
        {
            string[] answers = userInput.Split(','); // Split the input into an array between each comma.
            var numbers = new List<int> { }; // Defines an empty List array for later.
            int answerCount = userInput.Count(c => c == ','); // counts every comma in the userInput string.
            bool isNumeric = double.TryParse(userInput, out _); // attempts to parse the userInput as a double.

            if (isNumeric == true && answerCount == 2) // Checks if the userInput was parseable into a double and if there was a total of 2 commas (thus checking if there are 3 seperate numeric values.)
            {

                foreach (string answer in answers) // Does the following for every value in the array that userInput was split into earlier.
                {
                    string trimmedAnswer = answer.Trim();   // Removes all spaces in the value.
                    int answerNumber = int.Parse(trimmedAnswer); // Parse the string into a usable integer.
                    Console.WriteLine(answerNumber); // Shows the three numbers you wrote, for debugging.
                    numbers.Add(answerNumber); // Adds each seperate integer into the empty List array that was defined earlier.
                }
                double average = numbers.Average(); // Sets the average of the List Array to a new "double".
                Console.WriteLine($"The average is {average}!");
                break; // Break the loop.
            }
            else
            {
                Console.WriteLine("Invalid answer."); // If the above conditions fail, tell the that their answer was invalid then restart.
            }
        }
    }
}
