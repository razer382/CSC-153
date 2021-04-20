/*
 * 2/3/2021
 * CSC 153
 * Branden Alder
 * Drivers license exam program. Counts amount correct, amount wrong and list of answers entered incorrectly
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2HW2_Alderb6714
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarations
            System.IO.StreamReader studentAnswersFile = new System.IO.StreamReader(@"studentanswers.txt");
            String[] correctAnswers = { "b", "d", "a", "a", "c", "a", "b", "a", "c", "d", 
                                        "b", "c", "d", "a", "d", "c", "c", "b", "d", "a" };
            String[] studentAnswers = new string[20];
            List<int> wrongQuestionNumbers = new List<int>();
            int totalWrong = 0;
            int totalRight = 0;

            // Loop to iterate through file and make proper changes to variables
            for (int i = 0; i < correctAnswers.Length; i++)
            {
                studentAnswers[i] = studentAnswersFile.ReadLine();
                if(studentAnswers[i] == correctAnswers[i])
                {
                    totalRight++;
                }
                else
                {
                    totalWrong++;
                    wrongQuestionNumbers.Add(i + 1);
                }
            }
            displayResults(totalRight, totalWrong, wrongQuestionNumbers);

            // Keep console open to view and close file
            Console.ReadLine();
            studentAnswersFile.Close();
        }

        public static void displayResults(int totalRight, int totalWrong, List<int> wrongAnswers) 
        {     // Method to write pass/fail, output number right/wrong and the question numbers incorrect
            if (totalRight >= 15)
                Console.WriteLine("YOU PASSED! :D");
            else
                Console.WriteLine("YOU FAILED! :(");
            
            Console.WriteLine("Questions Correct: " + totalRight);
            Console.WriteLine("Questions Wrong: " + totalWrong);
            Console.Write("Question Numbers Wrong: ");
            for (int i = 0; i < wrongAnswers.Count; i++)
            {
                if(i < wrongAnswers.Count - 1)
                {
                    Console.Write(wrongAnswers[i] + ", ");
                }
                else
                {
                    Console.Write(wrongAnswers[i]); // comma at end bad
                }
            }
        }
    }
}
