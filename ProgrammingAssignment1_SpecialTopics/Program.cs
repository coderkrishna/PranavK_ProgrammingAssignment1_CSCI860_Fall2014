#region These are the using statements, which function like the import statements for the Java programming language
using System;
using System.IO; // This is required for File I/O
using System.Collections.Generic;
using System.Linq;
using System.Text;
#endregion

namespace ProgrammingAssignment1_SpecialTopics
{
    /// <summary>
    /// Pranav Krishnamurthy
    /// Programming Assignment 1
    /// CSCI-860-W01: Biometrics and its Applications in a Networked Society
    /// Instructor: Dr. Kiran Balagani
    ///  
    /// 2nd December 2014 - Deadline/Submission date
    /// Here are the following that I tasks that I need to get done today:
    /// * Code and execute all the impostor scores
    /// * Find a way that I can begin to report the FAR and FRR
    /// * Compile the report - Started
    /// 
    /// Accomplishments: 
    /// * Genuine score - Coded and function calls made
    /// </summary>
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
        static double[,] s036; // User 31 - s036.csv
        static double[,] s037; // User 32 - s037.csv
        static double[,] s038; // User 33 - s038.csv
        static double[,] s039; // User 34 - s039.csv
        static double[,] s040; // User 35 - s040.csv
        static double[,] s041; // User 36 - s041.csv
        static double[,] s042; // User 37 - s042.csv
        static double[,] s043; // User 38 - s043.csv
        static double[,] s044; // User 39 - s044.csv
        static double[,] s046; // User 40 - s046.csv
        static double[,] s047; // User 41 - s047.csv
        static double[,] s048; // User 42 - s048.csv
        static double[,] s049; // User 43 - s049.csv
        static double[,] s050; // User 44 - s050.csv
        static double[,] s051; // User 45 - s051.csv
        static double[,] s052; // User 46 - s052.csv
        static double[,] s053; // User 47 - s053.csv
        static double[,] s054; // User 48 - s054.csv
        static double[,] s055; // User 49 - s055.csv
        static double[,] s056; // User 50 - s056.csv
        static double[,] s057; // User 51 - s057.csv
        #endregion

        #region Static double arrays that represent the mean vectors of each user which will be used for genuine and zero effort impostor calculations
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
        static double[] mu_s036; // User 31
        static double[] mu_s037; // User 32
        static double[] mu_s038; // User 33
        static double[] mu_s039; // User 34
        static double[] mu_s040; // User 35
        static double[] mu_s041; // User 36
        static double[] mu_s042; // User 37
        static double[] mu_s043; // User 38
        static double[] mu_s044; // User 39
        static double[] mu_s046; // User 40
        static double[] mu_s047; // User 41
        static double[] mu_s048; // User 42
        static double[] mu_s049; // User 43
        static double[] mu_s050; // User 44
        static double[] mu_s051; // User 45
        static double[] mu_s052; // User 46
        static double[] mu_s053; // User 47
        static double[] mu_s054; // User 48
        static double[] mu_s055; // User 49
        static double[] mu_s056; // User 50
        static double[] mu_s057; // User 51
        #endregion

