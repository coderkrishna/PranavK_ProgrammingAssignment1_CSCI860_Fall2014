﻿#region These are the using statements, which function like the import statements for the Java programming language
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
/// 28th November 2014
/// * I plan to code the template creation, genuine score calculation, and the impostor score calculation methods today.  
/// * I will adjust the parameters accordingly, and will also have to code the various method calls to extract the data
/// from all of the CSV files. 
/// * Making the end useability as seamless and as clear as possible. 
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

            // Adding a separation at the end of the header. 
            Console.Write("Pranav S. Krishnamurthy" + Environment.NewLine + "CSCI-860-W01: Biometrics and its Applications in a Networked Society" + Environment.NewLine);

            // Providing the instructions in the program when executing it. 
            Console.WriteLine("We will now be starting to take data from various users and begin to calculate various rates. Now, begin by selecting the user to analyze.  Keep in mind that the subject ID's will not be entered in.  Every user number that is between 1 and 51.  That will automatically then tie the user number to the appropriate CSV file.");
            #endregion

            // This is the string for which the end user will determine which user will have the samples retrieved.
            string userNumber = Console.ReadLine();

            #region For user 1 
            if (userNumber == "1")
            {
                // Initialization of the 2D array called s002.  
                double[,] s002 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s002.csv");

                // Prompting the user to now enter in the number of samples to be analyzed
                Console.Write("Enter the value of N, the number of samples upon which the analysis will be conducted.  The value of N can be either 100, 200, or 300" + Environment.NewLine);
                string inputN = Console.ReadLine(); 
                
                // Extracting either 100, 200, or 300 samples from the specified user
                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    // Creating a new array called s002_100 which denotes the double 2D array that will be used for the calculations
                    // of genuine and impostor scores
                    double[,] s002_Samples = new double[N, 21]; 

                    for (int n = 0; n < N; n++)
                    {
                        for (int j = 0; j < s002.GetLength(1); j++)
                        {
                            // Making sure that we are able to extract the first 100 samples and then from that 
                            // we can be able to make the various calculations
                            s002_Samples[n, j] = s002[n, j]; 

                            // Printing out the 2D double array that contains the first 100 samples. 
                            Console.Write(s002_Samples[n, j] + " "); 
                        }
                        // Row separator
                        Console.Write(Environment.NewLine); 
                    }

                    // TODO: Calculate the templates now and store it in an array
                }

                // If the user enters in a number that is not equal to either the three options listed
                if (inputN != "100" || inputN != "200" || inputN != "300")
                {
                    Console.WriteLine("Your input sampling is too large, the program will quit");
                    Console.ReadKey(); 
                }
            }
            #endregion

            #region For user 2
            if (userNumber == "2")
            {
                double[,] s003 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s003.csv"); 
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
        /// <returns>2D Double array with dimensions of 400 rows and 21 columns</returns>
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