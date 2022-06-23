using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_part_submission_assignment
{
    class Program
    {
        static void Main()
        {


            // PART 1
            Console.WriteLine("PART 1");
            // A message to the user, and a request for input from the user
            Console.WriteLine("Please input some text to add to our array of strings!");
            string input = Console.ReadLine();

            // Declaring our array and it's elements
            string[] stringArray = { "peaches ", "apples ", "grapes ", "oranges ", "passion fruit " };

            // A loop that updates each array element by adding the user's input to the end of the string
            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] = stringArray[i] + input;
            }

            // A loop that prints each array element on the screen
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);
            }

            //PART 2
            Console.WriteLine("\nPART 2");
            // This used to read: 
            //for (int c = 1; c > 0; c++)
            //{
            //    Console.WriteLine("This is broken!");
            //}

            // This prints some lines of text multiple times. This also fills the requirement for PART 3 #1
            for (int c = 1; c < 10; c++)
            {
                Console.WriteLine("This is fixed!");
            }


            //PART 3 #2
            Console.WriteLine("\nPART 3");
            //
            for (int m = 1; m <= 3; m++)
            {
                Console.WriteLine("Here is some text!");
            }

            // PART 4
            Console.WriteLine("\nPART 4");
            // Declaring a list of strings
            List<string> stringList = new List<string>() { "lemons", "limes", "grapefruit", "tangerines", "oranges", "nectarines", "kumquats", "pomelo", "citron", "key limes", "tangelo", "Yuzu" };
            // Messaging the user and requesting input
            Console.WriteLine("Enter your search terms to see if our list contains the fruit you're looking for.");
            string citrusInput = Console.ReadLine();

            for (int cc = 0; cc < stringList.Count; cc++) 
            {
                // This line checks to see if the list contains the search term and if it does prints a message about it and ends the loop
                if (stringList[cc].Contains(citrusInput))
                {
                    Console.WriteLine("Nice! index #" + cc + " contained your search!");
                    break;
                }
                // This line checks if the loop as reached the end and if it has tell sthe user that their search term wasn't found
                else if (cc >= stringList.Count - 1)
                {
                    Console.WriteLine("Sorry, your search terms doesn't seem to be in the list! Have a nice day!");
                }
                // This continues the loop if the previous aspects aren't met
                else
                {
                    continue;
                }
            }


            // PART 5
            Console.WriteLine("\nPART 5");
            // Declaring a list of strings
            List<string> doubleList = new List<string>() { "lemons", "limes", "grapefruit", "tangerines", "lemons", "oranges", "nectarines", "kumquats", "pomelo", "citron", "key limes", "tangelo", "Yuzu" };
            List<int> foundList = new List<int>();
            // Messaging the user and requesting input
            Console.WriteLine("Enter your search terms to see if our list contains the fruit you're looking for.");
            string doubleListSearch = Console.ReadLine();


            for (int c = 0; c < stringList.Count; c++)
            {
                // This line checks to see if the list contains the search term and if it does prints a message about it and ends the loop
                if (doubleList[c].Contains(doubleListSearch))
                {
                    Console.WriteLine("Nice! index #" + c + " contained your search!");
                    // Adds the index number to the found search list so that the next else if knows whether something was found.
                    foundList.Add(c);
                    continue;
                }
                // This line checks if the loop has reached the end AND if any results were added to the search list. if both are false it tells the user that their search term wasn't found
                else if (c >= stringList.Count - 1 && foundList.Count < 1)
                {
                    Console.WriteLine("Sorry, your search terms doesn't seem to be in the list! Have a nice day!");
                }
                // This continues the loop if the previous aspects aren't met
                else
                {
                    continue;
                }
            }


            // PART 6
            Console.WriteLine("\nPART 6");
            string memoryString = "";
            // Creates a list with several repeated elements
            List<string> partSixList = new List<string>() { "lemons", "limes", "grapefruit", "tangerines", "lemons", "oranges", "nectarines", "kumquats", "kumquats", "pomelo", "citron", "key limes", "tangelo", "Yuzu", "tangerines" };
           
            // Starts a loop that iterates through each item in the partSixList
            foreach(string item in partSixList)
            {
                //Displays the contents of each element
                Console.WriteLine("This index contains: " + item);
                // Checks if an element has been seen in the list so far by checking the memoryString variable
                if (memoryString.Contains(item))
                {
                    Console.WriteLine("This items has appeared in the list before.");
                }
                // Adds the current item to the memory string so that if it is seen again the above block of text will indicate that.
                memoryString = memoryString + item;
            }

            Console.Read();
        }
    }
}