        #region Static 2D double arrays that will be used for genuine and impostor score calculations
        static double[,] s002_Test; // User 1
        static double[,] s003_Test; // User 2
        static double[,] s004_Test; // User 3
        static double[,] s005_Test; // User 4
        static double[,] s007_Test; // User 5
        static double[,] s008_Test; // User 6
        static double[,] s010_Test; // User 7
        static double[,] s011_Test; // User 8
        static double[,] s012_Test; // User 9
        static double[,] s013_Test; // User 10
        static double[,] s015_Test; // User 11
        static double[,] s016_Test; // User 12
        static double[,] s017_Test; // User 13
        static double[,] s018_Test; // User 14
        static double[,] s019_Test; // User 15
        static double[,] s020_Test; // User 16
        static double[,] s021_Test; // User 17
        static double[,] s022_Test; // User 18
        static double[,] s024_Test; // User 19
        static double[,] s025_Test; // User 20
        static double[,] s026_Test; // User 21
        static double[,] s027_Test; // User 22
        static double[,] s028_Test; // User 23
        static double[,] s029_Test; // User 24
        static double[,] s030_Test; // User 25
        static double[,] s031_Test; // User 26
        static double[,] s032_Test; // User 27
        static double[,] s033_Test; // User 28
        static double[,] s034_Test; // User 29
        static double[,] s035_Test; // User 30
        static double[,] s036_Test; // User 31
        static double[,] s037_Test; // User 32
        static double[,] s038_Test; // User 33
        static double[,] s039_Test; // User 34
        static double[,] s040_Test; // User 35
        static double[,] s041_Test; // User 36
        static double[,] s042_Test; // User 37
        static double[,] s043_Test; // User 38
        static double[,] s044_Test; // User 39
        static double[,] s046_Test; // User 40
        static double[,] s047_Test; // User 41
        static double[,] s048_Test; // User 42
        static double[,] s049_Test; // User 43
        static double[,] s050_Test; // User 44
        static double[,] s051_Test; // User 45
        static double[,] s052_Test; // User 46
        static double[,] s053_Test; // User 47
        static double[,] s054_Test; // User 48
        static double[,] s055_Test; // User 49
        static double[,] s056_Test; // User 50
        static double[,] s057_Test; // User 51
        #endregion

        #region Static double arrays that represent the genuine vectors
        static double[] s002_Genuine;
        static double[] s003_Genuine;
        static double[] s004_Genuine;
        static double[] s005_Genuine;
        static double[] s007_Genuine;
        static double[] s008_Genuine;
        static double[] s010_Genuine;
        static double[] s011_Genuine;
        static double[] s012_Genuine;
        static double[] s013_Genuine;
        static double[] s015_Genuine;
        static double[] s016_Genuine;
        static double[] s017_Genuine;
        static double[] s018_Genuine;
        static double[] s019_Genuine;
        static double[] s020_Genuine;
        static double[] s021_Genuine;
        static double[] s022_Genuine;
        static double[] s024_Genuine;
        static double[] s025_Genuine;
        static double[] s026_Genuine;
        static double[] s027_Genuine;
        static double[] s028_Genuine;
        static double[] s029_Genuine;
        static double[] s030_Genuine;
        static double[] s031_Genuine;
        static double[] s032_Genuine;
        static double[] s033_Genuine;
        static double[] s034_Genuine;
        static double[] s035_Genuine;
        static double[] s036_Genuine;
        static double[] s037_Genuine;
        static double[] s038_Genuine;
        static double[] s039_Genuine;
        static double[] s040_Genuine;
        static double[] s041_Genuine;
        static double[] s042_Genuine;
        static double[] s043_Genuine;
        static double[] s044_Genuine;
        static double[] s046_Genuine;
        static double[] s047_Genuine;
        static double[] s048_Genuine;
        static double[] s049_Genuine;
        static double[] s050_Genuine;
        static double[] s051_Genuine;
        static double[] s052_Genuine;
        static double[] s053_Genuine;
        static double[] s054_Genuine;
        static double[] s055_Genuine;
        static double[] s056_Genuine;
        static double[] s057_Genuine;
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
                    // N represents the number of training samples
                    int N = int.Parse(inputN);
                    
                    // Creating a new array called s002_Samples which denotes the double 2D array that will be used for the calculations of genuine and impostor scores
                    // which becomes populated with a method call as well. 
                    double[,] s002_Samples = ExtractTrainingSamples(s002, N);

                    // Calculates the templates now and stores it in an array which can be used later on. 
                    mu_s002 = CalculateTemplateVectors(s002_Samples, N); 

                    // Here is the method call to extract the 400 - N test samples that will be used to calculate both the
                    // genuine and impostor scores
                    s002_Test = ExtractTestingSamples(s002, N);

                    // Making the method call to generate the various genuine scores for user 1
                    s002_Genuine = CalculateGenuineScores(s002_Test, mu_s002, N);

                    // Pulling all the test vectors from the other users and calculating the zero-effort impostor scores
                    CalculateImpostorScores(mu_s002, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N); 
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
                    double[,] s003_Samples = ExtractTrainingSamples(s003, N); 

                    // Calling to the method which will calculate the Template Vectors. 
                    mu_s003 = CalculateTemplateVectors(s003_Samples, N); 

                    s003_Test = ExtractTestingSamples(s003, N);

