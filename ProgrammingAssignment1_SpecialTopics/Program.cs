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
/// 30th November 2014
/// * Today I am coding the data extraction and template creation of more users.
/// * Also, I plan to write the method to calculate the genuine scores
/// * Wrote another method to extract the samples based on the sampling size given by the end user for analysis. Which thereby will make the 
/// next tasks that are required easier. 
/// </summary>

namespace ProgrammingAssignment1_SpecialTopics
{
    class Program
    {
        #region Static 2D double arrays which correspond to their respective data files
        static double[,] s002;
        static double[,] s003;
        static double[,] s004;
        static double[,] s005;
        static double[,] s007;
        static double[,] s008;
        static double[,] s010; 
        #endregion

        #region Static double arrays that represent the mean vectors of each user which will be used for genuine and impostor calculations
        static double[] mu_s002;
        static double[] mu_s003;
        static double[] mu_s004;
        static double[] mu_s005;
        static double[] mu_s007;
        static double[] mu_s008;
        static double[] mu_s010; 
        #endregion

        static void Main()
        {
            #region Header
            // Overall header for the Console
            Console.Write("===Programming Assignment 1===" + Environment.NewLine);

            // Adding a separation at the end of the header. 
            Console.Write("Pranav S. Krishnamurthy" + Environment.NewLine + "CSCI-860-W01: Biometrics and its Applications in a Networked Society" + Environment.NewLine);

            // Providing the instructions in the program when executing it. 
            Console.WriteLine("We will now be starting to take data from various users and begin to calculate various rates. Now, begin by selecting the user to analyze.  Keep in mind that the subject ID's will not be entered in.  Every user number that is between 1 and 51 and that the user number will be tied to the appropriate subject ID.");
            #endregion

            // This is the string for which the end user will determine which user will have the samples retrieved.
            string userNumber = Console.ReadLine();

            #region For user 1
            if (userNumber == "1")
            {
                // Initialization of the 2D array called s002.  
                s002 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s002.csv");

                // Prompting the user to now enter in the number of samples to be analyzed
                Console.Write("Enter N:  The number of samples. The value of N can be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine(); 
                
                // Extracting either 100, 200, or 300 samples from the specified user
                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    // Creating a new array called s002_Samples which denotes the double 2D array that will be used for the calculations of genuine and impostor scores
                    // which becomes populated with a method call as well. 
                    double[,] s002_Samples = ExtractSamples(s002, N); 

                    // Calculates the templates now and stores it in an array which can be used later on. 
                    mu_s002 = CalculateTemplateVectors(s002_Samples, N); 

                    // Printing out the template calculations
                    for (int i = 0; i < mu_s002.Length; i++)
                    {
                        Console.WriteLine(mu_s002[i]); 
                    } 
                }

                // If the user enters in a number that is not equal to either the three options listed
                else if (inputN != "100" || inputN != "200" || inputN != "300")
                {
                    Console.WriteLine("Your input sampling is too large, the program will quit");
                    Console.ReadKey(); 
                }
            }
            #endregion

            #region For user 2
            if (userNumber == "2")
            {
                // Referring to the second user
                s003 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s003.csv");

                // Prompting the user to enter in the number of samples to be analyzed. 
                Console.Write("Enter N: The number of samples. The value of N can be either 100, 200, or 300." + Environment.NewLine+ "N = ");
                string inputN = Console.ReadLine(); 

                if (inputN == "100"|| inputN == "200" || inputN == "300")
                {
                    // Creating the integer N, which is the sample size variable
                    int N = int.Parse(inputN);

                    // Again initializing an array of samples, again used through a method call. 
                    double[,] s003_Samples = ExtractSamples(s003, N); 

                    // Calling to the method which will calculate the Template Vectors. 
                    mu_s003 = CalculateTemplateVectors(s003_Samples, N); 

                    // Printing out the average vector given the value of N
                    for (int i = 0; i < mu_s003.Length; i++)
                    {
                        Console.WriteLine(mu_s003[i]); 
                    }
                }

                else if (inputN != "100" || inputN != "200" || inputN !="300")
                {
                    Console.Write("The sample size that you requested is too large.");
                    Console.ReadKey(); 
                }
            }
            #endregion

            #region For user 3
            if (userNumber == "3")
            {
                // Creating the 2D Double array3
                s004 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s004.csv");

                // Prompting the user       
                Console.Write("Enter N: The number of samples.  Value of N can be 100, 200 or 300." + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine(); 

                // Switching up the input in the if statement
                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    // The integer will be parsed from the string
                    int N = int.Parse(inputN);

                    // Populating the 2D double array via method call. 
                    double[,] s004_Samples = ExtractSamples(s004, N); 

                    // Method call to calculate the template vectors
                    mu_s004 = CalculateTemplateVectors(s004_Samples, N); 

                    // Printing out the template vector
                    for (int i = 0; i < mu_s004.Length; i++)
                    {
                        Console.WriteLine(mu_s004[i]); 
                    }
                }

                else if (inputN != "100" || inputN != "200" || inputN != "300")
                {
                    Console.Write("Your input sampling is too large, and the program will now quit");
                    Console.ReadKey();  
                }
            }
            #endregion

            #region For user 4
            if(userNumber == "4")
            {
                s005 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s005.csv");

                // Prompting the user to enter in the sample size
                Console.Write("Enter N: The number of samples.  Value of N can be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine(); 

                // If the inputN string which is the number of samples (initially parsed as a string) is either the values mentioned in the conditional
                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    // The local variable will have the extracted data
                    double[,] s005_Samples = ExtractSamples(s005, N); 

                    // Making the call to calculate the template vectors
                    mu_s005 = CalculateTemplateVectors(s005_Samples, N);
 
                    for(int i = 0; i < mu_s005.Length; i++)
                    {
                        Console.WriteLine(mu_s005[i]); 
                    }
                }

                else if (inputN != "100" || inputN != "200" || inputN != "300")
                {
                    Console.WriteLine("Your input sampling is too large, the program will now quit");
                    Console.ReadKey(); 
                }
            }
            #endregion

            #region For user 5
            if (userNumber == "5")
            {
                s007 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s007.csv");

                // Prompting the user to enter in the number of samples
                Console.Write("Enter N: The number of samples.  Value of N can either be 100, 200, or 300." + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine(); 

                // The code to execute when the number of samples equals one of the three options
                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s007_Samples = ExtractSamples(s007, N);  

                    mu_s007 = CalculateTemplateVectors(s007_Samples, N); 

                    for (int i = 0; i < mu_s007.Length; i++)
                    {
                        Console.WriteLine(mu_s007[i]); 
                    }
                }

                else if (inputN != "100" || inputN != "200" || inputN != "300")
                {
                    Console.WriteLine("Your input sampling is too large, the program will now quit");
                    Console.ReadKey(); 
                }
            }
            #endregion

            #region For user 6
            if (userNumber == "6")
            {
                s008 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s008.csv");

                // Prompting the user to enter the number of samples
                Console.Write("Enter N:  The number of samples. Value of N can be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine(); 

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s008_Samples = ExtractSamples(s008, N);

                    mu_s008 = CalculateTemplateVectors(s008_Samples, N); 

                    for (int i = 0; i < mu_s008.Length; i++)
                    {
                        Console.WriteLine(mu_s008[i]); 
                    }
                }

                else if (inputN != "100" || inputN != "200" || inputN != "300")
                {
                    Console.WriteLine("Your input sampling is too large, the program will now quit");
                    Console.ReadKey(); 
                }
            }
            #endregion

            #region For user 7
            if (userNumber == "7")
            {
                s010 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s010.csv");

                Console.Write("Enter N: The number of samples.  Value of N can be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine(); 

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s010_Samples = ExtractSamples(s010, N);

                    mu_s010 = CalculateTemplateVectors(s010_Samples, N); 

                    for (int i = 0; i < mu_s010.Length; i++)
                    {
                        Console.WriteLine(mu_s010[i]); 
                    }
                }

                else if (inputN != "100" || inputN != "200" || inputN != "300")
                {
                    Console.WriteLine("Your input sampling is too large, the program will now quit");
                    Console.ReadKey(); 
                }
            }
            #endregion

            Console.ReadKey(); // Default program termination
        }

