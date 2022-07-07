using System;

namespace Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in you first name.");
            string date = DateTime.Today.ToShortDateString();
            string uName = Console.ReadLine();
            string msg = $"\nWelcome back {uName}. Today is {date}.";
            Console.WriteLine(msg);

            string path = @"C:\Users\Ranso\Documents\Programming\CS-Bootcamp-Projects\CS-Frames-Practice\Scores\Scores\studentScores.txt";
            string[] lines = System.IO.File.ReadAllLines(path);


            double tScore = 0.0;

            Console.WriteLine("\nStudent scores: \n");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
                double score = Convert.ToDouble(line);
                tScore += score;
            }

            double avgScore = tScore / lines.Length;
            Console.WriteLine("Total of " + lines.Length + " student scores. \tAbverage score: " + avgScore);


            Console.WriteLine("\n\nPress any key to exit");
            Console.Read();
        }
    }
}
