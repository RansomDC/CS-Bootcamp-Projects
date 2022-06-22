using System;
using System.Collections.Generic;

namespace ArrayAndList_Submission_Assignment
{
    class Program
    {
        static void Main()
        {
            // Creates an array of integers and adds 6 elements to that array
            int[] numArray = { 5, 10, 15, 20, 25, 30 };

            // Creates an array of strings and add 6 elements to that array
            string[] stringArray = { "pineapple", "kiwi", "orange", "passion fruit", "grape", "apple" };

            // Creates a list of strings and adds 6 elements to that list
            List<string> stringList = new List<string>();
            stringList.Add("cherry");
            stringList.Add("plum");
            stringList.Add("nectarine");
            stringList.Add("peach");
            stringList.Add("apricots");
            stringList.Add("mangoes");


            // prints a request to the console as instructions for the user
            Console.WriteLine("Please select a nubmer between 0 and 5 to see that element of the number array");
            // Stores input of the user.
            string numIndexInput = Console.ReadLine();
            // Converts the input result to an integer that can be used as the index value in the array.
            int result = Convert.ToInt32(numIndexInput);
            // This loop repeatedly asks for a user input value as long as the previously input value is out sideo f the range of 0-5
            while (result > 5 || result <0)
            {
                Console.WriteLine("Please enter a valid number between 0 and 5");
                numIndexInput = Console.ReadLine();
                result = Convert.ToInt32(numIndexInput);
            }
            // Prints the correct collection element based off of the index selected by the user
            Console.WriteLine(numArray[result]);

            // prints a request to the console as instructions for the user
            Console.WriteLine("Please select a nubmer between 0 and 5 to see an element of the string array");
            // Stores input of the user.
            string stringIndexInput = Console.ReadLine();
            // Converts the input result to an integer that can be used as the index value in the array.
            int index = Convert.ToInt32(stringIndexInput);
            // This loop repeatedly asks for a user input value as long as the previously input value is out sideo f the range of 0-5
            while (index > 5 || index < 0)
            {
                Console.WriteLine("Please enter a valid number between 0 and 5");
                stringIndexInput = Console.ReadLine();
                index = Convert.ToInt32(stringIndexInput);
            }
            // Prints the correct collection element based off of the index selected by the user
            Console.WriteLine(stringArray[index]);

            // prints a request to the console as instructions for the user
            Console.WriteLine("Please select a nubmer between 0 and 5 to see an element of the string array");
            // Stores input of the user.
            string listIndexInput = Console.ReadLine();
            // Converts the input result to an integer that can be used as the index value in the array.
            int listIndex = Convert.ToInt32(listIndexInput);
            // This loop repeatedly asks for a user input value as long as the previously input value is out sideo f the range of 0-5
            while (listIndex > 5 || listIndex < 0)
            {
                Console.WriteLine("Please enter a valid number between 0 and 5");
                listIndexInput = Console.ReadLine();
                listIndex = Convert.ToInt32(listIndexInput);
            }
            // Prints the correct collection element based off of the index selected by the user
            Console.WriteLine(stringList[listIndex]);

            Console.Read();
        }
    }
}
