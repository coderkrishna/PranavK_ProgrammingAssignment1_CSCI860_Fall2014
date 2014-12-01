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
        #region Static 2D double arrays which correspond to their respective data files and these are used for training
        static double[,] s002; // User 1 - s002.csv
        static double[,] s003; // User 2 - s003.csv
        static double[,] s004; // User 3 - s004.csv
        static double[,] s005; // User 4 - s005.csv
        static double[,] s007; // User 5 - s007.csv
        static double[,] s008; // User 6 - s008.csv
        static double[,] s010; // User 7 - s010.csv
        static double[,] s011; // User 8 - s011.csv
        static double[,] s012; // User 9 - s012.csv
        static double[,] s013; // User 10 - s013.csv
        static double[,] s015; // User 11 - s015.csv
        static double[,] s016; // User 12 - s016.csv
        static double[,] s017; // User 13 - s017.csv
        static double[,] s018; // User 14 - s018.csv
        static double[,] s019; // User 15 - s019.csv
        static double[,] s020; // User 16 - s020.csv
        static double[,] s021; // User 17 - s021.csv
        static double[,] s022; // User 18 - s022.csv
        static double[,] s024; // User 19 - s024.csv
        static double[,] s025; // User 20 - s025.csv
        static double[,] s026; // User 21 - s026.csv
        static double[,] s027; // User 22 - s027.csv
        static double[,] s028; // User 23 - s028.csv
        static double[,] s029; // User 24 - s029.csv
        static double[,] s030; // User 25 - s030.csv
        static double[,] s031; // User 26 - s031.csv
        static double[,] s032; // User 27 - s032.csv
        static double[,] s033; // User 28 - s033.csv
        static double[,] s034; // User 29 - s034.csv
        static double[,] s035; // User 30 - s035.csv
        #endregion

        #region Static double arrays that represent the mean vectors of each user which will be used for genuine and impostor calculations
        static double[] mu_s002; // User 1
        static double[] mu_s003; // User 2
        static double[] mu_s004; // User 3
        static double[] mu_s005; // User 4
        static double[] mu_s007; // User 5
        static double[] mu_s008; // User 6
        static double[] mu_s010; // User 7
        static double[] mu_s011; // User 8
        static double[] mu_s012; // User 9
        static double[] mu_s013; // User 10
        static double[] mu_s015; // User 11
        static double[] mu_s016; // User 12
        static double[] mu_s017; // User 13
        static double[] mu_s018; // User 14
        static double[] mu_s019; // User 15
        static double[] mu_s020; // User 16
        static double[] mu_s021; // User 17
        static double[] mu_s022; // User 18
        static double[] mu_s024; // User 19
        static double[] mu_s025; // User 20
        static double[] mu_s026; // User 21
        static double[] mu_s027; // User 22
        static double[] mu_s028; // User 23
        static double[] mu_s029; // User 24
        static double[] mu_s030; // User 25
        static double[] mu_s031; // User 26
        static double[] mu_s032; // User 27
        static double[] mu_s033; // User 28
        static double[] mu_s034; // User 29
        static double[] mu_s035; // User 30
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

            #region For user 8
            if (userNumber == "8")
            {
                s011 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s011.csv");

                Console.Write("Enter N: The number of samples.  Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine(); 

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s011_Samples = ExtractSamples(s011, N);

                    mu_s011 = CalculateTemplateVectors(s011_Samples, N); 

                    for (int i = 0; i < mu_s011.Length; i++)
                    {
                        Console.WriteLine(mu_s011[i]); 
                    }
                }

                else if (inputN != "100" || inputN != "200" || inputN != "300")
                {
                    Console.WriteLine("Your input sampling is too large, the program will now quit");
                    Console.ReadKey(); 
                }
            }
            #endregion

            #region For user 9
            if (userNumber == "9")
            {
                s012 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s012.csv");

                Console.Write("Enter N: The number of samples.  Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine(); 

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s012_Samples = ExtractSamples(s012, N);

                    mu_s012 = CalculateTemplateVectors(s012_Samples, N); 

                    for (int i = 0; i < mu_s012.Length; i++)
                    {
                        Console.WriteLine(mu_s012[i]); 
                    }
                }

                else if (inputN != "100" || inputN != "200" || inputN != "300")
                {
                    Console.WriteLine("Your input sampling is too large, the program will now quit");
                    Console.ReadKey(); 
                }
            }
            #endregion

            #region For user 10
            if (userNumber == "10")
            {
                s013 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s013.csv");

                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine(); 

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s013_Samples = ExtractSamples(s013, N);

                    mu_s013 = CalculateTemplateVectors(s013_Samples, N); 

                    for (int i = 0; i < mu_s013.Length; i++)
                    {
                        Console.WriteLine(mu_s013[i]); 
                    }
                }

                else if (inputN != "100" || inputN != "200" || inputN != "300")
                {
                    Console.WriteLine("Your input sampling is too large, the program will now quit");
                    Console.ReadKey(); 
                }
            }
            #endregion

            #region For user 11
            if (userNumber == "11")
            {
                s015 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s015.csv");

                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine(); 

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s015_Samples = ExtractSamples(s015, N);

                    mu_s015 = CalculateTemplateVectors(s015_Samples, N); 

                    for (int i = 0; i < mu_s015.Length; i++)
                    {
                        Console.WriteLine(mu_s015[i]); 
                    }
                }

                else if (inputN != "100" || inputN != "200" || inputN != "300")
                {
                    Console.WriteLine("Your input sampling is too large, the program will now quit");
                    Console.ReadKey(); 
                }
            }
            #endregion

            #region For user 12
            if (userNumber == "12")
            {
                s016 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s016.csv");

                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine(); 

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s016_Samples = ExtractSamples(s016, N);

                    mu_s016 = CalculateTemplateVectors(s016_Samples, N); 

                    for (int i = 0; i < mu_s016.Length; i++)
                    {
                        Console.WriteLine(mu_s016[i]); 
                    }
                }

                else if (inputN != "100" || inputN != "200" || inputN != "300")
                {
                    Console.WriteLine("Your input sampling is too large, the program will now quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For user 13
            if (userNumber == "13")
            {
                s017 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s017.csv");

                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine(); 

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s017_Samples = ExtractSamples(s017, N);

                    mu_s017 = CalculateTemplateVectors(s017_Samples, N); 

                    for (int i = 0; i < mu_s017.Length; i++)
                    {
                        Console.WriteLine(mu_s017[i]); 
                    }
                }

                else if (inputN != "100" || inputN == "200" || inputN != "300")
                {
                    Console.WriteLine("Your input sampling is too large, the program will now quit");
                    Console.ReadKey(); 
                }
            }
            #endregion

            #region For user 14
            if (userNumber == "14")
            {
                s018 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s018.csv");

                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s018_Samples = ExtractSamples(s018, N);

                    mu_s018 = CalculateTemplateVectors(s018_Samples, N);

                    for (int i = 0; i < mu_s018.Length; i++)
                    {
                        Console.WriteLine(mu_s018[i]);
                    }
                }

                else if (inputN != "100" || inputN == "200" || inputN != "300")
                {
                    Console.WriteLine("Your input sampling is too large, the program will now quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For user 15
            if (userNumber == "15")
            {
                s019 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s019.csv");

                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s019_Samples = ExtractSamples(s019, N);

                    mu_s019 = CalculateTemplateVectors(s019_Samples, N);

                    for (int i = 0; i < mu_s019.Length; i++)
                    {
                        Console.WriteLine(mu_s019[i]);
                    }
                }

                else if (inputN != "100" || inputN == "200" || inputN != "300")
                {
                    Console.WriteLine("Your input sampling is too large, the program will now quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For user 16
            if (userNumber == "16")
            {
                s020 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s020.csv");

                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s020_Samples = ExtractSamples(s020, N);

                    mu_s020 = CalculateTemplateVectors(s020_Samples, N);

                    for (int i = 0; i < mu_s020.Length; i++)
                    {
                        Console.WriteLine(mu_s020[i]);
                    }
                }

                else if (inputN != "100" || inputN == "200" || inputN != "300")
                {
                    Console.WriteLine("Your input sampling is too large, the program will now quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For user 17
            if (userNumber == "17")
            {
                s021 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s021.csv");

                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s021_Samples = ExtractSamples(s021, N);

                    mu_s021 = CalculateTemplateVectors(s021_Samples, N);

                    for (int i = 0; i < mu_s021.Length; i++)
                    {
                        Console.WriteLine(mu_s021[i]);
                    }
                }

                else if (inputN != "100" || inputN == "200" || inputN != "300")
                {
                    Console.WriteLine("Your input sampling is too large, the program will now quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For user 18
            if (userNumber == "18")
            {
                s022 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s022.csv");

                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s022_Samples = ExtractSamples(s022, N);

                    mu_s022 = CalculateTemplateVectors(s022_Samples, N);

                    for (int i = 0; i < mu_s022.Length; i++)
                    {
                        Console.WriteLine(mu_s022[i]);
                    }
                }

                else if (inputN != "100" || inputN == "200" || inputN != "300")
                {
                    Console.WriteLine("Your input sampling is too large, the program will now quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For user 19
            if (userNumber == "19")
            {
                s024 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s024.csv");

                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s024_Samples = ExtractSamples(s024, N);

                    mu_s024 = CalculateTemplateVectors(s024_Samples, N);

                    for (int i = 0; i < mu_s024.Length; i++)
                    {
                        Console.WriteLine(mu_s024[i]);
                    }
                }

                else if (inputN != "100" || inputN == "200" || inputN != "300")
                {
                    Console.WriteLine("Your input sampling is too large, the program will now quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For user 20
            if (userNumber == "20")
            {
                s025 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s025.csv");

                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s025_Samples = ExtractSamples(s025, N);

                    mu_s025 = CalculateTemplateVectors(s025_Samples, N);

                    for (int i = 0; i < mu_s025.Length; i++)
                    {
                        Console.WriteLine(mu_s025[i]);
                    }
                }

                else if (inputN != "100" || inputN == "200" || inputN != "300")
                {
                    Console.WriteLine("Your input sampling is too large, the program will now quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For user 21
            if (userNumber == "21")
            {
                s026 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s026.csv");

                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s026_Samples = ExtractSamples(s026, N);

                    mu_s026 = CalculateTemplateVectors(s026_Samples, N);

                    for (int i = 0; i < mu_s026.Length; i++)
                    {
                        Console.WriteLine(mu_s026[i]);
                    }
                }

                else if (inputN != "100" || inputN == "200" || inputN != "300")
                {
                    Console.WriteLine("Your input sampling is too large, the program will now quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For user 22
            if (userNumber == "22")
            {
                s027 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s027.csv");

                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s027_Samples = ExtractSamples(s027, N);

                    mu_s027 = CalculateTemplateVectors(s027_Samples, N);

                    for (int i = 0; i < mu_s027.Length; i++)
                    {
                        Console.WriteLine(mu_s027[i]);
                    }
                }

                else if (inputN != "100" || inputN == "200" || inputN != "300")
                {
                    Console.WriteLine("Your input sampling is too large, the program will now quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For user 23
            if (userNumber == "23")
            {
                s028 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s028.csv");

                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s028_Samples = ExtractSamples(s028, N);

                    mu_s028 = CalculateTemplateVectors(s028_Samples, N);

                    for (int i = 0; i < mu_s028.Length; i++)
                    {
                        Console.WriteLine(mu_s028[i]);
                    }
                }

                else if (inputN != "100" || inputN == "200" || inputN != "300")
                {
                    Console.WriteLine("Your input sampling is too large, the program will now quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For user 24
            if (userNumber == "24")
            {
                s029 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s029.csv");

                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s029_Samples = ExtractSamples(s029, N);

                    mu_s029 = CalculateTemplateVectors(s029_Samples, N);

                    for (int i = 0; i < mu_s029.Length; i++)
                    {
                        Console.WriteLine(mu_s029[i]);
                    }
                }

                else if (inputN != "100" || inputN == "200" || inputN != "300")
                {
                    Console.WriteLine("Your input sampling is too large, the program will now quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For user 25
            if (userNumber == "25")
            {
                s030 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s030.csv");

                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s030_Samples = ExtractSamples(s030, N);

                    mu_s030 = CalculateTemplateVectors(s030_Samples, N);

                    for (int i = 0; i < mu_s030.Length; i++)
                    {
                        Console.WriteLine(mu_s030[i]);
                    }
                }

                else if (inputN != "100" || inputN == "200" || inputN != "300")
                {
                    Console.WriteLine("Your input sampling is too large, the program will now quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For user 26
            if (userNumber == "26")
            {
                s031 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s031.csv");

                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s031_Samples = ExtractSamples(s031, N);

                    mu_s031 = CalculateTemplateVectors(s031_Samples, N);

                    for (int i = 0; i < mu_s031.Length; i++)
                    {
                        Console.WriteLine(mu_s031[i]);
                    }
                }

                else if (inputN != "100" || inputN == "200" || inputN != "300")
                {
                    Console.WriteLine("Your input sampling is too large, the program will now quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For user 27
            if (userNumber == "27")
            {
                s032 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s032.csv");

                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s032_Samples = ExtractSamples(s032, N);

                    mu_s032 = CalculateTemplateVectors(s032_Samples, N);

                    for (int i = 0; i < mu_s032.Length; i++)
                    {
                        Console.WriteLine(mu_s032[i]);
                    }
                }

                else if (inputN != "100" || inputN == "200" || inputN != "300")
                {
                    Console.WriteLine("Your input sampling is too large, the program will now quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For user 28
            if (userNumber == "28")
            {
                s033 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s033.csv");

                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s033_Samples = ExtractSamples(s033, N);

                    mu_s033 = CalculateTemplateVectors(s033_Samples, N);

                    for (int i = 0; i < mu_s033.Length; i++)
                    {
                        Console.WriteLine(mu_s033[i]);
                    }
                }

                else if (inputN != "100" || inputN == "200" || inputN != "300")
                {
                    Console.WriteLine("Your input sampling is too large, the program will now quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For user 29
            if (userNumber == "29")
            {
                s034 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s034.csv");

                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s034_Samples = ExtractSamples(s034, N);

                    mu_s034 = CalculateTemplateVectors(s034_Samples, N);

                    for (int i = 0; i < mu_s034.Length; i++)
                    {
                        Console.WriteLine(mu_s034[i]);
                    }
                }

                else if (inputN != "100" || inputN == "200" || inputN != "300")
                {
                    Console.WriteLine("Your input sampling is too large, the program will now quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For user 30
            if (userNumber == "30")
            {
                s035 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s035.csv");

                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s035_Samples = ExtractSamples(s035, N);

                    mu_s035 = CalculateTemplateVectors(s035_Samples, N);

                    for (int i = 0; i < mu_s035.Length; i++)
                    {
                        Console.WriteLine(mu_s035[i]);
                    }
                }

                else if (inputN != "100" || inputN == "200" || inputN != "300")
                {
                    Console.WriteLine("Your input sampling is too large, the program will now quit");
                    Console.ReadKey();
                }
            }
            #endregion

            Console.ReadKey(); // Default program termination
        }

        #region Extraction of samples based on the value of N
        /// <summary>
        /// This method will be used to extract the samples given the parameter of the sampling size.  
        /// </summary>
        /// <param name="s002">The data that is extracted or converted from the CSV file</param>
        /// <param name="N">Sample size</param>
        /// <returns>samples - 2D double array which contains the samples from the original data</returns>
        static double[,] ExtractSamples(double[,] s002, int N)
        {
            // Initialize the 2D double array
            double[,] samples = new double[N, 21]; 

            // Iterating over a nested for loop.
            for (int n = 0; n < N; n++)
            {
                for (int j = 0; j < s002.GetLength(1); j++)
                {
                    // Having the 2D double array being populated. 
                    samples[n, j] = s002[n, j]; 
                }
            }

            // This is what will be returned and this variable will automatically undergo polymorphism
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