        #region Sample extraction
        /// <summary>
        /// This method will be used to extract the samples given the parameter of the sampling size.  
        /// </summary>
        /// <param name="s002">The data that is extracted or converted from the CSV file</param>
        /// <param name="N">Sample size</param>
        /// <returns>samples - 2D double array which contains the samples from the original data</returns>
        static double[,] ExtractSamples(double[,] s002, int N)
        {
            double[,] samples = new double[N, 21]; 
            for (int n = 0; n < N; n++)
            {
                for (int j = 0; j < s002.GetLength(1); j++)
                {
                    samples[n, j] = s002[n, j]; 
                }
            }

            return samples; 
        }
        #endregion

        #region Template vector creation
        /// <summary>
        /// This method will calculate the template vectors using the user data
        /// </summary>
        /// <param name="s002_Samples">This is the array that has N samples extracted</param>
        /// <param name="N">Variable N, representing the sample size.  This value of N is used to generate the template data.</param>
        /// <returns>The average array that is called as mean</returns>
        static double[] CalculateTemplateVectors(double[,] s002_Samples, int N)
        {
            #region Creating two regular double arrays
            double[] sum = new double[s002_Samples.GetLength(1)];
            double[] mean = new double[s002_Samples.GetLength(1)];
            #endregion

            // Iterating over the 2D array in its entirety
            // Iterate over the rows of the 2D double array
            for (int i = 0; i < s002_Samples.GetLength(0); i++)
            {
                // Iterate over the columns of the 2D double array
                for (int j = 0; j < s002_Samples.GetLength(1); j++)
                {
                    // The sum array (one dimensional), in which each element is the 
                    // sum of each column in the samples array
                    sum[j] += s002_Samples[i, j]; 
                }
            }

            // Iterating over the mean array to
            for (int k = 0; k < mean.Length; k++)
            {
                mean[k] = sum[k] / N; 
            }

            return mean; 
        }
        #endregion

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
                    // Populating the double array with the data parsed from the CSV file
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