                    s003_Genuine = CalculateGenuineScores(s003_Test, mu_s003, N);
                }

                else if (inputN != "100" || inputN != "200" || inputN !="300")
                {
                    Console.Write("The sample size that you requested is too large, the program will now quit");
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
                    double[,] s004_Samples = ExtractTrainingSamples(s004, N); 

                    // Method call to calculate the template vectors
                    mu_s004 = CalculateTemplateVectors(s004_Samples, N); 

                    s004_Test = ExtractTestingSamples(s004, N);

                    s004_Genuine = CalculateGenuineScores(s004_Test, mu_s004, N); 
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
                    double[,] s005_Samples = ExtractTrainingSamples(s005, N); 

                    // Making the call to calculate the template vectors
                    mu_s005 = CalculateTemplateVectors(s005_Samples, N);
 
                    s005_Test = ExtractTestingSamples(s005, N);

                    s005_Genuine = CalculateGenuineScores(s005_Test, mu_s005, N);
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

                    double[,] s007_Samples = ExtractTrainingSamples(s007, N);  

                    mu_s007 = CalculateTemplateVectors(s007_Samples, N); 

                    s007_Test = ExtractTestingSamples(s007, N);

                    s007_Genuine = CalculateGenuineScores(s007_Test, mu_s007, N); 
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

                    double[,] s008_Samples = ExtractTrainingSamples(s008, N);

                    mu_s008 = CalculateTemplateVectors(s008_Samples, N); 

                    s008_Test = ExtractTestingSamples(s008, N);

                    s008_Genuine = CalculateGenuineScores(s008_Test, mu_s008, N); 
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

                    double[,] s010_Samples = ExtractTrainingSamples(s010, N);

                    mu_s010 = CalculateTemplateVectors(s010_Samples, N); 

                    s010_Test = ExtractTestingSamples(s010, N);

                    s010_Genuine = CalculateGenuineScores(s010_Test, mu_s010, N); 
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

                    double[,] s011_Samples = ExtractTrainingSamples(s011, N);

                    mu_s011 = CalculateTemplateVectors(s011_Samples, N); 

                    s011_Test = ExtractTestingSamples(s011, N);

                    s011_Genuine = CalculateGenuineScores(s011_Test, mu_s011, N); 
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

                    double[,] s012_Samples = ExtractTrainingSamples(s012, N);

                    mu_s012 = CalculateTemplateVectors(s012_Samples, N); 

                    s012_Test = ExtractTestingSamples(s012, N);

                    s012_Genuine = CalculateGenuineScores(s012_Test, mu_s012, N); 
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

                    double[,] s013_Samples = ExtractTrainingSamples(s013, N);

                    mu_s013 = CalculateTemplateVectors(s013_Samples, N); 

                    s013_Test = ExtractTestingSamples(s013, N);

                    s013_Genuine = CalculateGenuineScores(s013_Test, mu_s013, N);
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

                    double[,] s015_Samples = ExtractTrainingSamples(s015, N);

                    mu_s015 = CalculateTemplateVectors(s015_Samples, N); 

                    s015_Test = ExtractTestingSamples(s015, N);

                    s015_Genuine = CalculateGenuineScores(s015_Test, mu_s015, N);
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

                    double[,] s016_Samples = ExtractTrainingSamples(s016, N);

                    mu_s016 = CalculateTemplateVectors(s016_Samples, N); 

                    s016_Test = ExtractTestingSamples(s016, N);

                    s016_Genuine = CalculateGenuineScores(s016_Test, mu_s016, N);
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

                    double[,] s017_Samples = ExtractTrainingSamples(s017, N);

                    mu_s017 = CalculateTemplateVectors(s017_Samples, N); 

                    s017_Test = ExtractTestingSamples(s017, N);

                    s017_Genuine = CalculateGenuineScores(s017_Test, mu_s017, N);
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

                    double[,] s018_Samples = ExtractTrainingSamples(s018, N);

                    mu_s018 = CalculateTemplateVectors(s018_Samples, N);

                    s018_Test = ExtractTestingSamples(s018, N);

                    s018_Genuine = CalculateGenuineScores(s018_Test, mu_s018, N); 
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

                    double[,] s019_Samples = ExtractTrainingSamples(s019, N);

                    mu_s019 = CalculateTemplateVectors(s019_Samples, N);

                    s019_Test = ExtractTestingSamples(s019, N);

                    s019_Genuine = CalculateGenuineScores(s019_Test, mu_s019, N); 
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

                    double[,] s020_Samples = ExtractTrainingSamples(s020, N);

                    mu_s020 = CalculateTemplateVectors(s020_Samples, N);

                    s020_Test = ExtractTestingSamples(s020, N);

                    s020_Genuine = CalculateGenuineScores(s020_Test, mu_s020, N); 
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

                    double[,] s021_Samples = ExtractTrainingSamples(s021, N);

                    mu_s021 = CalculateTemplateVectors(s021_Samples, N);

                    s021_Test = ExtractTestingSamples(s021, N);

                    s021_Genuine = CalculateGenuineScores(s021_Test, mu_s021, N); 
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

                    double[,] s022_Samples = ExtractTrainingSamples(s022, N);

                    mu_s022 = CalculateTemplateVectors(s022_Samples, N);

                    s022_Test = ExtractTestingSamples(s022, N);

                    s022_Genuine = CalculateGenuineScores(s022_Test, mu_s022, N); 
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

                    double[,] s024_Samples = ExtractTrainingSamples(s024, N);

                    mu_s024 = CalculateTemplateVectors(s024_Samples, N);

                    s024_Test = ExtractTestingSamples(s024, N);

                    s024_Genuine = CalculateGenuineScores(s024_Test, mu_s024, N); 
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

                    double[,] s025_Samples = ExtractTrainingSamples(s025, N);

                    mu_s025 = CalculateTemplateVectors(s025_Samples, N);

                    s025_Test = ExtractTestingSamples(s025, N);

                    s025_Genuine = CalculateGenuineScores(s025_Test, mu_s025, N); 
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

                    double[,] s026_Samples = ExtractTrainingSamples(s026, N);

                    mu_s026 = CalculateTemplateVectors(s026_Samples, N);

                    s026_Test = ExtractTestingSamples(s026, N);

                    s026_Genuine = CalculateGenuineScores(s026_Test, mu_s026, N); 
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

                    double[,] s027_Samples = ExtractTrainingSamples(s027, N);

                    mu_s027 = CalculateTemplateVectors(s027_Samples, N);

                    s027_Test = ExtractTestingSamples(s027, N);

                    s027_Genuine = CalculateGenuineScores(s027_Test, mu_s027, N); 
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

                    double[,] s028_Samples = ExtractTrainingSamples(s028, N);

                    mu_s028 = CalculateTemplateVectors(s028_Samples, N);

                    s028_Test = ExtractTestingSamples(s028, N);

                    s028_Genuine = CalculateGenuineScores(s028_Test, mu_s028, N); 
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

                    double[,] s029_Samples = ExtractTrainingSamples(s029, N);

                    mu_s029 = CalculateTemplateVectors(s029_Samples, N);

                    s029_Test = ExtractTestingSamples(s029, N);

                    s029_Genuine = CalculateGenuineScores(s029_Test, mu_s029, N);
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

                    double[,] s030_Samples = ExtractTrainingSamples(s030, N);

                    mu_s030 = CalculateTemplateVectors(s030_Samples, N);

                    s030_Test = ExtractTestingSamples(s030, N);

                    s030_Genuine = CalculateGenuineScores(s030_Test, mu_s030, N); 
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

                    double[,] s031_Samples = ExtractTrainingSamples(s031, N);

                    mu_s031 = CalculateTemplateVectors(s031_Samples, N);

                    s031_Test = ExtractTestingSamples(s031, N);

                    s031_Genuine = CalculateGenuineScores(s031_Test, mu_s031, N); 
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

                    double[,] s032_Samples = ExtractTrainingSamples(s032, N);

                    mu_s032 = CalculateTemplateVectors(s032_Samples, N);

                    s032_Test = ExtractTestingSamples(s032, N);

                    s032_Genuine = CalculateGenuineScores(s032_Test, mu_s032, N); 
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

                    double[,] s033_Samples = ExtractTrainingSamples(s033, N);

                    mu_s033 = CalculateTemplateVectors(s033_Samples, N);

                    s033_Test = ExtractTestingSamples(s033, N);

                    s033_Genuine = CalculateGenuineScores(s033_Test, mu_s033, N); 
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

                    double[,] s034_Samples = ExtractTrainingSamples(s034, N);

                    mu_s034 = CalculateTemplateVectors(s034_Samples, N);

                    s034_Test = ExtractTestingSamples(s034, N);

                    s034_Genuine = CalculateGenuineScores(s034_Test, mu_s034, N); 
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

                    double[,] s035_Samples = ExtractTrainingSamples(s035, N);

                    mu_s035 = CalculateTemplateVectors(s035_Samples, N);

                    s035_Test = ExtractTestingSamples(s035, N);

                    s035_Genuine = CalculateGenuineScores(s035_Test, mu_s035, N); 
                }

                else if (inputN != "100" || inputN == "200" || inputN != "300")
                {
                    Console.WriteLine("Your input sampling is too large, the program will now quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For user 31
            if (userNumber == "31")
            {
                s036 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s036.csv");

                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s036_Samples = ExtractTrainingSamples(s036, N);

                    mu_s036 = CalculateTemplateVectors(s036_Samples, N);

                    s036_Test = ExtractTestingSamples(s036, N);

                    s036_Genuine = CalculateGenuineScores(s036_Test, mu_s036, N); 
                }

                else if (inputN != "100" || inputN == "200" || inputN != "300")
                {
                    Console.WriteLine("Your input sampling is too large, the program will now quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For user 32
            if (userNumber == "32")
            {
                s037 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s037.csv");

                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s037_Samples = ExtractTrainingSamples(s037, N);

                    mu_s037 = CalculateTemplateVectors(s037_Samples, N);

                    s037_Test = ExtractTestingSamples(s037, N);

                    s037_Genuine = CalculateGenuineScores(s037_Test, mu_s037, N);
                }

                else if (inputN != "100" || inputN == "200" || inputN != "300")
                {
                    Console.WriteLine("Your input sampling is too large, the program will now quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For user 33
            if (userNumber == "33")
            {
                s038 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s038.csv");

                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s038_Samples = ExtractTrainingSamples(s038, N);

                    mu_s038 = CalculateTemplateVectors(s038_Samples, N);

                    s038_Test = ExtractTestingSamples(s038, N);

                    s038_Genuine = CalculateGenuineScores(s039_Test, mu_s038, N); 
                }

                else if (inputN != "100" || inputN == "200" || inputN != "300")
                {
                    Console.WriteLine("Your input sampling is too large, the program will now quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For user 34
            if (userNumber == "34")
            {
                s039 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s039.csv");

                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s039_Samples = ExtractTrainingSamples(s039, N);

                    mu_s039 = CalculateTemplateVectors(s039_Samples, N);

                    s039_Test = ExtractTestingSamples(s039, N);

                    s039_Genuine = CalculateGenuineScores(s039_Test, mu_s039, N); 
                }

                else if (inputN != "100" || inputN == "200" || inputN != "300")
                {
                    Console.WriteLine("Your input sampling is too large, the program will now quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For user 35
            if (userNumber == "35")
            {
                s040 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s040.csv");

                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s040_Samples = ExtractTrainingSamples(s040, N);

                    mu_s040 = CalculateTemplateVectors(s040_Samples, N);

                    s040_Test = ExtractTestingSamples(s040, N);

                    s040_Genuine = CalculateGenuineScores(s040_Test, mu_s040, N);
                }

                else if (inputN != "100" || inputN == "200" || inputN != "300")
                {
                    Console.WriteLine("Your input sampling is too large, the program will now quit");
                    Console.ReadKey();
                }
            }            
            #endregion

            #region For user 36
            if (userNumber == "36")
            {
                s041 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s041.csv");

                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s041_Samples = ExtractTrainingSamples(s041, N);

                    mu_s041 = CalculateTemplateVectors(s041_Samples, N);

                    s041_Test = ExtractTestingSamples(s041, N);

                    s041_Genuine = CalculateGenuineScores(s041_Test, mu_s041, N); 
                }

                else if (inputN != "100" || inputN == "200" || inputN != "300")
                {
                    Console.WriteLine("Your input sampling is too large, the program will now quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For user 37
            if (userNumber == "37")
            {
                s042 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s042.csv");

                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s042_Samples = ExtractTrainingSamples(s042, N);

                    mu_s042 = CalculateTemplateVectors(s042_Samples, N);

                    s042_Test = ExtractTestingSamples(s042, N);

                    s042_Genuine = CalculateGenuineScores(s042_Test, mu_s042, N); 
                }

                else if (inputN != "100" || inputN == "200" || inputN != "300")
                {
                    Console.WriteLine("Your input sampling is too large, the program will now quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For user 38
            if (userNumber == "38")
            {
                s043 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s042.csv");

                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s043_Samples = ExtractTrainingSamples(s043, N);

                    mu_s043 = CalculateTemplateVectors(s043_Samples, N);

                    s043_Test = ExtractTestingSamples(s043, N);

                    s043_Genuine = CalculateGenuineScores(s043_Test, mu_s043, N); 
                }

                else if (inputN != "100" || inputN == "200" || inputN != "300")
                {
                    Console.WriteLine("Your input sampling is too large, the program will now quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For user 39
            if (userNumber == "39")
            {
                s044 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s044.csv");

                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s044_Samples = ExtractTrainingSamples(s044, N);

                    mu_s044 = CalculateTemplateVectors(s044_Samples, N);

                    s044_Test = ExtractTestingSamples(s044, N);

                    s044_Genuine = CalculateGenuineScores(s004_Test, mu_s044, N); 
                }

                else if (inputN != "100" || inputN == "200" || inputN != "300")
                {
                    Console.WriteLine("Your input sampling is too large, the program will now quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For user 40
            if (userNumber == "40")
            {
                s046 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s046.csv");

                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s046_Samples = ExtractTrainingSamples(s046, N);

                    mu_s046 = CalculateTemplateVectors(s046_Samples, N);

                    s046_Test = ExtractTestingSamples(s046, N);

                    s046_Genuine = CalculateGenuineScores(s046_Test, mu_s046, N); 
                }

                else if (inputN != "100" || inputN == "200" || inputN != "300")
                {
                    Console.WriteLine("Your input sampling is too large, the program will now quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For user 41
            if (userNumber == "41")
            {
                s047 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s047.csv");

                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s047_Samples = ExtractTrainingSamples(s047, N);

                    mu_s047 = CalculateTemplateVectors(s047_Samples, N);

                    s047_Test = ExtractTestingSamples(s047, N);

                    s047_Genuine = CalculateGenuineScores(s047_Test, mu_s047, N);
                }

                else if (inputN != "100" || inputN == "200" || inputN != "300")
                {
                    Console.WriteLine("Your input sampling is too large, the program will now quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For user 42
            if (userNumber == "42")
            {
                s048 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s042.csv");

                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s048_Samples = ExtractTrainingSamples(s048, N);

                    mu_s048 = CalculateTemplateVectors(s048_Samples, N);

                    s048_Test = ExtractTestingSamples(s048, N);

                    s048_Genuine = CalculateGenuineScores(s048_Test, mu_s048, N); 
                }

                else if (inputN != "100" || inputN == "200" || inputN != "300")
                {
                    Console.WriteLine("Your input sampling is too large, the program will now quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For user 43
            if (userNumber == "43")
            {
                s049 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s049.csv");

                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s049_Samples = ExtractTrainingSamples(s049, N);

                    mu_s049 = CalculateTemplateVectors(s049_Samples, N);

                    s049_Test = ExtractTestingSamples(s049, N);

                    s049_Genuine = CalculateGenuineScores(s049_Test, mu_s049, N);
                }

                else if (inputN != "100" || inputN == "200" || inputN != "300")
                {
                    Console.WriteLine("Your input sampling is too large, the program will now quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For user 44
            if (userNumber == "44")
            {
                s050 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s050.csv");

                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s050_Samples = ExtractTrainingSamples(s050, N);

                    mu_s050 = CalculateTemplateVectors(s050_Samples, N);

                    s050_Test = ExtractTestingSamples(s050, N);

                    s050_Genuine = CalculateGenuineScores(s050_Test, mu_s050, N); 
                }

                else if (inputN != "100" || inputN == "200" || inputN != "300")
                {
                    Console.WriteLine("Your input sampling is too large, the program will now quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For user 45
            if (userNumber == "45")
            {
                s051 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s051.csv");

                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s051_Samples = ExtractTrainingSamples(s051, N);

                    mu_s051 = CalculateTemplateVectors(s051_Samples, N);

                    s051_Test = ExtractTestingSamples(s051, N);

                    s051_Genuine = CalculateGenuineScores(s051_Test, mu_s051, N); 
                }

                else if (inputN != "100" || inputN == "200" || inputN != "300")
                {
                    Console.WriteLine("Your input sampling is too large, the program will now quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For user 46
            if (userNumber == "46")
            {
                s052 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s052.csv");

                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s052_Samples = ExtractTrainingSamples(s052, N);

                    mu_s052 = CalculateTemplateVectors(s052_Samples, N);

                    s052_Test = ExtractTestingSamples(s052, N);

                    s052_Genuine = CalculateGenuineScores(s052_Test, mu_s052, N); 
                }

                else if (inputN != "100" || inputN == "200" || inputN != "300")
                {
                    Console.WriteLine("Your input sampling is too large, the program will now quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For user 47
            if (userNumber == "47")
            {
                s053 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s053.csv");

                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s053_Samples = ExtractTrainingSamples(s053, N);

                    mu_s053 = CalculateTemplateVectors(s053_Samples, N);

                    s053_Test = ExtractTestingSamples(s053, N);

                    s053_Genuine = CalculateGenuineScores(s053_Test, mu_s053, N);
                }

                else if (inputN != "100" || inputN == "200" || inputN != "300")
                {
                    Console.WriteLine("Your input sampling is too large, the program will now quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For user 48
            if (userNumber == "48")
            {
                s054 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s054.csv");

                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s054_Samples = ExtractTrainingSamples(s054, N);

                    mu_s054 = CalculateTemplateVectors(s054_Samples, N);

                    s054_Test = ExtractTestingSamples(s054, N);

                    s054_Genuine = CalculateGenuineScores(s054_Test, mu_s054, N); 
                }

                else if (inputN != "100" || inputN == "200" || inputN != "300")
                {
                    Console.WriteLine("Your input sampling is too large, the program will now quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For user 49
            if (userNumber == "49")
            {
                s055 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s055.csv");

                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s055_Samples = ExtractTrainingSamples(s055, N);

                    mu_s055 = CalculateTemplateVectors(s055_Samples, N);

                    s055_Test = ExtractTestingSamples(s055, N);

                    s055_Genuine = CalculateGenuineScores(s055_Test, mu_s055, N); 
                }

                else if (inputN != "100" || inputN == "200" || inputN != "300")
                {
                    Console.WriteLine("Your input sampling is too large, the program will now quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For user 50
            if (userNumber == "50")
            {
                s056 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s056.csv");

                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s056_Samples = ExtractTrainingSamples(s056, N);

                    mu_s056 = CalculateTemplateVectors(s056_Samples, N);

                    s056_Test = ExtractTestingSamples(s056, N);

                    s056_Genuine = CalculateGenuineScores(s056_Test, mu_s056, N); 
                }

                else if (inputN != "100" || inputN == "200" || inputN != "300")
                {
                    Console.WriteLine("Your input sampling is too large, the program will now quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For user 51
            if (userNumber == "51")
            {
                s057 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s057.csv");

                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s057_Samples = ExtractTrainingSamples(s057, N);

                    mu_s057 = CalculateTemplateVectors(s057_Samples, N);

                    s057_Test = ExtractTestingSamples(s057, N);

                    s057_Genuine = CalculateGenuineScores(s057_Test, mu_s057, N); 
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

        #region This is the in class/ in code API (almost)
        private static void CalculateImpostorScores(double[] mu_s002, double[,] s003_Test, double[,] s004_Test, double[,] s005_Test, double[,] s007_Test, double[,] s008_Test, double[,] s010_Test, double[,] s011_Test, double[,] s012_Test, double[,] s013_Test, double[,] s015_Test, double[,] s017_Test, double[,] s018_Test, double[,] s019_Test, double[,] s020_Test, double[,] s021_Test, double[,] s022_Test, double[,] s024_Test, double[,] s025_Test, double[,] s026_Test, double[,] s027_Test, double[,] s028_Test, double[,] s029_Test, double[,] s030_Test, double[,] s031_Test, double[,] s032_Test, double[,] s033_Test, double[,] s034_Test, double[,] s035_Test, double[,] s036_Test, double[,] s037_Test, double[,] s038_Test, double[,] s039_Test, double[,] s040_Test, double[,] s041_Test, double[,] s042_Test, double[,] s043_Test, double[,] s044_Test, double[,] s046_Test, double[,] s047_Test, double[,] s048_Test, double[,] s049_Test, double[,] s050_Test, double[,] s051_Test, double[,] s052_Test, double[,] s053_Test, double[,] s054_Test, double[,] s055_Test, double[,] s056_Test, double[,] s057_Test, int N)
        {
            #region Declaring 50 1D impostor arrays here
            
            #endregion

            int M = 400 - N; 
            Console.Write("The number of samples are " + N + " and the number of samples to calculate the impostor scores are " + M);

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < s003_Test.GetLength(1); j++)
                {

                }
            }
        }
        #region This method will calculate the genuine scores
        /// <summary>
        /// Here, this method will be calculating the genuine scores
        /// </summary>
        /// <param name="s002_Test">The test vector that contains 400 - N samples</param>
        /// <param name="mu_s002">This is the mean or template vector of the first N samples</param>
        /// <param name="N">Static (fixed) integer value which contains the first N samples upon which analysis will be conducted</param>
        /// <note>Please note that I am making the assumption that for the Manhattan Verifier is being used with the value of n as the number of samples (N)</note>
        static double[] CalculateGenuineScores(double[,] s002_Test, double[] mu_s002, int N)
        {
            // Initialize the 1D double array
            double[] difference = new double[21];

            // Iterating over the nested for loop and making column wise calculations
            for (int i = 0; i < s002_Test.GetLength(0); i++)
            {
                for (int j = 0; j < s002_Test.GetLength(1) ; j++)
                {
                    // This is the first part to the Manhattan Distance verifier
                    difference[j] += (Math.Abs(s002_Test[i, j] - mu_s002[j]) / N); 
                }
            }

            // Returns the difference
            return difference; 
        }
        #endregion

        #region The Test Sample extraction, got that done
        /// <summary>
        /// This method should be able to take the existing 2D double array
        /// and extract the test samples.  However, I am unable to do so
        /// </summary>
        /// <param name="s002">The input array</param>
        /// <param name="M">The value which is calculated from 400 - N</param>
        /// <returns>The 2D array known as testSamples</returns>
        static double[,] ExtractTestingSamples(double[,] s002, int N)
        {
            if (N == 100)
            {
                double[,] test100 = new double[300, 21];

                for (int i = 0; i < 299; i++)
                {
                    for (int j = 0; j < test100.GetLength(1); j++)
                    {
                        // i = M;
                        test100[i, j] = s002[100 + i, j];
                    }
                }
                return test100; 
            }

            else if (N == 200)
            {
                double[,] test200 = new double[200, 21];

                for (int i = 0; i < 199; i++)
                {
                    for (int j = 0; j < test200.GetLength(1); j++)
                    {
                        // i = M;
                        test200[i, j] = s002[200 + i, j];
                    }
                }
                return test200; 
            }

            else if (N == 300)
            {
                double[,] test300 = new double[100, 21];

                for (int i = 0; i < 99; i++)
                {
                    for (int j = 0; j < test300.GetLength(1); j++)
                    {
                        // i = M;
                        test300[i, j] = s002[300 + i, j];
                    }
                }
                return test300; 
            }

            return s002; // Default return statement
        }
        #endregion

        #region Extraction of training samples based on the value of N
        /// <summary>
        /// This method will be used to extract the samples given the parameter of the sampling size.  
        /// </summary>
        /// <param name="s002">The data that is extracted or converted from the CSV file</param>
        /// <param name="N">Sample size</param>
        /// <returns>samples - 2D double array which contains the samples from the original data</returns>
        static double[,] ExtractTrainingSamples(double[,] s002, int N)
        {
            // Initialize the 2D double array
            double[,] samples = new double[N, 21]; 

            // Iterating over a nested for loop.
            for (int n = 0; n <= N - 1; n++)
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
            // 2D double that is automatically named due to polymorphism. 
            return values;
        }
        #endregion
        #endregion
    }
}