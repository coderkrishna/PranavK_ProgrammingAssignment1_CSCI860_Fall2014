#region These are the using statements, which function like the import statements for the Java programming language
using System;
using System.IO; // This is required for File I/O
using System.Collections.Generic;
using System.Linq;
using System.Text;
#endregion

/// <summary>
/// Pranav Krishnamurthy
/// Programming Assignment 1
/// CSCI-860-W01: Biometrics and its Applications in a Networked Society
/// Instructor: Dr. Kiran Balagani
/// 
/// 26th November 2014
/// * Finally, I have been able to get going on the formal programming of this assignment.
/// * Here, I can be able to extract N samples from a CSV file properly.  
/// * Next here, the template generation is going to be key, and then genuine and impostor score generation using the 
/// samples.  Finally, I have to be able to calculate the False Accept and False Reject rates at various thresholds.  
/// </summary>

namespace ProgrammingAssignment1_SpecialTopics
{
    class Program
    {
        static void Main()
        {
            #region Header
            // Overall header for the Console
            Console.Write("===Programming Assignment 1===" + Environment.NewLine);
            Console.Write("Pranav S. Krishnamurthy" + Environment.NewLine + "CSCI-860-W01: Biometrics and its Applications in a Networked Society");
            Console.WriteLine("We will now be starting to take data from various users and begin to calculate various rates. Now, begin by selecting the user to analyze.");
            #endregion

            // This is the string for which the end user will determine which user will have the samples retrieved.
            string userNumber = Console.ReadLine();

            #region One of 50 if statements to be coded for extracting data.  
            if (userNumber == "1")
            {
                // Initialization of the 2D array called s002.  
                double[,] s002 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s002.csv");

                // Prompting the user to now enter in the number of samples to be analyzed
                Console.Write("Enter the value of N, the number of samples upon which the analysis will be conducted.");
                string inputN = Console.ReadLine(); 

                if (inputN == "100")
                {
                    int N = int.Parse(inputN); 

                    for (int n = 0; n < N; n++)
                    {
                        for (int j = 0; j < s002.GetLength(1); j++)
                        {
                            Console.Write(s002[n, j] + " "); 
                        }
                        Console.Write(Environment.NewLine); 
                    }
                }
            }
            #endregion

            Console.ReadKey(); // Default program termination
        }

        #region CSV to 2D double array conversion
        /// <summary>
        /// This method will now convert the CSV files into 
        /// 2D double arrays
        /// </summary>
        /// <param name="filePath">The location of the CSV file</param>
        /// <returns></returns>
        static double[,] ParseData(string filePath)
        {
            // I am using the String class, and will now be able to begin to convert the CSV file
            // into a 2D double array
            String input = File.ReadAllText(filePath); 

            // Initialize the counters
            int i = 0, j = 0;

            // Initialize the new 2D double array which has 400 rows and 21 columns
            double[,] values = new double[400, 21]; 

            // Using a nested foreach loop so that way I can be able to use the new line delimeter to break up the rows and the comma delimiter to remove the 
            // commas which separates each element. 
            foreach (var row in input.Split('\n'))
            {
                j = 0; 
                
                // Again using the nested foreach loop in order to remove the comma which separates the various values. 
                foreach (var col in row.Trim().Split(','))
                {
                    values[i, j] = double.Parse(col.Trim());
                    j++; // Increment the column
                }
                i++; // Increment the row
            }

            // Outputs the 2D double array called values, which in turn becomes the 
            // 2D double array called 
            return values;
        }
        #endregion
    }
}