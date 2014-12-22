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
    /// 22nd December 2014
    /// * Making sure I know what is going on in this code. 
    /// * Reviewing all the code that I have written.
    /// * Having the necessary changes made to be able to have a more accurate picture of everything. 
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
        static double[,] s002_Genuine;
        static double[,] s003_Genuine;
        static double[,] s004_Genuine;
        static double[,] s005_Genuine;
        static double[,] s007_Genuine;
        static double[,] s008_Genuine;
        static double[,] s010_Genuine;
        static double[,] s011_Genuine;
        static double[,] s012_Genuine;
        static double[,] s013_Genuine;
        static double[,] s015_Genuine;
        static double[,] s016_Genuine;
        static double[,] s017_Genuine;
        static double[,] s018_Genuine;
        static double[,] s019_Genuine;
        static double[,] s020_Genuine;
        static double[,] s021_Genuine;
        static double[,] s022_Genuine;
        static double[,] s024_Genuine;
        static double[,] s025_Genuine;
        static double[,] s026_Genuine;
        static double[,] s027_Genuine;
        static double[,] s028_Genuine;
        static double[,] s029_Genuine;
        static double[,] s030_Genuine;
        static double[,] s031_Genuine;
        static double[,] s032_Genuine;
        static double[,] s033_Genuine;
        static double[,] s034_Genuine;
        static double[,] s035_Genuine;
        static double[,] s036_Genuine;
        static double[,] s037_Genuine;
        static double[,] s038_Genuine;
        static double[,] s039_Genuine;
        static double[,] s040_Genuine;
        static double[,] s041_Genuine;
        static double[,] s042_Genuine;
        static double[,] s043_Genuine;
        static double[,] s044_Genuine;
        static double[,] s046_Genuine;
        static double[,] s047_Genuine;
        static double[,] s048_Genuine;
        static double[,] s049_Genuine;
        static double[,] s050_Genuine;
        static double[,] s051_Genuine;
        static double[,] s052_Genuine;
        static double[,] s053_Genuine;
        static double[,] s054_Genuine;
        static double[,] s055_Genuine;
        static double[,] s056_Genuine;
        static double[,] s057_Genuine;
        #endregion

        // This is the driver method
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

            #region Parsing data
            s002 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s002.csv");
            s003 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s003.csv");
            s004 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s004.csv");
            s005 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s005.csv");
            s007 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s007.csv");
            s008 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s008.csv");
            s010 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s010.csv");
            s011 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s011.csv");
            s012 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s012.csv");
            s013 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s013.csv");
            s015 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s015.csv");
            s016 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s016.csv");
            s017 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s017.csv");
            s018 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s018.csv");
            s019 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s019.csv");
            s020 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s020.csv");
            s021 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s021.csv");
            s022 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s022.csv");
            s024 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s024.csv");
            s025 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s025.csv");
            s026 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s026.csv");
            s027 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s027.csv");
            s028 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s028.csv");
            s029 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s029.csv");
            s030 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s030.csv");
            s031 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s031.csv");
            s032 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s032.csv");
            s033 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s033.csv");
            s034 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s034.csv");
            s035 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s035.csv");
            s036 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s036.csv");
            s037 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s037.csv");
            s038 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s038.csv");
            s039 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s039.csv");
            s040 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s040.csv");
            s041 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s041.csv");
            s042 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s042.csv");
            s043 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s042.csv");
            s044 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s044.csv");
            s046 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s046.csv");
            s047 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s047.csv");
            s048 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s042.csv");
            s049 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s049.csv");
            s050 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s050.csv");
            s051 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s051.csv");
            s052 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s052.csv");
            s053 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s053.csv");
            s054 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s054.csv");
            s055 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s055.csv");
            s056 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s056.csv");
            s057 = ParseData(@"C:\Users\Pranav\Documents\GitHub\PranavK_ProgrammingAssignment1_CSCI860_Fall2014\ProgrammingAssignment1_SpecialTopics\Data Files\s057.csv");
            #endregion

            // This is the string for which the end user will determine which user will have the samples retrieved, and all the 
            // rates will be calculated based upon the user number that the end user will input
            string userNumber = Console.ReadLine();

            #region For user 1
            if (userNumber == "1")
            {
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

                    // Extracting all the samples for the genuine calculations
                    s002_Test = ExtractTestingSamples(s002, N);

                    // Making the method call to generate the various genuine scores for user 1
                    s002_Genuine = CalculateGenuineScores(s002_Test, mu_s002, N);
                    
                    #region Extracting all the samples for the impostor calculations
                    s003_Test = ExtractTestingSamples(s003, N); 
                    s004_Test = ExtractTestingSamples(s004, N); 
                    s005_Test = ExtractTestingSamples(s005, N); 
                    s007_Test = ExtractTestingSamples(s007, N);
                    s008_Test = ExtractTestingSamples(s008, N);
                    s010_Test = ExtractTestingSamples(s010, N);
                    s011_Test = ExtractTestingSamples(s011, N);
                    s012_Test = ExtractTestingSamples(s012, N);
                    s013_Test = ExtractTestingSamples(s013, N);
                    s015_Test = ExtractTestingSamples(s015, N);
                    s016_Test = ExtractTestingSamples(s016, N);
                    s017_Test = ExtractTestingSamples(s017, N);
                    s018_Test = ExtractTestingSamples(s018, N);
                    s019_Test = ExtractTestingSamples(s019, N);
                    s020_Test = ExtractTestingSamples(s020, N);
                    s021_Test = ExtractTestingSamples(s021, N);
                    s022_Test = ExtractTestingSamples(s022, N);
                    s024_Test = ExtractTestingSamples(s024, N);
                    s025_Test = ExtractTestingSamples(s025, N);
                    s026_Test = ExtractTestingSamples(s026, N);
                    s027_Test = ExtractTestingSamples(s027, N);
                    s028_Test = ExtractTestingSamples(s028, N);
                    s029_Test = ExtractTestingSamples(s029, N);
                    s030_Test = ExtractTestingSamples(s030, N);
                    s031_Test = ExtractTestingSamples(s031, N);
                    s032_Test = ExtractTestingSamples(s032, N);
                    s033_Test = ExtractTestingSamples(s033, N);
                    s034_Test = ExtractTestingSamples(s034, N);
                    s035_Test = ExtractTestingSamples(s035, N);
                    s036_Test = ExtractTestingSamples(s036, N);
                    s037_Test = ExtractTestingSamples(s037, N);
                    s038_Test = ExtractTestingSamples(s038, N);
                    s039_Test = ExtractTestingSamples(s039, N);
                    s040_Test = ExtractTestingSamples(s040, N);
                    s041_Test = ExtractTestingSamples(s041, N);
                    s042_Test = ExtractTestingSamples(s042, N);
                    s043_Test = ExtractTestingSamples(s043, N);
                    s044_Test = ExtractTestingSamples(s044, N);
                    s046_Test = ExtractTestingSamples(s046, N);
                    s047_Test = ExtractTestingSamples(s047, N);
                    s048_Test = ExtractTestingSamples(s048, N);
                    s049_Test = ExtractTestingSamples(s049, N);
                    s050_Test = ExtractTestingSamples(s050, N);
                    s051_Test = ExtractTestingSamples(s051, N);
                    s052_Test = ExtractTestingSamples(s052, N);
                    s053_Test = ExtractTestingSamples(s053, N);
                    s054_Test = ExtractTestingSamples(s054, N);
                    s055_Test = ExtractTestingSamples(s055, N);
                    s056_Test = ExtractTestingSamples(s056, N);
                    s057_Test = ExtractTestingSamples(s057, N);
                    #endregion

                    // Making the method call to calculate all the zero-effort impostor scores
                    CalculateImpostorScores(s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mu_s002);

                    FalseRejectRate(s002_Genuine, N);
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
                // Prompting the user to enter in the number of samples to be analyzed. 
                Console.Write("Enter N: The number of samples. The value of N can be either 100, 200, or 300." + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    // Creating the integer N, which is the sample size variable
                    int N = int.Parse(inputN);

                    // Again initializing an array of samples, again used through a method call. 
                    double[,] s003_Samples = ExtractTrainingSamples(s003, N);

                    // Calling to the method which will calculate the Template Vectors. 
                    mu_s003 = CalculateTemplateVectors(s003_Samples, N);

                    // Extracting the test samples
                    s003_Test = ExtractTestingSamples(s003, N);

                    s003_Genuine = CalculateGenuineScores(s003_Test, mu_s003, N);

                    #region Test samples for impostor scores
                        // Extracting the test samples for impostor calculations
                        s002_Test = ExtractTestingSamples(s002, N);
                    s004_Test = ExtractTestingSamples(s004, N);
                    s005_Test = ExtractTestingSamples(s005, N);
                    s007_Test = ExtractTestingSamples(s007, N);
                    s008_Test = ExtractTestingSamples(s008, N);
                    s010_Test = ExtractTestingSamples(s010, N);
                    s011_Test = ExtractTestingSamples(s011, N);
                    s012_Test = ExtractTestingSamples(s012, N);
                    s013_Test = ExtractTestingSamples(s013, N);
                    s015_Test = ExtractTestingSamples(s015, N);
                    s016_Test = ExtractTestingSamples(s016, N);
                    s017_Test = ExtractTestingSamples(s017, N);
                    s018_Test = ExtractTestingSamples(s018, N);
                    s019_Test = ExtractTestingSamples(s019, N);
                    s020_Test = ExtractTestingSamples(s020, N);
                    s021_Test = ExtractTestingSamples(s021, N);
                    s022_Test = ExtractTestingSamples(s022, N);
                    s024_Test = ExtractTestingSamples(s024, N);
                    s025_Test = ExtractTestingSamples(s025, N);
                    s026_Test = ExtractTestingSamples(s026, N);
                    s027_Test = ExtractTestingSamples(s027, N);
                    s028_Test = ExtractTestingSamples(s028, N);
                    s029_Test = ExtractTestingSamples(s029, N);
                    s030_Test = ExtractTestingSamples(s030, N);
                    s031_Test = ExtractTestingSamples(s031, N);
                    s032_Test = ExtractTestingSamples(s032, N);
                    s033_Test = ExtractTestingSamples(s033, N);
                    s034_Test = ExtractTestingSamples(s034, N);
                    s035_Test = ExtractTestingSamples(s035, N);
                    s036_Test = ExtractTestingSamples(s036, N);
                    s037_Test = ExtractTestingSamples(s037, N);
                    s038_Test = ExtractTestingSamples(s038, N);
                    s039_Test = ExtractTestingSamples(s039, N);
                    s040_Test = ExtractTestingSamples(s040, N);
                    s041_Test = ExtractTestingSamples(s041, N);
                    s042_Test = ExtractTestingSamples(s042, N);
                    s043_Test = ExtractTestingSamples(s043, N);
                    s044_Test = ExtractTestingSamples(s044, N);
                    s046_Test = ExtractTestingSamples(s046, N);
                    s047_Test = ExtractTestingSamples(s047, N);
                    s048_Test = ExtractTestingSamples(s048, N);
                    s049_Test = ExtractTestingSamples(s049, N);
                    s050_Test = ExtractTestingSamples(s050, N);
                    s051_Test = ExtractTestingSamples(s051, N);
                    s052_Test = ExtractTestingSamples(s052, N);
                    s053_Test = ExtractTestingSamples(s053, N);
                    s054_Test = ExtractTestingSamples(s054, N);
                    s055_Test = ExtractTestingSamples(s055, N);
                    s056_Test = ExtractTestingSamples(s056, N);
                    s057_Test = ExtractTestingSamples(s057, N);
                    #endregion

                    CalculateImpostorScores(s002_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mu_s003);

                    FalseRejectRate(s003_Genuine, N); 
                }

                else if (inputN != "100" || inputN != "200" || inputN != "300")
                {
                    Console.Write("The sample size that you requested is too large, the program will now quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For user 3
            if (userNumber == "3")
            {
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

                    // Genuine sample extraction
                    s004_Test = ExtractTestingSamples(s004, N);

                    #region Extracting samples for the Impostor scores
                    s002_Test = ExtractTestingSamples(s002, N);
                    s003_Test = ExtractTestingSamples(s003, N);
                    s005_Test = ExtractTestingSamples(s005, N);
                    s007_Test = ExtractTestingSamples(s007, N);
                    s008_Test = ExtractTestingSamples(s008, N);
                    s010_Test = ExtractTestingSamples(s010, N);
                    s011_Test = ExtractTestingSamples(s011, N);
                    s012_Test = ExtractTestingSamples(s012, N);
                    s013_Test = ExtractTestingSamples(s013, N);
                    s015_Test = ExtractTestingSamples(s015, N);
                    s016_Test = ExtractTestingSamples(s016, N);
                    s017_Test = ExtractTestingSamples(s017, N);
                    s018_Test = ExtractTestingSamples(s018, N);
                    s019_Test = ExtractTestingSamples(s019, N);
                    s020_Test = ExtractTestingSamples(s020, N);
                    s021_Test = ExtractTestingSamples(s021, N);
                    s022_Test = ExtractTestingSamples(s022, N);
                    s024_Test = ExtractTestingSamples(s024, N);
                    s025_Test = ExtractTestingSamples(s025, N);
                    s026_Test = ExtractTestingSamples(s026, N);
                    s027_Test = ExtractTestingSamples(s027, N);
                    s028_Test = ExtractTestingSamples(s028, N);
                    s029_Test = ExtractTestingSamples(s029, N);
                    s030_Test = ExtractTestingSamples(s030, N);
                    s031_Test = ExtractTestingSamples(s031, N);
                    s032_Test = ExtractTestingSamples(s032, N);
                    s033_Test = ExtractTestingSamples(s033, N);
                    s034_Test = ExtractTestingSamples(s034, N);
                    s035_Test = ExtractTestingSamples(s035, N);
                    s036_Test = ExtractTestingSamples(s036, N);
                    s037_Test = ExtractTestingSamples(s037, N);
                    s038_Test = ExtractTestingSamples(s038, N);
                    s039_Test = ExtractTestingSamples(s039, N);
                    s040_Test = ExtractTestingSamples(s040, N);
                    s041_Test = ExtractTestingSamples(s041, N);
                    s042_Test = ExtractTestingSamples(s042, N);
                    s043_Test = ExtractTestingSamples(s043, N);
                    s044_Test = ExtractTestingSamples(s044, N);
                    s046_Test = ExtractTestingSamples(s046, N);
                    s047_Test = ExtractTestingSamples(s047, N);
                    s048_Test = ExtractTestingSamples(s048, N);
                    s049_Test = ExtractTestingSamples(s049, N);
                    s050_Test = ExtractTestingSamples(s050, N);
                    s051_Test = ExtractTestingSamples(s051, N);
                    s052_Test = ExtractTestingSamples(s052, N);
                    s053_Test = ExtractTestingSamples(s053, N);
                    s054_Test = ExtractTestingSamples(s054, N);
                    s055_Test = ExtractTestingSamples(s055, N);
                    s056_Test = ExtractTestingSamples(s056, N);
                    s057_Test = ExtractTestingSamples(s057, N);
                    #endregion

                    s004_Genuine = CalculateGenuineScores(s004_Test, mu_s004, N);

                    CalculateImpostorScores(s002_Test, s003_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mu_s004);

                    FalseRejectRate(s004_Genuine, N); 
                }

                else if (inputN != "100" || inputN != "200" || inputN != "300")
                {
                    Console.Write("Your input sampling is too large, and the program will now quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For user 4
            if (userNumber == "4")
            {
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

                    s002_Test = ExtractTestingSamples(s002, N);
                    s003_Test = ExtractTestingSamples(s003, N);
                    s004_Test = ExtractTestingSamples(s004, N);
                    s007_Test = ExtractTestingSamples(s007, N);
                    s008_Test = ExtractTestingSamples(s008, N);
                    s010_Test = ExtractTestingSamples(s010, N);
                    s011_Test = ExtractTestingSamples(s011, N);
                    s012_Test = ExtractTestingSamples(s012, N);
                    s013_Test = ExtractTestingSamples(s013, N);
                    s015_Test = ExtractTestingSamples(s015, N);
                    s016_Test = ExtractTestingSamples(s016, N);
                    s017_Test = ExtractTestingSamples(s017, N);
                    s018_Test = ExtractTestingSamples(s018, N);
                    s019_Test = ExtractTestingSamples(s019, N);
                    s020_Test = ExtractTestingSamples(s020, N);
                    s021_Test = ExtractTestingSamples(s021, N);
                    s022_Test = ExtractTestingSamples(s022, N);
                    s024_Test = ExtractTestingSamples(s024, N);
                    s025_Test = ExtractTestingSamples(s025, N);
                    s026_Test = ExtractTestingSamples(s026, N);
                    s027_Test = ExtractTestingSamples(s027, N);
                    s028_Test = ExtractTestingSamples(s028, N);
                    s029_Test = ExtractTestingSamples(s029, N);
                    s030_Test = ExtractTestingSamples(s030, N);
                    s031_Test = ExtractTestingSamples(s031, N);
                    s032_Test = ExtractTestingSamples(s032, N);
                    s033_Test = ExtractTestingSamples(s033, N);
                    s034_Test = ExtractTestingSamples(s034, N);
                    s035_Test = ExtractTestingSamples(s035, N);
                    s036_Test = ExtractTestingSamples(s036, N);
                    s037_Test = ExtractTestingSamples(s037, N);
                    s038_Test = ExtractTestingSamples(s038, N);
                    s039_Test = ExtractTestingSamples(s039, N);
                    s040_Test = ExtractTestingSamples(s040, N);
                    s041_Test = ExtractTestingSamples(s041, N);
                    s042_Test = ExtractTestingSamples(s042, N);
                    s043_Test = ExtractTestingSamples(s043, N);
                    s044_Test = ExtractTestingSamples(s044, N);
                    s046_Test = ExtractTestingSamples(s046, N);
                    s047_Test = ExtractTestingSamples(s047, N);
                    s048_Test = ExtractTestingSamples(s048, N);
                    s049_Test = ExtractTestingSamples(s049, N);
                    s050_Test = ExtractTestingSamples(s050, N);
                    s051_Test = ExtractTestingSamples(s051, N);
                    s052_Test = ExtractTestingSamples(s052, N);
                    s053_Test = ExtractTestingSamples(s053, N);
                    s054_Test = ExtractTestingSamples(s054, N);
                    s055_Test = ExtractTestingSamples(s055, N);
                    s056_Test = ExtractTestingSamples(s056, N);
                    s057_Test = ExtractTestingSamples(s057, N);

                    CalculateImpostorScores(s002_Test, s003_Test, s004_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mu_s005);

                    FalseRejectRate(s005_Genuine, N);
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

                    #region Extracting all the samples for the impostor calculations
                    s002_Test = ExtractTestingSamples(s002, N);
                    s003_Test = ExtractTestingSamples(s003, N);
                    s004_Test = ExtractTestingSamples(s004, N);
                    s005_Test = ExtractTestingSamples(s005, N);
                    s008_Test = ExtractTestingSamples(s008, N);
                    s010_Test = ExtractTestingSamples(s010, N);
                    s011_Test = ExtractTestingSamples(s011, N);
                    s012_Test = ExtractTestingSamples(s012, N);
                    s013_Test = ExtractTestingSamples(s013, N);
                    s015_Test = ExtractTestingSamples(s015, N);
                    s016_Test = ExtractTestingSamples(s016, N);
                    s017_Test = ExtractTestingSamples(s017, N);
                    s018_Test = ExtractTestingSamples(s018, N);
                    s019_Test = ExtractTestingSamples(s019, N);
                    s020_Test = ExtractTestingSamples(s020, N);
                    s021_Test = ExtractTestingSamples(s021, N);
                    s022_Test = ExtractTestingSamples(s022, N);
                    s024_Test = ExtractTestingSamples(s024, N);
                    s025_Test = ExtractTestingSamples(s025, N);
                    s026_Test = ExtractTestingSamples(s026, N);
                    s027_Test = ExtractTestingSamples(s027, N);
                    s028_Test = ExtractTestingSamples(s028, N);
                    s029_Test = ExtractTestingSamples(s029, N);
                    s030_Test = ExtractTestingSamples(s030, N);
                    s031_Test = ExtractTestingSamples(s031, N);
                    s032_Test = ExtractTestingSamples(s032, N);
                    s033_Test = ExtractTestingSamples(s033, N);
                    s034_Test = ExtractTestingSamples(s034, N);
                    s035_Test = ExtractTestingSamples(s035, N);
                    s036_Test = ExtractTestingSamples(s036, N);
                    s037_Test = ExtractTestingSamples(s037, N);
                    s038_Test = ExtractTestingSamples(s038, N);
                    s039_Test = ExtractTestingSamples(s039, N);
                    s040_Test = ExtractTestingSamples(s040, N);
                    s041_Test = ExtractTestingSamples(s041, N);
                    s042_Test = ExtractTestingSamples(s042, N);
                    s043_Test = ExtractTestingSamples(s043, N);
                    s044_Test = ExtractTestingSamples(s044, N);
                    s046_Test = ExtractTestingSamples(s046, N);
                    s047_Test = ExtractTestingSamples(s047, N);
                    s048_Test = ExtractTestingSamples(s048, N);
                    s049_Test = ExtractTestingSamples(s049, N);
                    s050_Test = ExtractTestingSamples(s050, N);
                    s051_Test = ExtractTestingSamples(s051, N);
                    s052_Test = ExtractTestingSamples(s052, N);
                    s053_Test = ExtractTestingSamples(s053, N);
                    s054_Test = ExtractTestingSamples(s054, N);
                    s055_Test = ExtractTestingSamples(s055, N);
                    s056_Test = ExtractTestingSamples(s056, N);
                    s057_Test = ExtractTestingSamples(s057, N);
                    #endregion

                    CalculateImpostorScores(s002_Test, s003_Test, s004_Test, s005_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mu_s007);

                    FalseRejectRate(s007_Genuine, N);
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

                    #region Extracting all the samples for the impostor calculations
                    s002_Test = ExtractTestingSamples(s002, N);
                    s003_Test = ExtractTestingSamples(s003, N);
                    s004_Test = ExtractTestingSamples(s004, N);
                    s005_Test = ExtractTestingSamples(s005, N);
                    s007_Test = ExtractTestingSamples(s007, N);
                    s008_Test = ExtractTestingSamples(s008, N);
                    s010_Test = ExtractTestingSamples(s010, N);
                    s011_Test = ExtractTestingSamples(s011, N);
                    s012_Test = ExtractTestingSamples(s012, N);
                    s013_Test = ExtractTestingSamples(s013, N);
                    s015_Test = ExtractTestingSamples(s015, N);
                    s016_Test = ExtractTestingSamples(s016, N);
                    s017_Test = ExtractTestingSamples(s017, N);
                    s018_Test = ExtractTestingSamples(s018, N);
                    s019_Test = ExtractTestingSamples(s019, N);
                    s020_Test = ExtractTestingSamples(s020, N);
                    s021_Test = ExtractTestingSamples(s021, N);
                    s022_Test = ExtractTestingSamples(s022, N);
                    s024_Test = ExtractTestingSamples(s024, N);
                    s025_Test = ExtractTestingSamples(s025, N);
                    s026_Test = ExtractTestingSamples(s026, N);
                    s027_Test = ExtractTestingSamples(s027, N);
                    s028_Test = ExtractTestingSamples(s028, N);
                    s029_Test = ExtractTestingSamples(s029, N);
                    s030_Test = ExtractTestingSamples(s030, N);
                    s031_Test = ExtractTestingSamples(s031, N);
                    s032_Test = ExtractTestingSamples(s032, N);
                    s033_Test = ExtractTestingSamples(s033, N);
                    s034_Test = ExtractTestingSamples(s034, N);
                    s035_Test = ExtractTestingSamples(s035, N);
                    s036_Test = ExtractTestingSamples(s036, N);
                    s037_Test = ExtractTestingSamples(s037, N);
                    s038_Test = ExtractTestingSamples(s038, N);
                    s039_Test = ExtractTestingSamples(s039, N);
                    s040_Test = ExtractTestingSamples(s040, N);
                    s041_Test = ExtractTestingSamples(s041, N);
                    s042_Test = ExtractTestingSamples(s042, N);
                    s043_Test = ExtractTestingSamples(s043, N);
                    s044_Test = ExtractTestingSamples(s044, N);
                    s046_Test = ExtractTestingSamples(s046, N);
                    s047_Test = ExtractTestingSamples(s047, N);
                    s048_Test = ExtractTestingSamples(s048, N);
                    s049_Test = ExtractTestingSamples(s049, N);
                    s050_Test = ExtractTestingSamples(s050, N);
                    s051_Test = ExtractTestingSamples(s051, N);
                    s052_Test = ExtractTestingSamples(s052, N);
                    s053_Test = ExtractTestingSamples(s053, N);
                    s054_Test = ExtractTestingSamples(s054, N);
                    s055_Test = ExtractTestingSamples(s055, N);
                    s056_Test = ExtractTestingSamples(s056, N);
                    s057_Test = ExtractTestingSamples(s057, N);
                    #endregion

                    CalculateImpostorScores(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mu_s008);

                    FalseRejectRate(s008_Genuine, N);
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

                Console.Write("Enter N: The number of samples.  Value of N can be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s010_Samples = ExtractTrainingSamples(s010, N);

                    mu_s010 = CalculateTemplateVectors(s010_Samples, N);

                    s010_Test = ExtractTestingSamples(s010, N);

                    s010_Genuine = CalculateGenuineScores(s010_Test, mu_s010, N);

                    #region Extracting all the samples for the impostor calculations
                    s002_Test = ExtractTestingSamples(s002, N);
                    s003_Test = ExtractTestingSamples(s003, N);
                    s004_Test = ExtractTestingSamples(s004, N);
                    s005_Test = ExtractTestingSamples(s005, N);
                    s007_Test = ExtractTestingSamples(s007, N);
                    s008_Test = ExtractTestingSamples(s008, N);
                    s011_Test = ExtractTestingSamples(s011, N);
                    s012_Test = ExtractTestingSamples(s012, N);
                    s013_Test = ExtractTestingSamples(s013, N);
                    s015_Test = ExtractTestingSamples(s015, N);
                    s016_Test = ExtractTestingSamples(s016, N);
                    s017_Test = ExtractTestingSamples(s017, N);
                    s018_Test = ExtractTestingSamples(s018, N);
                    s019_Test = ExtractTestingSamples(s019, N);
                    s020_Test = ExtractTestingSamples(s020, N);
                    s021_Test = ExtractTestingSamples(s021, N);
                    s022_Test = ExtractTestingSamples(s022, N);
                    s024_Test = ExtractTestingSamples(s024, N);
                    s025_Test = ExtractTestingSamples(s025, N);
                    s026_Test = ExtractTestingSamples(s026, N);
                    s027_Test = ExtractTestingSamples(s027, N);
                    s028_Test = ExtractTestingSamples(s028, N);
                    s029_Test = ExtractTestingSamples(s029, N);
                    s030_Test = ExtractTestingSamples(s030, N);
                    s031_Test = ExtractTestingSamples(s031, N);
                    s032_Test = ExtractTestingSamples(s032, N);
                    s033_Test = ExtractTestingSamples(s033, N);
                    s034_Test = ExtractTestingSamples(s034, N);
                    s035_Test = ExtractTestingSamples(s035, N);
                    s036_Test = ExtractTestingSamples(s036, N);
                    s037_Test = ExtractTestingSamples(s037, N);
                    s038_Test = ExtractTestingSamples(s038, N);
                    s039_Test = ExtractTestingSamples(s039, N);
                    s040_Test = ExtractTestingSamples(s040, N);
                    s041_Test = ExtractTestingSamples(s041, N);
                    s042_Test = ExtractTestingSamples(s042, N);
                    s043_Test = ExtractTestingSamples(s043, N);
                    s044_Test = ExtractTestingSamples(s044, N);
                    s046_Test = ExtractTestingSamples(s046, N);
                    s047_Test = ExtractTestingSamples(s047, N);
                    s048_Test = ExtractTestingSamples(s048, N);
                    s049_Test = ExtractTestingSamples(s049, N);
                    s050_Test = ExtractTestingSamples(s050, N);
                    s051_Test = ExtractTestingSamples(s051, N);
                    s052_Test = ExtractTestingSamples(s052, N);
                    s053_Test = ExtractTestingSamples(s053, N);
                    s054_Test = ExtractTestingSamples(s054, N);
                    s055_Test = ExtractTestingSamples(s055, N);
                    s056_Test = ExtractTestingSamples(s056, N);
                    s057_Test = ExtractTestingSamples(s057, N);
                    #endregion

                    CalculateImpostorScores(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mu_s010);

                    FalseRejectRate(s010_Genuine, N);
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
                Console.Write("Enter N: The number of samples.  Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s011_Samples = ExtractTrainingSamples(s011, N);

                    mu_s011 = CalculateTemplateVectors(s011_Samples, N);

                    s011_Test = ExtractTestingSamples(s011, N);
                    s011_Genuine = CalculateGenuineScores(s011_Test, mu_s011, N);

                    #region Extracting all the samples for the impostor calculations
                    s002_Test = ExtractTestingSamples(s002, N);
                    s003_Test = ExtractTestingSamples(s003, N);
                    s004_Test = ExtractTestingSamples(s004, N);
                    s005_Test = ExtractTestingSamples(s005, N);
                    s007_Test = ExtractTestingSamples(s007, N);
                    s008_Test = ExtractTestingSamples(s008, N);
                    s010_Test = ExtractTestingSamples(s010, N);
                    s012_Test = ExtractTestingSamples(s012, N);
                    s013_Test = ExtractTestingSamples(s013, N);
                    s015_Test = ExtractTestingSamples(s015, N);
                    s016_Test = ExtractTestingSamples(s016, N);
                    s017_Test = ExtractTestingSamples(s017, N);
                    s018_Test = ExtractTestingSamples(s018, N);
                    s019_Test = ExtractTestingSamples(s019, N);
                    s020_Test = ExtractTestingSamples(s020, N);
                    s021_Test = ExtractTestingSamples(s021, N);
                    s022_Test = ExtractTestingSamples(s022, N);
                    s024_Test = ExtractTestingSamples(s024, N);
                    s025_Test = ExtractTestingSamples(s025, N);
                    s026_Test = ExtractTestingSamples(s026, N);
                    s027_Test = ExtractTestingSamples(s027, N);
                    s028_Test = ExtractTestingSamples(s028, N);
                    s029_Test = ExtractTestingSamples(s029, N);
                    s030_Test = ExtractTestingSamples(s030, N);
                    s031_Test = ExtractTestingSamples(s031, N);
                    s032_Test = ExtractTestingSamples(s032, N);
                    s033_Test = ExtractTestingSamples(s033, N);
                    s034_Test = ExtractTestingSamples(s034, N);
                    s035_Test = ExtractTestingSamples(s035, N);
                    s036_Test = ExtractTestingSamples(s036, N);
                    s037_Test = ExtractTestingSamples(s037, N);
                    s038_Test = ExtractTestingSamples(s038, N);
                    s039_Test = ExtractTestingSamples(s039, N);
                    s040_Test = ExtractTestingSamples(s040, N);
                    s041_Test = ExtractTestingSamples(s041, N);
                    s042_Test = ExtractTestingSamples(s042, N);
                    s043_Test = ExtractTestingSamples(s043, N);
                    s044_Test = ExtractTestingSamples(s044, N);
                    s046_Test = ExtractTestingSamples(s046, N);
                    s047_Test = ExtractTestingSamples(s047, N);
                    s048_Test = ExtractTestingSamples(s048, N);
                    s049_Test = ExtractTestingSamples(s049, N);
                    s050_Test = ExtractTestingSamples(s050, N);
                    s051_Test = ExtractTestingSamples(s051, N);
                    s052_Test = ExtractTestingSamples(s052, N);
                    s053_Test = ExtractTestingSamples(s053, N);
                    s054_Test = ExtractTestingSamples(s054, N);
                    s055_Test = ExtractTestingSamples(s055, N);
                    s056_Test = ExtractTestingSamples(s056, N);
                    s057_Test = ExtractTestingSamples(s057, N);
                    #endregion

                    CalculateImpostorScores(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mu_s011);

                    FalseRejectRate(s011_Genuine, N);
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
                Console.Write("Enter N: The number of samples.  Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s012_Samples = ExtractTrainingSamples(s012, N);

                    mu_s012 = CalculateTemplateVectors(s012_Samples, N);

                    s012_Test = ExtractTestingSamples(s012, N);

                    s012_Genuine = CalculateGenuineScores(s012_Test, mu_s012, N);

                    #region Extracting all the samples for the impostor calculations
                    s002_Test = ExtractTestingSamples(s002, N);
                    s003_Test = ExtractTestingSamples(s003, N);
                    s004_Test = ExtractTestingSamples(s004, N);
                    s005_Test = ExtractTestingSamples(s005, N);
                    s007_Test = ExtractTestingSamples(s007, N);
                    s008_Test = ExtractTestingSamples(s008, N);
                    s010_Test = ExtractTestingSamples(s010, N);
                    s011_Test = ExtractTestingSamples(s011, N);
                    // s012_Test = ExtractTestingSamples(s012, N);
                    s013_Test = ExtractTestingSamples(s013, N);
                    s015_Test = ExtractTestingSamples(s015, N);
                    s016_Test = ExtractTestingSamples(s016, N);
                    s017_Test = ExtractTestingSamples(s017, N);
                    s018_Test = ExtractTestingSamples(s018, N);
                    s019_Test = ExtractTestingSamples(s019, N);
                    s020_Test = ExtractTestingSamples(s020, N);
                    s021_Test = ExtractTestingSamples(s021, N);
                    s022_Test = ExtractTestingSamples(s022, N);
                    s024_Test = ExtractTestingSamples(s024, N);
                    s025_Test = ExtractTestingSamples(s025, N);
                    s026_Test = ExtractTestingSamples(s026, N);
                    s027_Test = ExtractTestingSamples(s027, N);
                    s028_Test = ExtractTestingSamples(s028, N);
                    s029_Test = ExtractTestingSamples(s029, N);
                    s030_Test = ExtractTestingSamples(s030, N);
                    s031_Test = ExtractTestingSamples(s031, N);
                    s032_Test = ExtractTestingSamples(s032, N);
                    s033_Test = ExtractTestingSamples(s033, N);
                    s034_Test = ExtractTestingSamples(s034, N);
                    s035_Test = ExtractTestingSamples(s035, N);
                    s036_Test = ExtractTestingSamples(s036, N);
                    s037_Test = ExtractTestingSamples(s037, N);
                    s038_Test = ExtractTestingSamples(s038, N);
                    s039_Test = ExtractTestingSamples(s039, N);
                    s040_Test = ExtractTestingSamples(s040, N);
                    s041_Test = ExtractTestingSamples(s041, N);
                    s042_Test = ExtractTestingSamples(s042, N);
                    s043_Test = ExtractTestingSamples(s043, N);
                    s044_Test = ExtractTestingSamples(s044, N);
                    s046_Test = ExtractTestingSamples(s046, N);
                    s047_Test = ExtractTestingSamples(s047, N);
                    s048_Test = ExtractTestingSamples(s048, N);
                    s049_Test = ExtractTestingSamples(s049, N);
                    s050_Test = ExtractTestingSamples(s050, N);
                    s051_Test = ExtractTestingSamples(s051, N);
                    s052_Test = ExtractTestingSamples(s052, N);
                    s053_Test = ExtractTestingSamples(s053, N);
                    s054_Test = ExtractTestingSamples(s054, N);
                    s055_Test = ExtractTestingSamples(s055, N);
                    s056_Test = ExtractTestingSamples(s056, N);
                    s057_Test = ExtractTestingSamples(s057, N);
                    #endregion

                    CalculateImpostorScores(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mu_s012);

                    FalseRejectRate(s012_Genuine, N);
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
                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s013_Samples = ExtractTrainingSamples(s013, N);

                    mu_s013 = CalculateTemplateVectors(s013_Samples, N);

                    s013_Test = ExtractTestingSamples(s013, N);

                    s013_Genuine = CalculateGenuineScores(s013_Test, mu_s013, N);

                    #region Extracting all the samples for the impostor calculations
                    s002_Test = ExtractTestingSamples(s002, N);
                    s003_Test = ExtractTestingSamples(s003, N);
                    s004_Test = ExtractTestingSamples(s004, N);
                    s005_Test = ExtractTestingSamples(s005, N);
                    s007_Test = ExtractTestingSamples(s007, N);
                    s008_Test = ExtractTestingSamples(s008, N);
                    s010_Test = ExtractTestingSamples(s010, N);
                    s011_Test = ExtractTestingSamples(s011, N);
                    s012_Test = ExtractTestingSamples(s012, N);
                    s015_Test = ExtractTestingSamples(s015, N);
                    s016_Test = ExtractTestingSamples(s016, N);
                    s017_Test = ExtractTestingSamples(s017, N);
                    s018_Test = ExtractTestingSamples(s018, N);
                    s019_Test = ExtractTestingSamples(s019, N);
                    s020_Test = ExtractTestingSamples(s020, N);
                    s021_Test = ExtractTestingSamples(s021, N);
                    s022_Test = ExtractTestingSamples(s022, N);
                    s024_Test = ExtractTestingSamples(s024, N);
                    s025_Test = ExtractTestingSamples(s025, N);
                    s026_Test = ExtractTestingSamples(s026, N);
                    s027_Test = ExtractTestingSamples(s027, N);
                    s028_Test = ExtractTestingSamples(s028, N);
                    s029_Test = ExtractTestingSamples(s029, N);
                    s030_Test = ExtractTestingSamples(s030, N);
                    s031_Test = ExtractTestingSamples(s031, N);
                    s032_Test = ExtractTestingSamples(s032, N);
                    s033_Test = ExtractTestingSamples(s033, N);
                    s034_Test = ExtractTestingSamples(s034, N);
                    s035_Test = ExtractTestingSamples(s035, N);
                    s036_Test = ExtractTestingSamples(s036, N);
                    s037_Test = ExtractTestingSamples(s037, N);
                    s038_Test = ExtractTestingSamples(s038, N);
                    s039_Test = ExtractTestingSamples(s039, N);
                    s040_Test = ExtractTestingSamples(s040, N);
                    s041_Test = ExtractTestingSamples(s041, N);
                    s042_Test = ExtractTestingSamples(s042, N);
                    s043_Test = ExtractTestingSamples(s043, N);
                    s044_Test = ExtractTestingSamples(s044, N);
                    s046_Test = ExtractTestingSamples(s046, N);
                    s047_Test = ExtractTestingSamples(s047, N);
                    s048_Test = ExtractTestingSamples(s048, N);
                    s049_Test = ExtractTestingSamples(s049, N);
                    s050_Test = ExtractTestingSamples(s050, N);
                    s051_Test = ExtractTestingSamples(s051, N);
                    s052_Test = ExtractTestingSamples(s052, N);
                    s053_Test = ExtractTestingSamples(s053, N);
                    s054_Test = ExtractTestingSamples(s054, N);
                    s055_Test = ExtractTestingSamples(s055, N);
                    s056_Test = ExtractTestingSamples(s056, N);
                    s057_Test = ExtractTestingSamples(s057, N);
                    #endregion

                    CalculateImpostorScores(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mu_s013);

                    FalseRejectRate(s013_Genuine, N); 
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
                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s015_Samples = ExtractTrainingSamples(s015, N);

                    mu_s015 = CalculateTemplateVectors(s015_Samples, N);

                    s015_Test = ExtractTestingSamples(s015, N);
                    s015_Genuine = CalculateGenuineScores(s015_Test, mu_s015, N);

                    #region Extracting all the samples for the impostor calculations
                    s002_Test = ExtractTestingSamples(s002, N);
                    s003_Test = ExtractTestingSamples(s003, N);
                    s004_Test = ExtractTestingSamples(s004, N);
                    s005_Test = ExtractTestingSamples(s005, N);
                    s007_Test = ExtractTestingSamples(s007, N);
                    s008_Test = ExtractTestingSamples(s008, N);
                    s010_Test = ExtractTestingSamples(s010, N);
                    s011_Test = ExtractTestingSamples(s011, N);
                    s012_Test = ExtractTestingSamples(s012, N);
                    s013_Test = ExtractTestingSamples(s013, N);
                    s016_Test = ExtractTestingSamples(s016, N);
                    s017_Test = ExtractTestingSamples(s017, N);
                    s018_Test = ExtractTestingSamples(s018, N);
                    s019_Test = ExtractTestingSamples(s019, N);
                    s020_Test = ExtractTestingSamples(s020, N);
                    s021_Test = ExtractTestingSamples(s021, N);
                    s022_Test = ExtractTestingSamples(s022, N);
                    s024_Test = ExtractTestingSamples(s024, N);
                    s025_Test = ExtractTestingSamples(s025, N);
                    s026_Test = ExtractTestingSamples(s026, N);
                    s027_Test = ExtractTestingSamples(s027, N);
                    s028_Test = ExtractTestingSamples(s028, N);
                    s029_Test = ExtractTestingSamples(s029, N);
                    s030_Test = ExtractTestingSamples(s030, N);
                    s031_Test = ExtractTestingSamples(s031, N);
                    s032_Test = ExtractTestingSamples(s032, N);
                    s033_Test = ExtractTestingSamples(s033, N);
                    s034_Test = ExtractTestingSamples(s034, N);
                    s035_Test = ExtractTestingSamples(s035, N);
                    s036_Test = ExtractTestingSamples(s036, N);
                    s037_Test = ExtractTestingSamples(s037, N);
                    s038_Test = ExtractTestingSamples(s038, N);
                    s039_Test = ExtractTestingSamples(s039, N);
                    s040_Test = ExtractTestingSamples(s040, N);
                    s041_Test = ExtractTestingSamples(s041, N);
                    s042_Test = ExtractTestingSamples(s042, N);
                    s043_Test = ExtractTestingSamples(s043, N);
                    s044_Test = ExtractTestingSamples(s044, N);
                    s046_Test = ExtractTestingSamples(s046, N);
                    s047_Test = ExtractTestingSamples(s047, N);
                    s048_Test = ExtractTestingSamples(s048, N);
                    s049_Test = ExtractTestingSamples(s049, N);
                    s050_Test = ExtractTestingSamples(s050, N);
                    s051_Test = ExtractTestingSamples(s051, N);
                    s052_Test = ExtractTestingSamples(s052, N);
                    s053_Test = ExtractTestingSamples(s053, N);
                    s054_Test = ExtractTestingSamples(s054, N);
                    s055_Test = ExtractTestingSamples(s055, N);
                    s056_Test = ExtractTestingSamples(s056, N);
                    s057_Test = ExtractTestingSamples(s057, N);
                    #endregion

                    CalculateImpostorScores(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mu_s015);

                    FalseRejectRate(s015_Genuine, N);
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
                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s016_Samples = ExtractTrainingSamples(s016, N);

                    mu_s016 = CalculateTemplateVectors(s016_Samples, N);

                    s016_Test = ExtractTestingSamples(s016, N);
                    s016_Genuine = CalculateGenuineScores(s016_Test, mu_s016, N);

                    #region Extracting all the samples for the impostor calculations
                    s002_Test = ExtractTestingSamples(s002, N);
                    s003_Test = ExtractTestingSamples(s003, N);
                    s004_Test = ExtractTestingSamples(s004, N);
                    s005_Test = ExtractTestingSamples(s005, N);
                    s007_Test = ExtractTestingSamples(s007, N);
                    s008_Test = ExtractTestingSamples(s008, N);
                    s010_Test = ExtractTestingSamples(s010, N);
                    s011_Test = ExtractTestingSamples(s011, N);
                    s012_Test = ExtractTestingSamples(s012, N);
                    s013_Test = ExtractTestingSamples(s013, N);
                    s015_Test = ExtractTestingSamples(s015, N);
                    s017_Test = ExtractTestingSamples(s017, N);
                    s018_Test = ExtractTestingSamples(s018, N);
                    s019_Test = ExtractTestingSamples(s019, N);
                    s020_Test = ExtractTestingSamples(s020, N);
                    s021_Test = ExtractTestingSamples(s021, N);
                    s022_Test = ExtractTestingSamples(s022, N);
                    s024_Test = ExtractTestingSamples(s024, N);
                    s025_Test = ExtractTestingSamples(s025, N);
                    s026_Test = ExtractTestingSamples(s026, N);
                    s027_Test = ExtractTestingSamples(s027, N);
                    s028_Test = ExtractTestingSamples(s028, N);
                    s029_Test = ExtractTestingSamples(s029, N);
                    s030_Test = ExtractTestingSamples(s030, N);
                    s031_Test = ExtractTestingSamples(s031, N);
                    s032_Test = ExtractTestingSamples(s032, N);
                    s033_Test = ExtractTestingSamples(s033, N);
                    s034_Test = ExtractTestingSamples(s034, N);
                    s035_Test = ExtractTestingSamples(s035, N);
                    s036_Test = ExtractTestingSamples(s036, N);
                    s037_Test = ExtractTestingSamples(s037, N);
                    s038_Test = ExtractTestingSamples(s038, N);
                    s039_Test = ExtractTestingSamples(s039, N);
                    s040_Test = ExtractTestingSamples(s040, N);
                    s041_Test = ExtractTestingSamples(s041, N);
                    s042_Test = ExtractTestingSamples(s042, N);
                    s043_Test = ExtractTestingSamples(s043, N);
                    s044_Test = ExtractTestingSamples(s044, N);
                    s046_Test = ExtractTestingSamples(s046, N);
                    s047_Test = ExtractTestingSamples(s047, N);
                    s048_Test = ExtractTestingSamples(s048, N);
                    s049_Test = ExtractTestingSamples(s049, N);
                    s050_Test = ExtractTestingSamples(s050, N);
                    s051_Test = ExtractTestingSamples(s051, N);
                    s052_Test = ExtractTestingSamples(s052, N);
                    s053_Test = ExtractTestingSamples(s053, N);
                    s054_Test = ExtractTestingSamples(s054, N);
                    s055_Test = ExtractTestingSamples(s055, N);
                    s056_Test = ExtractTestingSamples(s056, N);
                    s057_Test = ExtractTestingSamples(s057, N);
                    #endregion

                    CalculateImpostorScores(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mu_s016);

                    FalseRejectRate(s016_Genuine, N);
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
                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s017_Samples = ExtractTrainingSamples(s017, N);

                    mu_s017 = CalculateTemplateVectors(s017_Samples, N);

                    s017_Test = ExtractTestingSamples(s017, N);

                    s017_Genuine = CalculateGenuineScores(s017_Test, mu_s017, N);

                    #region Extracting all the samples for the impostor calculations
                    s002_Test = ExtractTestingSamples(s002, N);
                    s003_Test = ExtractTestingSamples(s003, N);
                    s004_Test = ExtractTestingSamples(s004, N);
                    s005_Test = ExtractTestingSamples(s005, N);
                    s007_Test = ExtractTestingSamples(s007, N);
                    s008_Test = ExtractTestingSamples(s008, N);
                    s010_Test = ExtractTestingSamples(s010, N);
                    s011_Test = ExtractTestingSamples(s011, N);
                    s012_Test = ExtractTestingSamples(s012, N);
                    s013_Test = ExtractTestingSamples(s013, N);
                    s015_Test = ExtractTestingSamples(s015, N);
                    s016_Test = ExtractTestingSamples(s016, N);
                    s018_Test = ExtractTestingSamples(s018, N);
                    s019_Test = ExtractTestingSamples(s019, N);
                    s020_Test = ExtractTestingSamples(s020, N);
                    s021_Test = ExtractTestingSamples(s021, N);
                    s022_Test = ExtractTestingSamples(s022, N);
                    s024_Test = ExtractTestingSamples(s024, N);
                    s025_Test = ExtractTestingSamples(s025, N);
                    s026_Test = ExtractTestingSamples(s026, N);
                    s027_Test = ExtractTestingSamples(s027, N);
                    s028_Test = ExtractTestingSamples(s028, N);
                    s029_Test = ExtractTestingSamples(s029, N);
                    s030_Test = ExtractTestingSamples(s030, N);
                    s031_Test = ExtractTestingSamples(s031, N);
                    s032_Test = ExtractTestingSamples(s032, N);
                    s033_Test = ExtractTestingSamples(s033, N);
                    s034_Test = ExtractTestingSamples(s034, N);
                    s035_Test = ExtractTestingSamples(s035, N);
                    s036_Test = ExtractTestingSamples(s036, N);
                    s037_Test = ExtractTestingSamples(s037, N);
                    s038_Test = ExtractTestingSamples(s038, N);
                    s039_Test = ExtractTestingSamples(s039, N);
                    s040_Test = ExtractTestingSamples(s040, N);
                    s041_Test = ExtractTestingSamples(s041, N);
                    s042_Test = ExtractTestingSamples(s042, N);
                    s043_Test = ExtractTestingSamples(s043, N);
                    s044_Test = ExtractTestingSamples(s044, N);
                    s046_Test = ExtractTestingSamples(s046, N);
                    s047_Test = ExtractTestingSamples(s047, N);
                    s048_Test = ExtractTestingSamples(s048, N);
                    s049_Test = ExtractTestingSamples(s049, N);
                    s050_Test = ExtractTestingSamples(s050, N);
                    s051_Test = ExtractTestingSamples(s051, N);
                    s052_Test = ExtractTestingSamples(s052, N);
                    s053_Test = ExtractTestingSamples(s053, N);
                    s054_Test = ExtractTestingSamples(s054, N);
                    s055_Test = ExtractTestingSamples(s055, N);
                    s056_Test = ExtractTestingSamples(s056, N);
                    s057_Test = ExtractTestingSamples(s057, N);
                    #endregion

                    CalculateImpostorScores(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mu_s017);

                    FalseRejectRate(s017_Genuine, N);
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
                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s018_Samples = ExtractTrainingSamples(s018, N);

                    mu_s018 = CalculateTemplateVectors(s018_Samples, N);

                    s018_Test = ExtractTestingSamples(s018, N);
                    s018_Genuine = CalculateGenuineScores(s018_Test, mu_s018, N);

                    #region Extracting all the samples for the impostor calculations
                    s002_Test = ExtractTestingSamples(s002, N);
                    s003_Test = ExtractTestingSamples(s003, N);
                    s004_Test = ExtractTestingSamples(s004, N);
                    s005_Test = ExtractTestingSamples(s005, N);
                    s007_Test = ExtractTestingSamples(s007, N);
                    s008_Test = ExtractTestingSamples(s008, N);
                    s010_Test = ExtractTestingSamples(s010, N);
                    s011_Test = ExtractTestingSamples(s011, N);
                    s012_Test = ExtractTestingSamples(s012, N);
                    s013_Test = ExtractTestingSamples(s013, N);
                    s015_Test = ExtractTestingSamples(s015, N);
                    s016_Test = ExtractTestingSamples(s016, N);
                    s017_Test = ExtractTestingSamples(s017, N);
                    s019_Test = ExtractTestingSamples(s019, N);
                    s020_Test = ExtractTestingSamples(s020, N);
                    s021_Test = ExtractTestingSamples(s021, N);
                    s022_Test = ExtractTestingSamples(s022, N);
                    s024_Test = ExtractTestingSamples(s024, N);
                    s025_Test = ExtractTestingSamples(s025, N);
                    s026_Test = ExtractTestingSamples(s026, N);
                    s027_Test = ExtractTestingSamples(s027, N);
                    s028_Test = ExtractTestingSamples(s028, N);
                    s029_Test = ExtractTestingSamples(s029, N);
                    s030_Test = ExtractTestingSamples(s030, N);
                    s031_Test = ExtractTestingSamples(s031, N);
                    s032_Test = ExtractTestingSamples(s032, N);
                    s033_Test = ExtractTestingSamples(s033, N);
                    s034_Test = ExtractTestingSamples(s034, N);
                    s035_Test = ExtractTestingSamples(s035, N);
                    s036_Test = ExtractTestingSamples(s036, N);
                    s037_Test = ExtractTestingSamples(s037, N);
                    s038_Test = ExtractTestingSamples(s038, N);
                    s039_Test = ExtractTestingSamples(s039, N);
                    s040_Test = ExtractTestingSamples(s040, N);
                    s041_Test = ExtractTestingSamples(s041, N);
                    s042_Test = ExtractTestingSamples(s042, N);
                    s043_Test = ExtractTestingSamples(s043, N);
                    s044_Test = ExtractTestingSamples(s044, N);
                    s046_Test = ExtractTestingSamples(s046, N);
                    s047_Test = ExtractTestingSamples(s047, N);
                    s048_Test = ExtractTestingSamples(s048, N);
                    s049_Test = ExtractTestingSamples(s049, N);
                    s050_Test = ExtractTestingSamples(s050, N);
                    s051_Test = ExtractTestingSamples(s051, N);
                    s052_Test = ExtractTestingSamples(s052, N);
                    s053_Test = ExtractTestingSamples(s053, N);
                    s054_Test = ExtractTestingSamples(s054, N);
                    s055_Test = ExtractTestingSamples(s055, N);
                    s056_Test = ExtractTestingSamples(s056, N);
                    s057_Test = ExtractTestingSamples(s057, N);
                    #endregion

                    CalculateImpostorScores(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mu_s018);

                    FalseRejectRate(s018_Genuine, N);
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
                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s019_Samples = ExtractTrainingSamples(s019, N);

                    mu_s019 = CalculateTemplateVectors(s019_Samples, N);

                    s019_Test = ExtractTestingSamples(s019, N);
                    s019_Genuine = CalculateGenuineScores(s019_Test, mu_s019, N);

                    #region Extracting all the samples for the impostor calculations
                    s002_Test = ExtractTestingSamples(s002, N);
                    s003_Test = ExtractTestingSamples(s003, N);
                    s004_Test = ExtractTestingSamples(s004, N);
                    s005_Test = ExtractTestingSamples(s005, N);
                    s007_Test = ExtractTestingSamples(s007, N);
                    s008_Test = ExtractTestingSamples(s008, N);
                    s010_Test = ExtractTestingSamples(s010, N);
                    s011_Test = ExtractTestingSamples(s011, N);
                    s012_Test = ExtractTestingSamples(s012, N);
                    s013_Test = ExtractTestingSamples(s013, N);
                    s015_Test = ExtractTestingSamples(s015, N);
                    s016_Test = ExtractTestingSamples(s016, N);
                    s017_Test = ExtractTestingSamples(s017, N);
                    s018_Test = ExtractTestingSamples(s018, N);
                    s020_Test = ExtractTestingSamples(s020, N);
                    s021_Test = ExtractTestingSamples(s021, N);
                    s022_Test = ExtractTestingSamples(s022, N);
                    s024_Test = ExtractTestingSamples(s024, N);
                    s025_Test = ExtractTestingSamples(s025, N);
                    s026_Test = ExtractTestingSamples(s026, N);
                    s027_Test = ExtractTestingSamples(s027, N);
                    s028_Test = ExtractTestingSamples(s028, N);
                    s029_Test = ExtractTestingSamples(s029, N);
                    s030_Test = ExtractTestingSamples(s030, N);
                    s031_Test = ExtractTestingSamples(s031, N);
                    s032_Test = ExtractTestingSamples(s032, N);
                    s033_Test = ExtractTestingSamples(s033, N);
                    s034_Test = ExtractTestingSamples(s034, N);
                    s035_Test = ExtractTestingSamples(s035, N);
                    s036_Test = ExtractTestingSamples(s036, N);
                    s037_Test = ExtractTestingSamples(s037, N);
                    s038_Test = ExtractTestingSamples(s038, N);
                    s039_Test = ExtractTestingSamples(s039, N);
                    s040_Test = ExtractTestingSamples(s040, N);
                    s041_Test = ExtractTestingSamples(s041, N);
                    s042_Test = ExtractTestingSamples(s042, N);
                    s043_Test = ExtractTestingSamples(s043, N);
                    s044_Test = ExtractTestingSamples(s044, N);
                    s046_Test = ExtractTestingSamples(s046, N);
                    s047_Test = ExtractTestingSamples(s047, N);
                    s048_Test = ExtractTestingSamples(s048, N);
                    s049_Test = ExtractTestingSamples(s049, N);
                    s050_Test = ExtractTestingSamples(s050, N);
                    s051_Test = ExtractTestingSamples(s051, N);
                    s052_Test = ExtractTestingSamples(s052, N);
                    s053_Test = ExtractTestingSamples(s053, N);
                    s054_Test = ExtractTestingSamples(s054, N);
                    s055_Test = ExtractTestingSamples(s055, N);
                    s056_Test = ExtractTestingSamples(s056, N);
                    s057_Test = ExtractTestingSamples(s057, N);
                    #endregion

                    CalculateImpostorScores(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mu_s019);

                    FalseRejectRate(s019_Genuine, N);
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
                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s020_Samples = ExtractTrainingSamples(s020, N);

                    mu_s020 = CalculateTemplateVectors(s020_Samples, N);

                    s020_Test = ExtractTestingSamples(s020, N);

                    s020_Genuine = CalculateGenuineScores(s020_Test, mu_s020, N);

                    #region Extracting all the samples for the impostor calculations
                    s002_Test = ExtractTestingSamples(s002, N);
                    s003_Test = ExtractTestingSamples(s003, N);
                    s004_Test = ExtractTestingSamples(s004, N);
                    s005_Test = ExtractTestingSamples(s005, N);
                    s007_Test = ExtractTestingSamples(s007, N);
                    s008_Test = ExtractTestingSamples(s008, N);
                    s010_Test = ExtractTestingSamples(s010, N);
                    s011_Test = ExtractTestingSamples(s011, N);
                    s012_Test = ExtractTestingSamples(s012, N);
                    s013_Test = ExtractTestingSamples(s013, N);
                    s015_Test = ExtractTestingSamples(s015, N);
                    s016_Test = ExtractTestingSamples(s016, N);
                    s017_Test = ExtractTestingSamples(s017, N);
                    s018_Test = ExtractTestingSamples(s018, N);
                    s019_Test = ExtractTestingSamples(s019, N);
                    s021_Test = ExtractTestingSamples(s021, N);
                    s022_Test = ExtractTestingSamples(s022, N);
                    s024_Test = ExtractTestingSamples(s024, N);
                    s025_Test = ExtractTestingSamples(s025, N);
                    s026_Test = ExtractTestingSamples(s026, N);
                    s027_Test = ExtractTestingSamples(s027, N);
                    s028_Test = ExtractTestingSamples(s028, N);
                    s029_Test = ExtractTestingSamples(s029, N);
                    s030_Test = ExtractTestingSamples(s030, N);
                    s031_Test = ExtractTestingSamples(s031, N);
                    s032_Test = ExtractTestingSamples(s032, N);
                    s033_Test = ExtractTestingSamples(s033, N);
                    s034_Test = ExtractTestingSamples(s034, N);
                    s035_Test = ExtractTestingSamples(s035, N);
                    s036_Test = ExtractTestingSamples(s036, N);
                    s037_Test = ExtractTestingSamples(s037, N);
                    s038_Test = ExtractTestingSamples(s038, N);
                    s039_Test = ExtractTestingSamples(s039, N);
                    s040_Test = ExtractTestingSamples(s040, N);
                    s041_Test = ExtractTestingSamples(s041, N);
                    s042_Test = ExtractTestingSamples(s042, N);
                    s043_Test = ExtractTestingSamples(s043, N);
                    s044_Test = ExtractTestingSamples(s044, N);
                    s046_Test = ExtractTestingSamples(s046, N);
                    s047_Test = ExtractTestingSamples(s047, N);
                    s048_Test = ExtractTestingSamples(s048, N);
                    s049_Test = ExtractTestingSamples(s049, N);
                    s050_Test = ExtractTestingSamples(s050, N);
                    s051_Test = ExtractTestingSamples(s051, N);
                    s052_Test = ExtractTestingSamples(s052, N);
                    s053_Test = ExtractTestingSamples(s053, N);
                    s054_Test = ExtractTestingSamples(s054, N);
                    s055_Test = ExtractTestingSamples(s055, N);
                    s056_Test = ExtractTestingSamples(s056, N);
                    s057_Test = ExtractTestingSamples(s057, N);
                    #endregion

                    CalculateImpostorScores(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mu_s020);

                    FalseRejectRate(s020_Genuine, N);
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
                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s021_Samples = ExtractTrainingSamples(s021, N);

                    mu_s021 = CalculateTemplateVectors(s021_Samples, N);

                    s021_Test = ExtractTestingSamples(s021, N);

                    s021_Genuine = CalculateGenuineScores(s021_Test, mu_s021, N);

                    #region Extracting all the samples for the impostor calculations
                    s002_Test = ExtractTestingSamples(s002, N);
                    s003_Test = ExtractTestingSamples(s003, N);
                    s004_Test = ExtractTestingSamples(s004, N);
                    s005_Test = ExtractTestingSamples(s005, N);
                    s007_Test = ExtractTestingSamples(s007, N);
                    s008_Test = ExtractTestingSamples(s008, N);
                    s010_Test = ExtractTestingSamples(s010, N);
                    s011_Test = ExtractTestingSamples(s011, N);
                    s012_Test = ExtractTestingSamples(s012, N);
                    s013_Test = ExtractTestingSamples(s013, N);
                    s015_Test = ExtractTestingSamples(s015, N);
                    s016_Test = ExtractTestingSamples(s016, N);
                    s017_Test = ExtractTestingSamples(s017, N);
                    s018_Test = ExtractTestingSamples(s018, N);
                    s019_Test = ExtractTestingSamples(s019, N);
                    s020_Test = ExtractTestingSamples(s020, N);
                    s022_Test = ExtractTestingSamples(s022, N);
                    s024_Test = ExtractTestingSamples(s024, N);
                    s025_Test = ExtractTestingSamples(s025, N);
                    s026_Test = ExtractTestingSamples(s026, N);
                    s027_Test = ExtractTestingSamples(s027, N);
                    s028_Test = ExtractTestingSamples(s028, N);
                    s029_Test = ExtractTestingSamples(s029, N);
                    s030_Test = ExtractTestingSamples(s030, N);
                    s031_Test = ExtractTestingSamples(s031, N);
                    s032_Test = ExtractTestingSamples(s032, N);
                    s033_Test = ExtractTestingSamples(s033, N);
                    s034_Test = ExtractTestingSamples(s034, N);
                    s035_Test = ExtractTestingSamples(s035, N);
                    s036_Test = ExtractTestingSamples(s036, N);
                    s037_Test = ExtractTestingSamples(s037, N);
                    s038_Test = ExtractTestingSamples(s038, N);
                    s039_Test = ExtractTestingSamples(s039, N);
                    s040_Test = ExtractTestingSamples(s040, N);
                    s041_Test = ExtractTestingSamples(s041, N);
                    s042_Test = ExtractTestingSamples(s042, N);
                    s043_Test = ExtractTestingSamples(s043, N);
                    s044_Test = ExtractTestingSamples(s044, N);
                    s046_Test = ExtractTestingSamples(s046, N);
                    s047_Test = ExtractTestingSamples(s047, N);
                    s048_Test = ExtractTestingSamples(s048, N);
                    s049_Test = ExtractTestingSamples(s049, N);
                    s050_Test = ExtractTestingSamples(s050, N);
                    s051_Test = ExtractTestingSamples(s051, N);
                    s052_Test = ExtractTestingSamples(s052, N);
                    s053_Test = ExtractTestingSamples(s053, N);
                    s054_Test = ExtractTestingSamples(s054, N);
                    s055_Test = ExtractTestingSamples(s055, N);
                    s056_Test = ExtractTestingSamples(s056, N);
                    s057_Test = ExtractTestingSamples(s057, N);
                    #endregion

                    CalculateImpostorScores(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mu_s021);

                    FalseRejectRate(s021_Genuine, N); 
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
                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s022_Samples = ExtractTrainingSamples(s022, N);

                    mu_s022 = CalculateTemplateVectors(s022_Samples, N);

                    s022_Test = ExtractTestingSamples(s022, N);

                    s022_Genuine = CalculateGenuineScores(s022_Test, mu_s022, N);

                    #region Extracting all the samples for the impostor calculations
                    s002_Test = ExtractTestingSamples(s002, N);
                    s003_Test = ExtractTestingSamples(s003, N);
                    s004_Test = ExtractTestingSamples(s004, N);
                    s005_Test = ExtractTestingSamples(s005, N);
                    s007_Test = ExtractTestingSamples(s007, N);
                    s008_Test = ExtractTestingSamples(s008, N);
                    s010_Test = ExtractTestingSamples(s010, N);
                    s011_Test = ExtractTestingSamples(s011, N);
                    s012_Test = ExtractTestingSamples(s012, N);
                    s013_Test = ExtractTestingSamples(s013, N);
                    s015_Test = ExtractTestingSamples(s015, N);
                    s016_Test = ExtractTestingSamples(s016, N);
                    s017_Test = ExtractTestingSamples(s017, N);
                    s018_Test = ExtractTestingSamples(s018, N);
                    s019_Test = ExtractTestingSamples(s019, N);
                    s020_Test = ExtractTestingSamples(s020, N);
                    s021_Test = ExtractTestingSamples(s021, N);
                    s022_Test = ExtractTestingSamples(s022, N);
                    s024_Test = ExtractTestingSamples(s024, N);
                    s025_Test = ExtractTestingSamples(s025, N);
                    s026_Test = ExtractTestingSamples(s026, N);
                    s027_Test = ExtractTestingSamples(s027, N);
                    s028_Test = ExtractTestingSamples(s028, N);
                    s029_Test = ExtractTestingSamples(s029, N);
                    s030_Test = ExtractTestingSamples(s030, N);
                    s031_Test = ExtractTestingSamples(s031, N);
                    s032_Test = ExtractTestingSamples(s032, N);
                    s033_Test = ExtractTestingSamples(s033, N);
                    s034_Test = ExtractTestingSamples(s034, N);
                    s035_Test = ExtractTestingSamples(s035, N);
                    s036_Test = ExtractTestingSamples(s036, N);
                    s037_Test = ExtractTestingSamples(s037, N);
                    s038_Test = ExtractTestingSamples(s038, N);
                    s039_Test = ExtractTestingSamples(s039, N);
                    s040_Test = ExtractTestingSamples(s040, N);
                    s041_Test = ExtractTestingSamples(s041, N);
                    s042_Test = ExtractTestingSamples(s042, N);
                    s043_Test = ExtractTestingSamples(s043, N);
                    s044_Test = ExtractTestingSamples(s044, N);
                    s046_Test = ExtractTestingSamples(s046, N);
                    s047_Test = ExtractTestingSamples(s047, N);
                    s048_Test = ExtractTestingSamples(s048, N);
                    s049_Test = ExtractTestingSamples(s049, N);
                    s050_Test = ExtractTestingSamples(s050, N);
                    s051_Test = ExtractTestingSamples(s051, N);
                    s052_Test = ExtractTestingSamples(s052, N);
                    s053_Test = ExtractTestingSamples(s053, N);
                    s054_Test = ExtractTestingSamples(s054, N);
                    s055_Test = ExtractTestingSamples(s055, N);
                    s056_Test = ExtractTestingSamples(s056, N);
                    s057_Test = ExtractTestingSamples(s057, N);
                    #endregion

                    CalculateImpostorScores(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mu_s022);

                    FalseRejectRate(s022_Genuine, N);
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
                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s024_Samples = ExtractTrainingSamples(s024, N);

                    mu_s024 = CalculateTemplateVectors(s024_Samples, N);

                    s024_Test = ExtractTestingSamples(s024, N);

                    s024_Genuine = CalculateGenuineScores(s024_Test, mu_s024, N);

                    #region Extracting all the samples for the impostor calculations
                    s002_Test = ExtractTestingSamples(s002, N);
                    s003_Test = ExtractTestingSamples(s003, N);
                    s004_Test = ExtractTestingSamples(s004, N);
                    s005_Test = ExtractTestingSamples(s005, N);
                    s007_Test = ExtractTestingSamples(s007, N);
                    s008_Test = ExtractTestingSamples(s008, N);
                    s010_Test = ExtractTestingSamples(s010, N);
                    s011_Test = ExtractTestingSamples(s011, N);
                    s012_Test = ExtractTestingSamples(s012, N);
                    s013_Test = ExtractTestingSamples(s013, N);
                    s015_Test = ExtractTestingSamples(s015, N);
                    s016_Test = ExtractTestingSamples(s016, N);
                    s017_Test = ExtractTestingSamples(s017, N);
                    s018_Test = ExtractTestingSamples(s018, N);
                    s019_Test = ExtractTestingSamples(s019, N);
                    s020_Test = ExtractTestingSamples(s020, N);
                    s021_Test = ExtractTestingSamples(s021, N);
                    s022_Test = ExtractTestingSamples(s022, N);
                    s025_Test = ExtractTestingSamples(s025, N);
                    s026_Test = ExtractTestingSamples(s026, N);
                    s027_Test = ExtractTestingSamples(s027, N);
                    s028_Test = ExtractTestingSamples(s028, N);
                    s029_Test = ExtractTestingSamples(s029, N);
                    s030_Test = ExtractTestingSamples(s030, N);
                    s031_Test = ExtractTestingSamples(s031, N);
                    s032_Test = ExtractTestingSamples(s032, N);
                    s033_Test = ExtractTestingSamples(s033, N);
                    s034_Test = ExtractTestingSamples(s034, N);
                    s035_Test = ExtractTestingSamples(s035, N);
                    s036_Test = ExtractTestingSamples(s036, N);
                    s037_Test = ExtractTestingSamples(s037, N);
                    s038_Test = ExtractTestingSamples(s038, N);
                    s039_Test = ExtractTestingSamples(s039, N);
                    s040_Test = ExtractTestingSamples(s040, N);
                    s041_Test = ExtractTestingSamples(s041, N);
                    s042_Test = ExtractTestingSamples(s042, N);
                    s043_Test = ExtractTestingSamples(s043, N);
                    s044_Test = ExtractTestingSamples(s044, N);
                    s046_Test = ExtractTestingSamples(s046, N);
                    s047_Test = ExtractTestingSamples(s047, N);
                    s048_Test = ExtractTestingSamples(s048, N);
                    s049_Test = ExtractTestingSamples(s049, N);
                    s050_Test = ExtractTestingSamples(s050, N);
                    s051_Test = ExtractTestingSamples(s051, N);
                    s052_Test = ExtractTestingSamples(s052, N);
                    s053_Test = ExtractTestingSamples(s053, N);
                    s054_Test = ExtractTestingSamples(s054, N);
                    s055_Test = ExtractTestingSamples(s055, N);
                    s056_Test = ExtractTestingSamples(s056, N);
                    s057_Test = ExtractTestingSamples(s057, N);
                    #endregion

                    CalculateImpostorScores(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mu_s024);

                    FalseRejectRate(s024_Genuine, N);
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
                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s025_Samples = ExtractTrainingSamples(s025, N);

                    mu_s025 = CalculateTemplateVectors(s025_Samples, N);

                    s025_Test = ExtractTestingSamples(s025, N);

                    s025_Genuine = CalculateGenuineScores(s025_Test, mu_s025, N);

                    #region Extracting all the samples for the impostor calculations
                    s002_Test = ExtractTestingSamples(s002, N);
                    s003_Test = ExtractTestingSamples(s003, N);
                    s004_Test = ExtractTestingSamples(s004, N);
                    s005_Test = ExtractTestingSamples(s005, N);
                    s007_Test = ExtractTestingSamples(s007, N);
                    s008_Test = ExtractTestingSamples(s008, N);
                    s010_Test = ExtractTestingSamples(s010, N);
                    s011_Test = ExtractTestingSamples(s011, N);
                    s012_Test = ExtractTestingSamples(s012, N);
                    s013_Test = ExtractTestingSamples(s013, N);
                    s015_Test = ExtractTestingSamples(s015, N);
                    s016_Test = ExtractTestingSamples(s016, N);
                    s017_Test = ExtractTestingSamples(s017, N);
                    s018_Test = ExtractTestingSamples(s018, N);
                    s019_Test = ExtractTestingSamples(s019, N);
                    s020_Test = ExtractTestingSamples(s020, N);
                    s021_Test = ExtractTestingSamples(s021, N);
                    s022_Test = ExtractTestingSamples(s022, N);
                    s024_Test = ExtractTestingSamples(s024, N);
                    s026_Test = ExtractTestingSamples(s026, N);
                    s027_Test = ExtractTestingSamples(s027, N);
                    s028_Test = ExtractTestingSamples(s028, N);
                    s029_Test = ExtractTestingSamples(s029, N);
                    s030_Test = ExtractTestingSamples(s030, N);
                    s031_Test = ExtractTestingSamples(s031, N);
                    s032_Test = ExtractTestingSamples(s032, N);
                    s033_Test = ExtractTestingSamples(s033, N);
                    s034_Test = ExtractTestingSamples(s034, N);
                    s035_Test = ExtractTestingSamples(s035, N);
                    s036_Test = ExtractTestingSamples(s036, N);
                    s037_Test = ExtractTestingSamples(s037, N);
                    s038_Test = ExtractTestingSamples(s038, N);
                    s039_Test = ExtractTestingSamples(s039, N);
                    s040_Test = ExtractTestingSamples(s040, N);
                    s041_Test = ExtractTestingSamples(s041, N);
                    s042_Test = ExtractTestingSamples(s042, N);
                    s043_Test = ExtractTestingSamples(s043, N);
                    s044_Test = ExtractTestingSamples(s044, N);
                    s046_Test = ExtractTestingSamples(s046, N);
                    s047_Test = ExtractTestingSamples(s047, N);
                    s048_Test = ExtractTestingSamples(s048, N);
                    s049_Test = ExtractTestingSamples(s049, N);
                    s050_Test = ExtractTestingSamples(s050, N);
                    s051_Test = ExtractTestingSamples(s051, N);
                    s052_Test = ExtractTestingSamples(s052, N);
                    s053_Test = ExtractTestingSamples(s053, N);
                    s054_Test = ExtractTestingSamples(s054, N);
                    s055_Test = ExtractTestingSamples(s055, N);
                    s056_Test = ExtractTestingSamples(s056, N);
                    s057_Test = ExtractTestingSamples(s057, N);
                    #endregion

                    CalculateImpostorScores(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mu_s025);

                    FalseRejectRate(s025_Genuine, N); 
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
                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s026_Samples = ExtractTrainingSamples(s026, N);

                    mu_s026 = CalculateTemplateVectors(s026_Samples, N);

                    s026_Test = ExtractTestingSamples(s026, N);

                    s026_Genuine = CalculateGenuineScores(s026_Test, mu_s026, N);

                    #region Extracting all the samples for the impostor calculations
                    s002_Test = ExtractTestingSamples(s002, N);
                    s003_Test = ExtractTestingSamples(s003, N);
                    s004_Test = ExtractTestingSamples(s004, N);
                    s005_Test = ExtractTestingSamples(s005, N);
                    s007_Test = ExtractTestingSamples(s007, N);
                    s008_Test = ExtractTestingSamples(s008, N);
                    s010_Test = ExtractTestingSamples(s010, N);
                    s011_Test = ExtractTestingSamples(s011, N);
                    s012_Test = ExtractTestingSamples(s012, N);
                    s013_Test = ExtractTestingSamples(s013, N);
                    s015_Test = ExtractTestingSamples(s015, N);
                    s016_Test = ExtractTestingSamples(s016, N);
                    s017_Test = ExtractTestingSamples(s017, N);
                    s018_Test = ExtractTestingSamples(s018, N);
                    s019_Test = ExtractTestingSamples(s019, N);
                    s020_Test = ExtractTestingSamples(s020, N);
                    s021_Test = ExtractTestingSamples(s021, N);
                    s022_Test = ExtractTestingSamples(s022, N);
                    s024_Test = ExtractTestingSamples(s024, N);
                    s025_Test = ExtractTestingSamples(s025, N);
                    s027_Test = ExtractTestingSamples(s027, N);
                    s028_Test = ExtractTestingSamples(s028, N);
                    s029_Test = ExtractTestingSamples(s029, N);
                    s030_Test = ExtractTestingSamples(s030, N);
                    s031_Test = ExtractTestingSamples(s031, N);
                    s032_Test = ExtractTestingSamples(s032, N);
                    s033_Test = ExtractTestingSamples(s033, N);
                    s034_Test = ExtractTestingSamples(s034, N);
                    s035_Test = ExtractTestingSamples(s035, N);
                    s036_Test = ExtractTestingSamples(s036, N);
                    s037_Test = ExtractTestingSamples(s037, N);
                    s038_Test = ExtractTestingSamples(s038, N);
                    s039_Test = ExtractTestingSamples(s039, N);
                    s040_Test = ExtractTestingSamples(s040, N);
                    s041_Test = ExtractTestingSamples(s041, N);
                    s042_Test = ExtractTestingSamples(s042, N);
                    s043_Test = ExtractTestingSamples(s043, N);
                    s044_Test = ExtractTestingSamples(s044, N);
                    s046_Test = ExtractTestingSamples(s046, N);
                    s047_Test = ExtractTestingSamples(s047, N);
                    s048_Test = ExtractTestingSamples(s048, N);
                    s049_Test = ExtractTestingSamples(s049, N);
                    s050_Test = ExtractTestingSamples(s050, N);
                    s051_Test = ExtractTestingSamples(s051, N);
                    s052_Test = ExtractTestingSamples(s052, N);
                    s053_Test = ExtractTestingSamples(s053, N);
                    s054_Test = ExtractTestingSamples(s054, N);
                    s055_Test = ExtractTestingSamples(s055, N);
                    s056_Test = ExtractTestingSamples(s056, N);
                    s057_Test = ExtractTestingSamples(s057, N);
                    #endregion

                    CalculateImpostorScores(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mu_s026);

                    FalseRejectRate(s026_Genuine, N);
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
                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s027_Samples = ExtractTrainingSamples(s027, N);

                    mu_s027 = CalculateTemplateVectors(s027_Samples, N);

                    s027_Test = ExtractTestingSamples(s027, N);

                    s027_Genuine = CalculateGenuineScores(s027_Test, mu_s027, N);

                    #region Extracting all the samples for the impostor calculations
                    s002_Test = ExtractTestingSamples(s002, N);
                    s003_Test = ExtractTestingSamples(s003, N);
                    s004_Test = ExtractTestingSamples(s004, N);
                    s005_Test = ExtractTestingSamples(s005, N);
                    s007_Test = ExtractTestingSamples(s007, N);
                    s008_Test = ExtractTestingSamples(s008, N);
                    s010_Test = ExtractTestingSamples(s010, N);
                    s011_Test = ExtractTestingSamples(s011, N);
                    s012_Test = ExtractTestingSamples(s012, N);
                    s013_Test = ExtractTestingSamples(s013, N);
                    s015_Test = ExtractTestingSamples(s015, N);
                    s016_Test = ExtractTestingSamples(s016, N);
                    s017_Test = ExtractTestingSamples(s017, N);
                    s018_Test = ExtractTestingSamples(s018, N);
                    s019_Test = ExtractTestingSamples(s019, N);
                    s020_Test = ExtractTestingSamples(s020, N);
                    s021_Test = ExtractTestingSamples(s021, N);
                    s022_Test = ExtractTestingSamples(s022, N);
                    s024_Test = ExtractTestingSamples(s024, N);
                    s025_Test = ExtractTestingSamples(s025, N);
                    s026_Test = ExtractTestingSamples(s026, N);
                    s028_Test = ExtractTestingSamples(s028, N);
                    s029_Test = ExtractTestingSamples(s029, N);
                    s030_Test = ExtractTestingSamples(s030, N);
                    s031_Test = ExtractTestingSamples(s031, N);
                    s032_Test = ExtractTestingSamples(s032, N);
                    s033_Test = ExtractTestingSamples(s033, N);
                    s034_Test = ExtractTestingSamples(s034, N);
                    s035_Test = ExtractTestingSamples(s035, N);
                    s036_Test = ExtractTestingSamples(s036, N);
                    s037_Test = ExtractTestingSamples(s037, N);
                    s038_Test = ExtractTestingSamples(s038, N);
                    s039_Test = ExtractTestingSamples(s039, N);
                    s040_Test = ExtractTestingSamples(s040, N);
                    s041_Test = ExtractTestingSamples(s041, N);
                    s042_Test = ExtractTestingSamples(s042, N);
                    s043_Test = ExtractTestingSamples(s043, N);
                    s044_Test = ExtractTestingSamples(s044, N);
                    s046_Test = ExtractTestingSamples(s046, N);
                    s047_Test = ExtractTestingSamples(s047, N);
                    s048_Test = ExtractTestingSamples(s048, N);
                    s049_Test = ExtractTestingSamples(s049, N);
                    s050_Test = ExtractTestingSamples(s050, N);
                    s051_Test = ExtractTestingSamples(s051, N);
                    s052_Test = ExtractTestingSamples(s052, N);
                    s053_Test = ExtractTestingSamples(s053, N);
                    s054_Test = ExtractTestingSamples(s054, N);
                    s055_Test = ExtractTestingSamples(s055, N);
                    s056_Test = ExtractTestingSamples(s056, N);
                    s057_Test = ExtractTestingSamples(s057, N);
                    #endregion

                    CalculateImpostorScores(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mu_s027);

                    FalseRejectRate(s027_Genuine, N);
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
                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s028_Samples = ExtractTrainingSamples(s028, N);

                    mu_s028 = CalculateTemplateVectors(s028_Samples, N);

                    s028_Test = ExtractTestingSamples(s028, N);

                    s028_Genuine = CalculateGenuineScores(s028_Test, mu_s028, N);

                    #region Extracting all the samples for the impostor calculation
                    s002_Test = ExtractTestingSamples(s002, N);
                    s003_Test = ExtractTestingSamples(s003, N);
                    s004_Test = ExtractTestingSamples(s004, N);
                    s005_Test = ExtractTestingSamples(s005, N);
                    s007_Test = ExtractTestingSamples(s007, N);
                    s008_Test = ExtractTestingSamples(s008, N);
                    s010_Test = ExtractTestingSamples(s010, N);
                    s011_Test = ExtractTestingSamples(s011, N);
                    s012_Test = ExtractTestingSamples(s012, N);
                    s013_Test = ExtractTestingSamples(s013, N);
                    s015_Test = ExtractTestingSamples(s015, N);
                    s016_Test = ExtractTestingSamples(s016, N);
                    s017_Test = ExtractTestingSamples(s017, N);
                    s018_Test = ExtractTestingSamples(s018, N);
                    s019_Test = ExtractTestingSamples(s019, N);
                    s020_Test = ExtractTestingSamples(s020, N);
                    s021_Test = ExtractTestingSamples(s021, N);
                    s022_Test = ExtractTestingSamples(s022, N);
                    s024_Test = ExtractTestingSamples(s024, N);
                    s025_Test = ExtractTestingSamples(s025, N);
                    s026_Test = ExtractTestingSamples(s026, N);
                    s027_Test = ExtractTestingSamples(s027, N);
                    s029_Test = ExtractTestingSamples(s029, N);
                    s030_Test = ExtractTestingSamples(s030, N);
                    s031_Test = ExtractTestingSamples(s031, N);
                    s032_Test = ExtractTestingSamples(s032, N);
                    s033_Test = ExtractTestingSamples(s033, N);
                    s034_Test = ExtractTestingSamples(s034, N);
                    s035_Test = ExtractTestingSamples(s035, N);
                    s036_Test = ExtractTestingSamples(s036, N);
                    s037_Test = ExtractTestingSamples(s037, N);
                    s038_Test = ExtractTestingSamples(s038, N);
                    s039_Test = ExtractTestingSamples(s039, N);
                    s040_Test = ExtractTestingSamples(s040, N);
                    s041_Test = ExtractTestingSamples(s041, N);
                    s042_Test = ExtractTestingSamples(s042, N);
                    s043_Test = ExtractTestingSamples(s043, N);
                    s044_Test = ExtractTestingSamples(s044, N);
                    s046_Test = ExtractTestingSamples(s046, N);
                    s047_Test = ExtractTestingSamples(s047, N);
                    s048_Test = ExtractTestingSamples(s048, N);
                    s049_Test = ExtractTestingSamples(s049, N);
                    s050_Test = ExtractTestingSamples(s050, N);
                    s051_Test = ExtractTestingSamples(s051, N);
                    s052_Test = ExtractTestingSamples(s052, N);
                    s053_Test = ExtractTestingSamples(s053, N);
                    s054_Test = ExtractTestingSamples(s054, N);
                    s055_Test = ExtractTestingSamples(s055, N);
                    s056_Test = ExtractTestingSamples(s056, N);
                    s057_Test = ExtractTestingSamples(s057, N);
                    #endregion

                    CalculateImpostorScores(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mu_s028);

                    FalseRejectRate(s028_Genuine, N);
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
                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s029_Samples = ExtractTrainingSamples(s029, N);

                    mu_s029 = CalculateTemplateVectors(s029_Samples, N);

                    s029_Test = ExtractTestingSamples(s029, N);

                    s029_Genuine = CalculateGenuineScores(s029_Test, mu_s029, N);

                    #region Extracting all the samples for the impostor calculations
                    s002_Test = ExtractTestingSamples(s002, N);
                    s003_Test = ExtractTestingSamples(s003, N);
                    s004_Test = ExtractTestingSamples(s004, N);
                    s005_Test = ExtractTestingSamples(s005, N);
                    s007_Test = ExtractTestingSamples(s007, N);
                    s008_Test = ExtractTestingSamples(s008, N);
                    s010_Test = ExtractTestingSamples(s010, N);
                    s011_Test = ExtractTestingSamples(s011, N);
                    s012_Test = ExtractTestingSamples(s012, N);
                    s013_Test = ExtractTestingSamples(s013, N);
                    s015_Test = ExtractTestingSamples(s015, N);
                    s016_Test = ExtractTestingSamples(s016, N);
                    s017_Test = ExtractTestingSamples(s017, N);
                    s018_Test = ExtractTestingSamples(s018, N);
                    s019_Test = ExtractTestingSamples(s019, N);
                    s020_Test = ExtractTestingSamples(s020, N);
                    s021_Test = ExtractTestingSamples(s021, N);
                    s022_Test = ExtractTestingSamples(s022, N);
                    s024_Test = ExtractTestingSamples(s024, N);
                    s025_Test = ExtractTestingSamples(s025, N);
                    s026_Test = ExtractTestingSamples(s026, N);
                    s027_Test = ExtractTestingSamples(s027, N);
                    s028_Test = ExtractTestingSamples(s028, N);
                    s030_Test = ExtractTestingSamples(s030, N);
                    s031_Test = ExtractTestingSamples(s031, N);
                    s032_Test = ExtractTestingSamples(s032, N);
                    s033_Test = ExtractTestingSamples(s033, N);
                    s034_Test = ExtractTestingSamples(s034, N);
                    s035_Test = ExtractTestingSamples(s035, N);
                    s036_Test = ExtractTestingSamples(s036, N);
                    s037_Test = ExtractTestingSamples(s037, N);
                    s038_Test = ExtractTestingSamples(s038, N);
                    s039_Test = ExtractTestingSamples(s039, N);
                    s040_Test = ExtractTestingSamples(s040, N);
                    s041_Test = ExtractTestingSamples(s041, N);
                    s042_Test = ExtractTestingSamples(s042, N);
                    s043_Test = ExtractTestingSamples(s043, N);
                    s044_Test = ExtractTestingSamples(s044, N);
                    s046_Test = ExtractTestingSamples(s046, N);
                    s047_Test = ExtractTestingSamples(s047, N);
                    s048_Test = ExtractTestingSamples(s048, N);
                    s049_Test = ExtractTestingSamples(s049, N);
                    s050_Test = ExtractTestingSamples(s050, N);
                    s051_Test = ExtractTestingSamples(s051, N);
                    s052_Test = ExtractTestingSamples(s052, N);
                    s053_Test = ExtractTestingSamples(s053, N);
                    s054_Test = ExtractTestingSamples(s054, N);
                    s055_Test = ExtractTestingSamples(s055, N);
                    s056_Test = ExtractTestingSamples(s056, N);
                    s057_Test = ExtractTestingSamples(s057, N);
                    #endregion

                    CalculateImpostorScores(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mu_s029);

                    FalseRejectRate(s029_Genuine, N);
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
                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s030_Samples = ExtractTrainingSamples(s030, N);

                    mu_s030 = CalculateTemplateVectors(s030_Samples, N);

                    s030_Test = ExtractTestingSamples(s030, N);

                    s030_Genuine = CalculateGenuineScores(s030_Test, mu_s030, N);

                    #region Extracting all the samples for the impostor calculations
                    s002_Test = ExtractTestingSamples(s002, N);
                    s003_Test = ExtractTestingSamples(s003, N);
                    s004_Test = ExtractTestingSamples(s004, N);
                    s005_Test = ExtractTestingSamples(s005, N);
                    s007_Test = ExtractTestingSamples(s007, N);
                    s008_Test = ExtractTestingSamples(s008, N);
                    s010_Test = ExtractTestingSamples(s010, N);
                    s011_Test = ExtractTestingSamples(s011, N);
                    s012_Test = ExtractTestingSamples(s012, N);
                    s013_Test = ExtractTestingSamples(s013, N);
                    s015_Test = ExtractTestingSamples(s015, N);
                    s016_Test = ExtractTestingSamples(s016, N);
                    s017_Test = ExtractTestingSamples(s017, N);
                    s018_Test = ExtractTestingSamples(s018, N);
                    s019_Test = ExtractTestingSamples(s019, N);
                    s020_Test = ExtractTestingSamples(s020, N);
                    s021_Test = ExtractTestingSamples(s021, N);
                    s022_Test = ExtractTestingSamples(s022, N);
                    s024_Test = ExtractTestingSamples(s024, N);
                    s025_Test = ExtractTestingSamples(s025, N);
                    s026_Test = ExtractTestingSamples(s026, N);
                    s027_Test = ExtractTestingSamples(s027, N);
                    s028_Test = ExtractTestingSamples(s028, N);
                    s029_Test = ExtractTestingSamples(s029, N);
                    s031_Test = ExtractTestingSamples(s031, N);
                    s032_Test = ExtractTestingSamples(s032, N);
                    s033_Test = ExtractTestingSamples(s033, N);
                    s034_Test = ExtractTestingSamples(s034, N);
                    s035_Test = ExtractTestingSamples(s035, N);
                    s036_Test = ExtractTestingSamples(s036, N);
                    s037_Test = ExtractTestingSamples(s037, N);
                    s038_Test = ExtractTestingSamples(s038, N);
                    s039_Test = ExtractTestingSamples(s039, N);
                    s040_Test = ExtractTestingSamples(s040, N);
                    s041_Test = ExtractTestingSamples(s041, N);
                    s042_Test = ExtractTestingSamples(s042, N);
                    s043_Test = ExtractTestingSamples(s043, N);
                    s044_Test = ExtractTestingSamples(s044, N);
                    s046_Test = ExtractTestingSamples(s046, N);
                    s047_Test = ExtractTestingSamples(s047, N);
                    s048_Test = ExtractTestingSamples(s048, N);
                    s049_Test = ExtractTestingSamples(s049, N);
                    s050_Test = ExtractTestingSamples(s050, N);
                    s051_Test = ExtractTestingSamples(s051, N);
                    s052_Test = ExtractTestingSamples(s052, N);
                    s053_Test = ExtractTestingSamples(s053, N);
                    s054_Test = ExtractTestingSamples(s054, N);
                    s055_Test = ExtractTestingSamples(s055, N);
                    s056_Test = ExtractTestingSamples(s056, N);
                    s057_Test = ExtractTestingSamples(s057, N);
                    #endregion

                    CalculateImpostorScores(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mu_s030);

                    FalseRejectRate(s030_Genuine, N);
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
                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s031_Samples = ExtractTrainingSamples(s031, N);

                    mu_s031 = CalculateTemplateVectors(s031_Samples, N);

                    s031_Test = ExtractTestingSamples(s031, N);

                    s031_Genuine = CalculateGenuineScores(s031_Test, mu_s031, N);

                    #region Extracting all the samples for the impostor calculations
                    s002_Test = ExtractTestingSamples(s002, N);
                    s003_Test = ExtractTestingSamples(s003, N);
                    s004_Test = ExtractTestingSamples(s004, N);
                    s005_Test = ExtractTestingSamples(s005, N);
                    s007_Test = ExtractTestingSamples(s007, N);
                    s008_Test = ExtractTestingSamples(s008, N);
                    s010_Test = ExtractTestingSamples(s010, N);
                    s011_Test = ExtractTestingSamples(s011, N);
                    s012_Test = ExtractTestingSamples(s012, N);
                    s013_Test = ExtractTestingSamples(s013, N);
                    s015_Test = ExtractTestingSamples(s015, N);
                    s016_Test = ExtractTestingSamples(s016, N);
                    s017_Test = ExtractTestingSamples(s017, N);
                    s018_Test = ExtractTestingSamples(s018, N);
                    s019_Test = ExtractTestingSamples(s019, N);
                    s020_Test = ExtractTestingSamples(s020, N);
                    s021_Test = ExtractTestingSamples(s021, N);
                    s022_Test = ExtractTestingSamples(s022, N);
                    s024_Test = ExtractTestingSamples(s024, N);
                    s025_Test = ExtractTestingSamples(s025, N);
                    s026_Test = ExtractTestingSamples(s026, N);
                    s027_Test = ExtractTestingSamples(s027, N);
                    s028_Test = ExtractTestingSamples(s028, N);
                    s029_Test = ExtractTestingSamples(s029, N);
                    s030_Test = ExtractTestingSamples(s030, N);
                    s032_Test = ExtractTestingSamples(s032, N);
                    s033_Test = ExtractTestingSamples(s033, N);
                    s034_Test = ExtractTestingSamples(s034, N);
                    s035_Test = ExtractTestingSamples(s035, N);
                    s036_Test = ExtractTestingSamples(s036, N);
                    s037_Test = ExtractTestingSamples(s037, N);
                    s038_Test = ExtractTestingSamples(s038, N);
                    s039_Test = ExtractTestingSamples(s039, N);
                    s040_Test = ExtractTestingSamples(s040, N);
                    s041_Test = ExtractTestingSamples(s041, N);
                    s042_Test = ExtractTestingSamples(s042, N);
                    s043_Test = ExtractTestingSamples(s043, N);
                    s044_Test = ExtractTestingSamples(s044, N);
                    s046_Test = ExtractTestingSamples(s046, N);
                    s047_Test = ExtractTestingSamples(s047, N);
                    s048_Test = ExtractTestingSamples(s048, N);
                    s049_Test = ExtractTestingSamples(s049, N);
                    s050_Test = ExtractTestingSamples(s050, N);
                    s051_Test = ExtractTestingSamples(s051, N);
                    s052_Test = ExtractTestingSamples(s052, N);
                    s053_Test = ExtractTestingSamples(s053, N);
                    s054_Test = ExtractTestingSamples(s054, N);
                    s055_Test = ExtractTestingSamples(s055, N);
                    s056_Test = ExtractTestingSamples(s056, N);
                    s057_Test = ExtractTestingSamples(s057, N);
                    #endregion

                    CalculateImpostorScores(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s027_Test, s026_Test, s028_Test, s029_Test, s030_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mu_s031);

                    FalseRejectRate(s031_Genuine, N);
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
                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s032_Samples = ExtractTrainingSamples(s032, N);

                    mu_s032 = CalculateTemplateVectors(s032_Samples, N);

                    s032_Test = ExtractTestingSamples(s032, N);

                    s032_Genuine = CalculateGenuineScores(s032_Test, mu_s032, N);

                    #region Extracting all the samples for the impostor calculations
                    s002_Test = ExtractTestingSamples(s002, N);
                    s003_Test = ExtractTestingSamples(s003, N);
                    s004_Test = ExtractTestingSamples(s004, N);
                    s005_Test = ExtractTestingSamples(s005, N);
                    s007_Test = ExtractTestingSamples(s007, N);
                    s008_Test = ExtractTestingSamples(s008, N);
                    s010_Test = ExtractTestingSamples(s010, N);
                    s011_Test = ExtractTestingSamples(s011, N);
                    s012_Test = ExtractTestingSamples(s012, N);
                    s013_Test = ExtractTestingSamples(s013, N);
                    s015_Test = ExtractTestingSamples(s015, N);
                    s016_Test = ExtractTestingSamples(s016, N);
                    s017_Test = ExtractTestingSamples(s017, N);
                    s018_Test = ExtractTestingSamples(s018, N);
                    s019_Test = ExtractTestingSamples(s019, N);
                    s020_Test = ExtractTestingSamples(s020, N);
                    s021_Test = ExtractTestingSamples(s021, N);
                    s022_Test = ExtractTestingSamples(s022, N);
                    s024_Test = ExtractTestingSamples(s024, N);
                    s025_Test = ExtractTestingSamples(s025, N);
                    s026_Test = ExtractTestingSamples(s026, N);
                    s027_Test = ExtractTestingSamples(s027, N);
                    s028_Test = ExtractTestingSamples(s028, N);
                    s029_Test = ExtractTestingSamples(s029, N);
                    s030_Test = ExtractTestingSamples(s030, N);
                    s031_Test = ExtractTestingSamples(s031, N);
                    s033_Test = ExtractTestingSamples(s033, N);
                    s034_Test = ExtractTestingSamples(s034, N);
                    s035_Test = ExtractTestingSamples(s035, N);
                    s036_Test = ExtractTestingSamples(s036, N);
                    s037_Test = ExtractTestingSamples(s037, N);
                    s038_Test = ExtractTestingSamples(s038, N);
                    s039_Test = ExtractTestingSamples(s039, N);
                    s040_Test = ExtractTestingSamples(s040, N);
                    s041_Test = ExtractTestingSamples(s041, N);
                    s042_Test = ExtractTestingSamples(s042, N);
                    s043_Test = ExtractTestingSamples(s043, N);
                    s044_Test = ExtractTestingSamples(s044, N);
                    s046_Test = ExtractTestingSamples(s046, N);
                    s047_Test = ExtractTestingSamples(s047, N);
                    s048_Test = ExtractTestingSamples(s048, N);
                    s049_Test = ExtractTestingSamples(s049, N);
                    s050_Test = ExtractTestingSamples(s050, N);
                    s051_Test = ExtractTestingSamples(s051, N);
                    s052_Test = ExtractTestingSamples(s052, N);
                    s053_Test = ExtractTestingSamples(s053, N);
                    s054_Test = ExtractTestingSamples(s054, N);
                    s055_Test = ExtractTestingSamples(s055, N);
                    s056_Test = ExtractTestingSamples(s056, N);
                    s057_Test = ExtractTestingSamples(s057, N);
                    #endregion

                    CalculateImpostorScores(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mu_s032);

                    FalseRejectRate(s032_Genuine, N);
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
                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s033_Samples = ExtractTrainingSamples(s033, N);

                    mu_s033 = CalculateTemplateVectors(s033_Samples, N);

                    s033_Test = ExtractTestingSamples(s033, N);

                    s033_Genuine = CalculateGenuineScores(s033_Test, mu_s033, N);

                    #region Extracting all the samples for the impostor calculations
                    s002_Test = ExtractTestingSamples(s002, N);
                    s003_Test = ExtractTestingSamples(s003, N);
                    s004_Test = ExtractTestingSamples(s004, N);
                    s005_Test = ExtractTestingSamples(s005, N);
                    s007_Test = ExtractTestingSamples(s007, N);
                    s008_Test = ExtractTestingSamples(s008, N);
                    s010_Test = ExtractTestingSamples(s010, N);
                    s011_Test = ExtractTestingSamples(s011, N);
                    s012_Test = ExtractTestingSamples(s012, N);
                    s013_Test = ExtractTestingSamples(s013, N);
                    s015_Test = ExtractTestingSamples(s015, N);
                    s016_Test = ExtractTestingSamples(s016, N);
                    s017_Test = ExtractTestingSamples(s017, N);
                    s018_Test = ExtractTestingSamples(s018, N);
                    s019_Test = ExtractTestingSamples(s019, N);
                    s020_Test = ExtractTestingSamples(s020, N);
                    s021_Test = ExtractTestingSamples(s021, N);
                    s022_Test = ExtractTestingSamples(s022, N);
                    s024_Test = ExtractTestingSamples(s024, N);
                    s025_Test = ExtractTestingSamples(s025, N);
                    s026_Test = ExtractTestingSamples(s026, N);
                    s027_Test = ExtractTestingSamples(s027, N);
                    s028_Test = ExtractTestingSamples(s028, N);
                    s029_Test = ExtractTestingSamples(s029, N);
                    s030_Test = ExtractTestingSamples(s030, N);
                    s031_Test = ExtractTestingSamples(s031, N);
                    s032_Test = ExtractTestingSamples(s032, N);
                    s033_Test = ExtractTestingSamples(s033, N);
                    s034_Test = ExtractTestingSamples(s034, N);
                    s035_Test = ExtractTestingSamples(s035, N);
                    s036_Test = ExtractTestingSamples(s036, N);
                    s037_Test = ExtractTestingSamples(s037, N);
                    s038_Test = ExtractTestingSamples(s038, N);
                    s039_Test = ExtractTestingSamples(s039, N);
                    s040_Test = ExtractTestingSamples(s040, N);
                    s041_Test = ExtractTestingSamples(s041, N);
                    s042_Test = ExtractTestingSamples(s042, N);
                    s043_Test = ExtractTestingSamples(s043, N);
                    s044_Test = ExtractTestingSamples(s044, N);
                    s046_Test = ExtractTestingSamples(s046, N);
                    s047_Test = ExtractTestingSamples(s047, N);
                    s048_Test = ExtractTestingSamples(s048, N);
                    s049_Test = ExtractTestingSamples(s049, N);
                    s050_Test = ExtractTestingSamples(s050, N);
                    s051_Test = ExtractTestingSamples(s051, N);
                    s052_Test = ExtractTestingSamples(s052, N);
                    s053_Test = ExtractTestingSamples(s053, N);
                    s054_Test = ExtractTestingSamples(s054, N);
                    s055_Test = ExtractTestingSamples(s055, N);
                    s056_Test = ExtractTestingSamples(s056, N);
                    s057_Test = ExtractTestingSamples(s057, N);
                    #endregion

                    CalculateImpostorScores(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mu_s033);

                    FalseRejectRate(s033_Genuine, N);
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
                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s034_Samples = ExtractTrainingSamples(s034, N);

                    mu_s034 = CalculateTemplateVectors(s034_Samples, N);

                    s034_Test = ExtractTestingSamples(s034, N);

                    s034_Genuine = CalculateGenuineScores(s034_Test, mu_s034, N);

                    #region Extracting all the samples for the impostor calculations
                    s002_Test = ExtractTestingSamples(s002, N);
                    s003_Test = ExtractTestingSamples(s003, N);
                    s004_Test = ExtractTestingSamples(s004, N);
                    s005_Test = ExtractTestingSamples(s005, N);
                    s007_Test = ExtractTestingSamples(s007, N);
                    s008_Test = ExtractTestingSamples(s008, N);
                    s010_Test = ExtractTestingSamples(s010, N);
                    s011_Test = ExtractTestingSamples(s011, N);
                    s012_Test = ExtractTestingSamples(s012, N);
                    s013_Test = ExtractTestingSamples(s013, N);
                    s015_Test = ExtractTestingSamples(s015, N);
                    s016_Test = ExtractTestingSamples(s016, N);
                    s017_Test = ExtractTestingSamples(s017, N);
                    s018_Test = ExtractTestingSamples(s018, N);
                    s019_Test = ExtractTestingSamples(s019, N);
                    s020_Test = ExtractTestingSamples(s020, N);
                    s021_Test = ExtractTestingSamples(s021, N);
                    s022_Test = ExtractTestingSamples(s022, N);
                    s024_Test = ExtractTestingSamples(s024, N);
                    s025_Test = ExtractTestingSamples(s025, N);
                    s026_Test = ExtractTestingSamples(s026, N);
                    s027_Test = ExtractTestingSamples(s027, N);
                    s028_Test = ExtractTestingSamples(s028, N);
                    s029_Test = ExtractTestingSamples(s029, N);
                    s030_Test = ExtractTestingSamples(s030, N);
                    s031_Test = ExtractTestingSamples(s031, N);
                    s032_Test = ExtractTestingSamples(s032, N);
                    s033_Test = ExtractTestingSamples(s033, N);
                    s035_Test = ExtractTestingSamples(s035, N);
                    s036_Test = ExtractTestingSamples(s036, N);
                    s037_Test = ExtractTestingSamples(s037, N);
                    s038_Test = ExtractTestingSamples(s038, N);
                    s039_Test = ExtractTestingSamples(s039, N);
                    s040_Test = ExtractTestingSamples(s040, N);
                    s041_Test = ExtractTestingSamples(s041, N);
                    s042_Test = ExtractTestingSamples(s042, N);
                    s043_Test = ExtractTestingSamples(s043, N);
                    s044_Test = ExtractTestingSamples(s044, N);
                    s046_Test = ExtractTestingSamples(s046, N);
                    s047_Test = ExtractTestingSamples(s047, N);
                    s048_Test = ExtractTestingSamples(s048, N);
                    s049_Test = ExtractTestingSamples(s049, N);
                    s050_Test = ExtractTestingSamples(s050, N);
                    s051_Test = ExtractTestingSamples(s051, N);
                    s052_Test = ExtractTestingSamples(s052, N);
                    s053_Test = ExtractTestingSamples(s053, N);
                    s054_Test = ExtractTestingSamples(s054, N);
                    s055_Test = ExtractTestingSamples(s055, N);
                    s056_Test = ExtractTestingSamples(s056, N);
                    s057_Test = ExtractTestingSamples(s057, N);
                    #endregion

                    CalculateImpostorScores(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mu_s034);

                    FalseRejectRate(s034_Genuine, N);
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
                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s035_Samples = ExtractTrainingSamples(s035, N);

                    mu_s035 = CalculateTemplateVectors(s035_Samples, N);

                    s035_Test = ExtractTestingSamples(s035, N);

                    s035_Genuine = CalculateGenuineScores(s035_Test, mu_s035, N);

                    #region Extracting all the samples for the impostor calculations
                    s002_Test = ExtractTestingSamples(s002, N);
                    s003_Test = ExtractTestingSamples(s003, N);
                    s004_Test = ExtractTestingSamples(s004, N);
                    s005_Test = ExtractTestingSamples(s005, N);
                    s007_Test = ExtractTestingSamples(s007, N);
                    s008_Test = ExtractTestingSamples(s008, N);
                    s010_Test = ExtractTestingSamples(s010, N);
                    s011_Test = ExtractTestingSamples(s011, N);
                    s012_Test = ExtractTestingSamples(s012, N);
                    s013_Test = ExtractTestingSamples(s013, N);
                    s015_Test = ExtractTestingSamples(s015, N);
                    s016_Test = ExtractTestingSamples(s016, N);
                    s017_Test = ExtractTestingSamples(s017, N);
                    s018_Test = ExtractTestingSamples(s018, N);
                    s019_Test = ExtractTestingSamples(s019, N);
                    s020_Test = ExtractTestingSamples(s020, N);
                    s021_Test = ExtractTestingSamples(s021, N);
                    s022_Test = ExtractTestingSamples(s022, N);
                    s024_Test = ExtractTestingSamples(s024, N);
                    s025_Test = ExtractTestingSamples(s025, N);
                    s026_Test = ExtractTestingSamples(s026, N);
                    s027_Test = ExtractTestingSamples(s027, N);
                    s028_Test = ExtractTestingSamples(s028, N);
                    s029_Test = ExtractTestingSamples(s029, N);
                    s030_Test = ExtractTestingSamples(s030, N);
                    s031_Test = ExtractTestingSamples(s031, N);
                    s032_Test = ExtractTestingSamples(s032, N);
                    s033_Test = ExtractTestingSamples(s033, N);
                    s034_Test = ExtractTestingSamples(s034, N);
                    s036_Test = ExtractTestingSamples(s036, N);
                    s037_Test = ExtractTestingSamples(s037, N);
                    s038_Test = ExtractTestingSamples(s038, N);
                    s039_Test = ExtractTestingSamples(s039, N);
                    s040_Test = ExtractTestingSamples(s040, N);
                    s041_Test = ExtractTestingSamples(s041, N);
                    s042_Test = ExtractTestingSamples(s042, N);
                    s043_Test = ExtractTestingSamples(s043, N);
                    s044_Test = ExtractTestingSamples(s044, N);
                    s046_Test = ExtractTestingSamples(s046, N);
                    s047_Test = ExtractTestingSamples(s047, N);
                    s048_Test = ExtractTestingSamples(s048, N);
                    s049_Test = ExtractTestingSamples(s049, N);
                    s050_Test = ExtractTestingSamples(s050, N);
                    s051_Test = ExtractTestingSamples(s051, N);
                    s052_Test = ExtractTestingSamples(s052, N);
                    s053_Test = ExtractTestingSamples(s053, N);
                    s054_Test = ExtractTestingSamples(s054, N);
                    s055_Test = ExtractTestingSamples(s055, N);
                    s056_Test = ExtractTestingSamples(s056, N);
                    s057_Test = ExtractTestingSamples(s057, N);
                    #endregion

                    CalculateImpostorScores(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mu_s035);

                    FalseRejectRate(s035_Genuine, N);
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
                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s036_Samples = ExtractTrainingSamples(s036, N);

                    mu_s036 = CalculateTemplateVectors(s036_Samples, N);

                    s036_Test = ExtractTestingSamples(s036, N);

                    s036_Genuine = CalculateGenuineScores(s036_Test, mu_s036, N);

                    #region Extracting all the samples for the impostor calculations
                    s002_Test = ExtractTestingSamples(s002, N);
                    s003_Test = ExtractTestingSamples(s003, N);
                    s004_Test = ExtractTestingSamples(s004, N);
                    s005_Test = ExtractTestingSamples(s005, N);
                    s007_Test = ExtractTestingSamples(s007, N);
                    s008_Test = ExtractTestingSamples(s008, N);
                    s010_Test = ExtractTestingSamples(s010, N);
                    s011_Test = ExtractTestingSamples(s011, N);
                    s012_Test = ExtractTestingSamples(s012, N);
                    s013_Test = ExtractTestingSamples(s013, N);
                    s015_Test = ExtractTestingSamples(s015, N);
                    s016_Test = ExtractTestingSamples(s016, N);
                    s017_Test = ExtractTestingSamples(s017, N);
                    s018_Test = ExtractTestingSamples(s018, N);
                    s019_Test = ExtractTestingSamples(s019, N);
                    s020_Test = ExtractTestingSamples(s020, N);
                    s021_Test = ExtractTestingSamples(s021, N);
                    s022_Test = ExtractTestingSamples(s022, N);
                    s024_Test = ExtractTestingSamples(s024, N);
                    s025_Test = ExtractTestingSamples(s025, N);
                    s026_Test = ExtractTestingSamples(s026, N);
                    s027_Test = ExtractTestingSamples(s027, N);
                    s028_Test = ExtractTestingSamples(s028, N);
                    s029_Test = ExtractTestingSamples(s029, N);
                    s030_Test = ExtractTestingSamples(s030, N);
                    s031_Test = ExtractTestingSamples(s031, N);
                    s032_Test = ExtractTestingSamples(s032, N);
                    s033_Test = ExtractTestingSamples(s033, N);
                    s034_Test = ExtractTestingSamples(s034, N);
                    s035_Test = ExtractTestingSamples(s035, N);
                    s037_Test = ExtractTestingSamples(s037, N);
                    s038_Test = ExtractTestingSamples(s038, N);
                    s039_Test = ExtractTestingSamples(s039, N);
                    s040_Test = ExtractTestingSamples(s040, N);
                    s041_Test = ExtractTestingSamples(s041, N);
                    s042_Test = ExtractTestingSamples(s042, N);
                    s043_Test = ExtractTestingSamples(s043, N);
                    s044_Test = ExtractTestingSamples(s044, N);
                    s046_Test = ExtractTestingSamples(s046, N);
                    s047_Test = ExtractTestingSamples(s047, N);
                    s048_Test = ExtractTestingSamples(s048, N);
                    s049_Test = ExtractTestingSamples(s049, N);
                    s050_Test = ExtractTestingSamples(s050, N);
                    s051_Test = ExtractTestingSamples(s051, N);
                    s052_Test = ExtractTestingSamples(s052, N);
                    s053_Test = ExtractTestingSamples(s053, N);
                    s054_Test = ExtractTestingSamples(s054, N);
                    s055_Test = ExtractTestingSamples(s055, N);
                    s056_Test = ExtractTestingSamples(s056, N);
                    s057_Test = ExtractTestingSamples(s057, N);
                    #endregion

                    CalculateImpostorScores(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mu_s036);

                    FalseRejectRate(s036_Genuine, N); 
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
                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s037_Samples = ExtractTrainingSamples(s037, N);

                    mu_s037 = CalculateTemplateVectors(s037_Samples, N);

                    s037_Test = ExtractTestingSamples(s037, N);

                    s037_Genuine = CalculateGenuineScores(s037_Test, mu_s037, N);

                    #region Extracting all the samples for the impostor calculations
                    s002_Test = ExtractTestingSamples(s002, N);
                    s003_Test = ExtractTestingSamples(s003, N);
                    s004_Test = ExtractTestingSamples(s004, N);
                    s005_Test = ExtractTestingSamples(s005, N);
                    s007_Test = ExtractTestingSamples(s007, N);
                    s008_Test = ExtractTestingSamples(s008, N);
                    s010_Test = ExtractTestingSamples(s010, N);
                    s011_Test = ExtractTestingSamples(s011, N);
                    s012_Test = ExtractTestingSamples(s012, N);
                    s013_Test = ExtractTestingSamples(s013, N);
                    s015_Test = ExtractTestingSamples(s015, N);
                    s016_Test = ExtractTestingSamples(s016, N);
                    s017_Test = ExtractTestingSamples(s017, N);
                    s018_Test = ExtractTestingSamples(s018, N);
                    s019_Test = ExtractTestingSamples(s019, N);
                    s020_Test = ExtractTestingSamples(s020, N);
                    s021_Test = ExtractTestingSamples(s021, N);
                    s022_Test = ExtractTestingSamples(s022, N);
                    s024_Test = ExtractTestingSamples(s024, N);
                    s025_Test = ExtractTestingSamples(s025, N);
                    s026_Test = ExtractTestingSamples(s026, N);
                    s027_Test = ExtractTestingSamples(s027, N);
                    s028_Test = ExtractTestingSamples(s028, N);
                    s029_Test = ExtractTestingSamples(s029, N);
                    s030_Test = ExtractTestingSamples(s030, N);
                    s031_Test = ExtractTestingSamples(s031, N);
                    s032_Test = ExtractTestingSamples(s032, N);
                    s033_Test = ExtractTestingSamples(s033, N);
                    s034_Test = ExtractTestingSamples(s034, N);
                    s035_Test = ExtractTestingSamples(s035, N);
                    s036_Test = ExtractTestingSamples(s036, N);
                    s038_Test = ExtractTestingSamples(s038, N);
                    s039_Test = ExtractTestingSamples(s039, N);
                    s040_Test = ExtractTestingSamples(s040, N);
                    s041_Test = ExtractTestingSamples(s041, N);
                    s042_Test = ExtractTestingSamples(s042, N);
                    s043_Test = ExtractTestingSamples(s043, N);
                    s044_Test = ExtractTestingSamples(s044, N);
                    s046_Test = ExtractTestingSamples(s046, N);
                    s047_Test = ExtractTestingSamples(s047, N);
                    s048_Test = ExtractTestingSamples(s048, N);
                    s049_Test = ExtractTestingSamples(s049, N);
                    s050_Test = ExtractTestingSamples(s050, N);
                    s051_Test = ExtractTestingSamples(s051, N);
                    s052_Test = ExtractTestingSamples(s052, N);
                    s053_Test = ExtractTestingSamples(s053, N);
                    s054_Test = ExtractTestingSamples(s054, N);
                    s055_Test = ExtractTestingSamples(s055, N);
                    s056_Test = ExtractTestingSamples(s056, N);
                    s057_Test = ExtractTestingSamples(s057, N);
                    #endregion

                    CalculateImpostorScores(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mu_s037);

                    FalseRejectRate(s037_Genuine, N); 
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
                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s038_Samples = ExtractTrainingSamples(s038, N);

                    mu_s038 = CalculateTemplateVectors(s038_Samples, N);

                    s038_Test = ExtractTestingSamples(s038, N);

                    s038_Genuine = CalculateGenuineScores(s039_Test, mu_s038, N);

                    #region Extracting all the samples for the impostor calculations
                    s002_Test = ExtractTestingSamples(s002, N);
                    s003_Test = ExtractTestingSamples(s003, N);
                    s004_Test = ExtractTestingSamples(s004, N);
                    s005_Test = ExtractTestingSamples(s005, N);
                    s007_Test = ExtractTestingSamples(s007, N);
                    s008_Test = ExtractTestingSamples(s008, N);
                    s010_Test = ExtractTestingSamples(s010, N);
                    s011_Test = ExtractTestingSamples(s011, N);
                    s012_Test = ExtractTestingSamples(s012, N);
                    s013_Test = ExtractTestingSamples(s013, N);
                    s015_Test = ExtractTestingSamples(s015, N);
                    s016_Test = ExtractTestingSamples(s016, N);
                    s017_Test = ExtractTestingSamples(s017, N);
                    s018_Test = ExtractTestingSamples(s018, N);
                    s019_Test = ExtractTestingSamples(s019, N);
                    s020_Test = ExtractTestingSamples(s020, N);
                    s021_Test = ExtractTestingSamples(s021, N);
                    s022_Test = ExtractTestingSamples(s022, N);
                    s024_Test = ExtractTestingSamples(s024, N);
                    s025_Test = ExtractTestingSamples(s025, N);
                    s026_Test = ExtractTestingSamples(s026, N);
                    s027_Test = ExtractTestingSamples(s027, N);
                    s028_Test = ExtractTestingSamples(s028, N);
                    s029_Test = ExtractTestingSamples(s029, N);
                    s030_Test = ExtractTestingSamples(s030, N);
                    s031_Test = ExtractTestingSamples(s031, N);
                    s032_Test = ExtractTestingSamples(s032, N);
                    s033_Test = ExtractTestingSamples(s033, N);
                    s034_Test = ExtractTestingSamples(s034, N);
                    s035_Test = ExtractTestingSamples(s035, N);
                    s036_Test = ExtractTestingSamples(s036, N);
                    s037_Test = ExtractTestingSamples(s037, N);
                    s039_Test = ExtractTestingSamples(s039, N);
                    s040_Test = ExtractTestingSamples(s040, N);
                    s041_Test = ExtractTestingSamples(s041, N);
                    s042_Test = ExtractTestingSamples(s042, N);
                    s043_Test = ExtractTestingSamples(s043, N);
                    s044_Test = ExtractTestingSamples(s044, N);
                    s046_Test = ExtractTestingSamples(s046, N);
                    s047_Test = ExtractTestingSamples(s047, N);
                    s048_Test = ExtractTestingSamples(s048, N);
                    s049_Test = ExtractTestingSamples(s049, N);
                    s050_Test = ExtractTestingSamples(s050, N);
                    s051_Test = ExtractTestingSamples(s051, N);
                    s052_Test = ExtractTestingSamples(s052, N);
                    s053_Test = ExtractTestingSamples(s053, N);
                    s054_Test = ExtractTestingSamples(s054, N);
                    s055_Test = ExtractTestingSamples(s055, N);
                    s056_Test = ExtractTestingSamples(s056, N);
                    s057_Test = ExtractTestingSamples(s057, N);
                    #endregion

                    CalculateImpostorScores(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mu_s038);

                    FalseRejectRate(s038_Genuine, N); 
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
                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s039_Samples = ExtractTrainingSamples(s039, N);

                    mu_s039 = CalculateTemplateVectors(s039_Samples, N);

                    s039_Test = ExtractTestingSamples(s039, N);

                    s039_Genuine = CalculateGenuineScores(s039_Test, mu_s039, N);

                    #region Extracting all the samples for the impostor calculations
                    s002_Test = ExtractTestingSamples(s002, N);
                    s003_Test = ExtractTestingSamples(s003, N);
                    s004_Test = ExtractTestingSamples(s004, N);
                    s005_Test = ExtractTestingSamples(s005, N);
                    s007_Test = ExtractTestingSamples(s007, N);
                    s008_Test = ExtractTestingSamples(s008, N);
                    s010_Test = ExtractTestingSamples(s010, N);
                    s011_Test = ExtractTestingSamples(s011, N);
                    s012_Test = ExtractTestingSamples(s012, N);
                    s013_Test = ExtractTestingSamples(s013, N);
                    s015_Test = ExtractTestingSamples(s015, N);
                    s016_Test = ExtractTestingSamples(s016, N);
                    s017_Test = ExtractTestingSamples(s017, N);
                    s018_Test = ExtractTestingSamples(s018, N);
                    s019_Test = ExtractTestingSamples(s019, N);
                    s020_Test = ExtractTestingSamples(s020, N);
                    s021_Test = ExtractTestingSamples(s021, N);
                    s022_Test = ExtractTestingSamples(s022, N);
                    s024_Test = ExtractTestingSamples(s024, N);
                    s025_Test = ExtractTestingSamples(s025, N);
                    s026_Test = ExtractTestingSamples(s026, N);
                    s027_Test = ExtractTestingSamples(s027, N);
                    s028_Test = ExtractTestingSamples(s028, N);
                    s029_Test = ExtractTestingSamples(s029, N);
                    s030_Test = ExtractTestingSamples(s030, N);
                    s031_Test = ExtractTestingSamples(s031, N);
                    s032_Test = ExtractTestingSamples(s032, N);
                    s033_Test = ExtractTestingSamples(s033, N);
                    s034_Test = ExtractTestingSamples(s034, N);
                    s035_Test = ExtractTestingSamples(s035, N);
                    s036_Test = ExtractTestingSamples(s036, N);
                    s037_Test = ExtractTestingSamples(s037, N);
                    s038_Test = ExtractTestingSamples(s038, N);
                    s040_Test = ExtractTestingSamples(s040, N);
                    s041_Test = ExtractTestingSamples(s041, N);
                    s042_Test = ExtractTestingSamples(s042, N);
                    s043_Test = ExtractTestingSamples(s043, N);
                    s044_Test = ExtractTestingSamples(s044, N);
                    s046_Test = ExtractTestingSamples(s046, N);
                    s047_Test = ExtractTestingSamples(s047, N);
                    s048_Test = ExtractTestingSamples(s048, N);
                    s049_Test = ExtractTestingSamples(s049, N);
                    s050_Test = ExtractTestingSamples(s050, N);
                    s051_Test = ExtractTestingSamples(s051, N);
                    s052_Test = ExtractTestingSamples(s052, N);
                    s053_Test = ExtractTestingSamples(s053, N);
                    s054_Test = ExtractTestingSamples(s054, N);
                    s055_Test = ExtractTestingSamples(s055, N);
                    s056_Test = ExtractTestingSamples(s056, N);
                    s057_Test = ExtractTestingSamples(s057, N);
                    #endregion

                    CalculateImpostorScores(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mu_s039);

                    FalseRejectRate(s039_Genuine, N); 
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
                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s040_Samples = ExtractTrainingSamples(s040, N);

                    mu_s040 = CalculateTemplateVectors(s040_Samples, N);

                    s040_Test = ExtractTestingSamples(s040, N);
                    s040_Genuine = CalculateGenuineScores(s040_Test, mu_s040, N);

                    #region Extracting all the samples for the impostor calculations
                    s002_Test = ExtractTestingSamples(s002, N);
                    s003_Test = ExtractTestingSamples(s003, N);
                    s004_Test = ExtractTestingSamples(s004, N);
                    s005_Test = ExtractTestingSamples(s005, N);
                    s007_Test = ExtractTestingSamples(s007, N);
                    s008_Test = ExtractTestingSamples(s008, N);
                    s010_Test = ExtractTestingSamples(s010, N);
                    s011_Test = ExtractTestingSamples(s011, N);
                    s012_Test = ExtractTestingSamples(s012, N);
                    s013_Test = ExtractTestingSamples(s013, N);
                    s015_Test = ExtractTestingSamples(s015, N);
                    s016_Test = ExtractTestingSamples(s016, N);
                    s017_Test = ExtractTestingSamples(s017, N);
                    s018_Test = ExtractTestingSamples(s018, N);
                    s019_Test = ExtractTestingSamples(s019, N);
                    s020_Test = ExtractTestingSamples(s020, N);
                    s021_Test = ExtractTestingSamples(s021, N);
                    s022_Test = ExtractTestingSamples(s022, N);
                    s024_Test = ExtractTestingSamples(s024, N);
                    s025_Test = ExtractTestingSamples(s025, N);
                    s026_Test = ExtractTestingSamples(s026, N);
                    s027_Test = ExtractTestingSamples(s027, N);
                    s028_Test = ExtractTestingSamples(s028, N);
                    s029_Test = ExtractTestingSamples(s029, N);
                    s030_Test = ExtractTestingSamples(s030, N);
                    s031_Test = ExtractTestingSamples(s031, N);
                    s032_Test = ExtractTestingSamples(s032, N);
                    s033_Test = ExtractTestingSamples(s033, N);
                    s034_Test = ExtractTestingSamples(s034, N);
                    s035_Test = ExtractTestingSamples(s035, N);
                    s036_Test = ExtractTestingSamples(s036, N);
                    s037_Test = ExtractTestingSamples(s037, N);
                    s038_Test = ExtractTestingSamples(s038, N);
                    s039_Test = ExtractTestingSamples(s039, N);
                    s041_Test = ExtractTestingSamples(s041, N);
                    s042_Test = ExtractTestingSamples(s042, N);
                    s043_Test = ExtractTestingSamples(s043, N);
                    s044_Test = ExtractTestingSamples(s044, N);
                    s046_Test = ExtractTestingSamples(s046, N);
                    s047_Test = ExtractTestingSamples(s047, N);
                    s048_Test = ExtractTestingSamples(s048, N);
                    s049_Test = ExtractTestingSamples(s049, N);
                    s050_Test = ExtractTestingSamples(s050, N);
                    s051_Test = ExtractTestingSamples(s051, N);
                    s052_Test = ExtractTestingSamples(s052, N);
                    s053_Test = ExtractTestingSamples(s053, N);
                    s054_Test = ExtractTestingSamples(s054, N);
                    s055_Test = ExtractTestingSamples(s055, N);
                    s056_Test = ExtractTestingSamples(s056, N);
                    s057_Test = ExtractTestingSamples(s057, N);
                    #endregion

                    CalculateImpostorScores(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mu_s040);

                    FalseRejectRate(s040_Genuine, N); 
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
                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s041_Samples = ExtractTrainingSamples(s041, N);

                    mu_s041 = CalculateTemplateVectors(s041_Samples, N);

                    s041_Test = ExtractTestingSamples(s041, N);

                    s041_Genuine = CalculateGenuineScores(s041_Test, mu_s041, N);

                    #region Extracting all the samples for the impostor calculations
                    s002_Test = ExtractTestingSamples(s002, N);
                    s003_Test = ExtractTestingSamples(s003, N);
                    s004_Test = ExtractTestingSamples(s004, N);
                    s005_Test = ExtractTestingSamples(s005, N);
                    s007_Test = ExtractTestingSamples(s007, N);
                    s008_Test = ExtractTestingSamples(s008, N);
                    s010_Test = ExtractTestingSamples(s010, N);
                    s011_Test = ExtractTestingSamples(s011, N);
                    s012_Test = ExtractTestingSamples(s012, N);
                    s013_Test = ExtractTestingSamples(s013, N);
                    s015_Test = ExtractTestingSamples(s015, N);
                    s016_Test = ExtractTestingSamples(s016, N);
                    s017_Test = ExtractTestingSamples(s017, N);
                    s018_Test = ExtractTestingSamples(s018, N);
                    s019_Test = ExtractTestingSamples(s019, N);
                    s020_Test = ExtractTestingSamples(s020, N);
                    s021_Test = ExtractTestingSamples(s021, N);
                    s022_Test = ExtractTestingSamples(s022, N);
                    s024_Test = ExtractTestingSamples(s024, N);
                    s025_Test = ExtractTestingSamples(s025, N);
                    s026_Test = ExtractTestingSamples(s026, N);
                    s027_Test = ExtractTestingSamples(s027, N);
                    s028_Test = ExtractTestingSamples(s028, N);
                    s029_Test = ExtractTestingSamples(s029, N);
                    s030_Test = ExtractTestingSamples(s030, N);
                    s031_Test = ExtractTestingSamples(s031, N);
                    s032_Test = ExtractTestingSamples(s032, N);
                    s033_Test = ExtractTestingSamples(s033, N);
                    s034_Test = ExtractTestingSamples(s034, N);
                    s035_Test = ExtractTestingSamples(s035, N);
                    s036_Test = ExtractTestingSamples(s036, N);
                    s037_Test = ExtractTestingSamples(s037, N);
                    s038_Test = ExtractTestingSamples(s038, N);
                    s039_Test = ExtractTestingSamples(s039, N);
                    s040_Test = ExtractTestingSamples(s040, N);
                    s042_Test = ExtractTestingSamples(s042, N);
                    s043_Test = ExtractTestingSamples(s043, N);
                    s044_Test = ExtractTestingSamples(s044, N);
                    s046_Test = ExtractTestingSamples(s046, N);
                    s047_Test = ExtractTestingSamples(s047, N);
                    s048_Test = ExtractTestingSamples(s048, N);
                    s049_Test = ExtractTestingSamples(s049, N);
                    s050_Test = ExtractTestingSamples(s050, N);
                    s051_Test = ExtractTestingSamples(s051, N);
                    s052_Test = ExtractTestingSamples(s052, N);
                    s053_Test = ExtractTestingSamples(s053, N);
                    s054_Test = ExtractTestingSamples(s054, N);
                    s055_Test = ExtractTestingSamples(s055, N);
                    s056_Test = ExtractTestingSamples(s056, N);
                    s057_Test = ExtractTestingSamples(s057, N);
                    #endregion

                    CalculateImpostorScores(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mu_s041);

                    FalseRejectRate(s041_Genuine, N); 
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
                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s042_Samples = ExtractTrainingSamples(s042, N);

                    mu_s042 = CalculateTemplateVectors(s042_Samples, N);

                    s042_Test = ExtractTestingSamples(s042, N);

                    s042_Genuine = CalculateGenuineScores(s042_Test, mu_s042, N);

                    #region Extracting all the samples for the impostor calculations
                    s002_Test = ExtractTestingSamples(s002, N);
                    s003_Test = ExtractTestingSamples(s003, N);
                    s004_Test = ExtractTestingSamples(s004, N);
                    s005_Test = ExtractTestingSamples(s005, N);
                    s007_Test = ExtractTestingSamples(s007, N);
                    s008_Test = ExtractTestingSamples(s008, N);
                    s010_Test = ExtractTestingSamples(s010, N);
                    s011_Test = ExtractTestingSamples(s011, N);
                    s012_Test = ExtractTestingSamples(s012, N);
                    s013_Test = ExtractTestingSamples(s013, N);
                    s015_Test = ExtractTestingSamples(s015, N);
                    s016_Test = ExtractTestingSamples(s016, N);
                    s017_Test = ExtractTestingSamples(s017, N);
                    s018_Test = ExtractTestingSamples(s018, N);
                    s019_Test = ExtractTestingSamples(s019, N);
                    s020_Test = ExtractTestingSamples(s020, N);
                    s021_Test = ExtractTestingSamples(s021, N);
                    s022_Test = ExtractTestingSamples(s022, N);
                    s024_Test = ExtractTestingSamples(s024, N);
                    s025_Test = ExtractTestingSamples(s025, N);
                    s026_Test = ExtractTestingSamples(s026, N);
                    s027_Test = ExtractTestingSamples(s027, N);
                    s028_Test = ExtractTestingSamples(s028, N);
                    s029_Test = ExtractTestingSamples(s029, N);
                    s030_Test = ExtractTestingSamples(s030, N);
                    s031_Test = ExtractTestingSamples(s031, N);
                    s032_Test = ExtractTestingSamples(s032, N);
                    s033_Test = ExtractTestingSamples(s033, N);
                    s034_Test = ExtractTestingSamples(s034, N);
                    s035_Test = ExtractTestingSamples(s035, N);
                    s036_Test = ExtractTestingSamples(s036, N);
                    s037_Test = ExtractTestingSamples(s037, N);
                    s038_Test = ExtractTestingSamples(s038, N);
                    s039_Test = ExtractTestingSamples(s039, N);
                    s040_Test = ExtractTestingSamples(s040, N);
                    s041_Test = ExtractTestingSamples(s041, N);
                    s043_Test = ExtractTestingSamples(s043, N);
                    s044_Test = ExtractTestingSamples(s044, N);
                    s046_Test = ExtractTestingSamples(s046, N);
                    s047_Test = ExtractTestingSamples(s047, N);
                    s048_Test = ExtractTestingSamples(s048, N);
                    s049_Test = ExtractTestingSamples(s049, N);
                    s050_Test = ExtractTestingSamples(s050, N);
                    s051_Test = ExtractTestingSamples(s051, N);
                    s052_Test = ExtractTestingSamples(s052, N);
                    s053_Test = ExtractTestingSamples(s053, N);
                    s054_Test = ExtractTestingSamples(s054, N);
                    s055_Test = ExtractTestingSamples(s055, N);
                    s056_Test = ExtractTestingSamples(s056, N);
                    s057_Test = ExtractTestingSamples(s057, N);
                    #endregion

                    CalculateImpostorScores(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mu_s042);

                    FalseRejectRate(s042_Genuine, N); 
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
                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s043_Samples = ExtractTrainingSamples(s043, N);

                    mu_s043 = CalculateTemplateVectors(s043_Samples, N);

                    s043_Test = ExtractTestingSamples(s043, N);

                    s043_Genuine = CalculateGenuineScores(s043_Test, mu_s043, N);

                    #region Extracting all the samples for the impostor calculations
                    s002_Test = ExtractTestingSamples(s002, N);
                    s003_Test = ExtractTestingSamples(s003, N);
                    s004_Test = ExtractTestingSamples(s004, N);
                    s005_Test = ExtractTestingSamples(s005, N);
                    s007_Test = ExtractTestingSamples(s007, N);
                    s008_Test = ExtractTestingSamples(s008, N);
                    s010_Test = ExtractTestingSamples(s010, N);
                    s011_Test = ExtractTestingSamples(s011, N);
                    s012_Test = ExtractTestingSamples(s012, N);
                    s013_Test = ExtractTestingSamples(s013, N);
                    s015_Test = ExtractTestingSamples(s015, N);
                    s016_Test = ExtractTestingSamples(s016, N);
                    s017_Test = ExtractTestingSamples(s017, N);
                    s018_Test = ExtractTestingSamples(s018, N);
                    s019_Test = ExtractTestingSamples(s019, N);
                    s020_Test = ExtractTestingSamples(s020, N);
                    s021_Test = ExtractTestingSamples(s021, N);
                    s022_Test = ExtractTestingSamples(s022, N);
                    s024_Test = ExtractTestingSamples(s024, N);
                    s025_Test = ExtractTestingSamples(s025, N);
                    s026_Test = ExtractTestingSamples(s026, N);
                    s027_Test = ExtractTestingSamples(s027, N);
                    s028_Test = ExtractTestingSamples(s028, N);
                    s029_Test = ExtractTestingSamples(s029, N);
                    s030_Test = ExtractTestingSamples(s030, N);
                    s031_Test = ExtractTestingSamples(s031, N);
                    s032_Test = ExtractTestingSamples(s032, N);
                    s033_Test = ExtractTestingSamples(s033, N);
                    s034_Test = ExtractTestingSamples(s034, N);
                    s035_Test = ExtractTestingSamples(s035, N);
                    s036_Test = ExtractTestingSamples(s036, N);
                    s037_Test = ExtractTestingSamples(s037, N);
                    s038_Test = ExtractTestingSamples(s038, N);
                    s039_Test = ExtractTestingSamples(s039, N);
                    s040_Test = ExtractTestingSamples(s040, N);
                    s041_Test = ExtractTestingSamples(s041, N);
                    s042_Test = ExtractTestingSamples(s042, N);
                    s044_Test = ExtractTestingSamples(s044, N);
                    s046_Test = ExtractTestingSamples(s046, N);
                    s047_Test = ExtractTestingSamples(s047, N);
                    s048_Test = ExtractTestingSamples(s048, N);
                    s049_Test = ExtractTestingSamples(s049, N);
                    s050_Test = ExtractTestingSamples(s050, N);
                    s051_Test = ExtractTestingSamples(s051, N);
                    s052_Test = ExtractTestingSamples(s052, N);
                    s053_Test = ExtractTestingSamples(s053, N);
                    s054_Test = ExtractTestingSamples(s054, N);
                    s055_Test = ExtractTestingSamples(s055, N);
                    s056_Test = ExtractTestingSamples(s056, N);
                    s057_Test = ExtractTestingSamples(s057, N);
                    #endregion

                    CalculateImpostorScores(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mu_s043);

                    FalseRejectRate(s043_Genuine, N); 
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
                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s044_Samples = ExtractTrainingSamples(s044, N);

                    mu_s044 = CalculateTemplateVectors(s044_Samples, N);

                    s044_Test = ExtractTestingSamples(s044, N);

                    s044_Genuine = CalculateGenuineScores(s004_Test, mu_s044, N);

                    #region Extracting all the samples for the impostor calculations
                    s002_Test = ExtractTestingSamples(s002, N);
                    s003_Test = ExtractTestingSamples(s003, N);
                    s004_Test = ExtractTestingSamples(s004, N);
                    s005_Test = ExtractTestingSamples(s005, N);
                    s007_Test = ExtractTestingSamples(s007, N);
                    s008_Test = ExtractTestingSamples(s008, N);
                    s010_Test = ExtractTestingSamples(s010, N);
                    s011_Test = ExtractTestingSamples(s011, N);
                    s012_Test = ExtractTestingSamples(s012, N);
                    s013_Test = ExtractTestingSamples(s013, N);
                    s015_Test = ExtractTestingSamples(s015, N);
                    s016_Test = ExtractTestingSamples(s016, N);
                    s017_Test = ExtractTestingSamples(s017, N);
                    s018_Test = ExtractTestingSamples(s018, N);
                    s019_Test = ExtractTestingSamples(s019, N);
                    s020_Test = ExtractTestingSamples(s020, N);
                    s021_Test = ExtractTestingSamples(s021, N);
                    s022_Test = ExtractTestingSamples(s022, N);
                    s024_Test = ExtractTestingSamples(s024, N);
                    s025_Test = ExtractTestingSamples(s025, N);
                    s026_Test = ExtractTestingSamples(s026, N);
                    s027_Test = ExtractTestingSamples(s027, N);
                    s028_Test = ExtractTestingSamples(s028, N);
                    s029_Test = ExtractTestingSamples(s029, N);
                    s030_Test = ExtractTestingSamples(s030, N);
                    s031_Test = ExtractTestingSamples(s031, N);
                    s032_Test = ExtractTestingSamples(s032, N);
                    s033_Test = ExtractTestingSamples(s033, N);
                    s034_Test = ExtractTestingSamples(s034, N);
                    s035_Test = ExtractTestingSamples(s035, N);
                    s036_Test = ExtractTestingSamples(s036, N);
                    s037_Test = ExtractTestingSamples(s037, N);
                    s038_Test = ExtractTestingSamples(s038, N);
                    s039_Test = ExtractTestingSamples(s039, N);
                    s040_Test = ExtractTestingSamples(s040, N);
                    s041_Test = ExtractTestingSamples(s041, N);
                    s042_Test = ExtractTestingSamples(s042, N);
                    s043_Test = ExtractTestingSamples(s043, N);
                    s046_Test = ExtractTestingSamples(s046, N);
                    s047_Test = ExtractTestingSamples(s047, N);
                    s048_Test = ExtractTestingSamples(s048, N);
                    s049_Test = ExtractTestingSamples(s049, N);
                    s050_Test = ExtractTestingSamples(s050, N);
                    s051_Test = ExtractTestingSamples(s051, N);
                    s052_Test = ExtractTestingSamples(s052, N);
                    s053_Test = ExtractTestingSamples(s053, N);
                    s054_Test = ExtractTestingSamples(s054, N);
                    s055_Test = ExtractTestingSamples(s055, N);
                    s056_Test = ExtractTestingSamples(s056, N);
                    s057_Test = ExtractTestingSamples(s057, N);
                    #endregion

                    CalculateImpostorScores(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mu_s044);

                    FalseRejectRate(s044_Genuine, N); 
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
                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s046_Samples = ExtractTrainingSamples(s046, N);

                    mu_s046 = CalculateTemplateVectors(s046_Samples, N);

                    s046_Test = ExtractTestingSamples(s046, N);

                    s046_Genuine = CalculateGenuineScores(s046_Test, mu_s046, N);

                    #region Extracting all the samples for the impostor calculations
                    s002_Test = ExtractTestingSamples(s002, N);
                    s003_Test = ExtractTestingSamples(s003, N);
                    s004_Test = ExtractTestingSamples(s004, N);
                    s005_Test = ExtractTestingSamples(s005, N);
                    s007_Test = ExtractTestingSamples(s007, N);
                    s008_Test = ExtractTestingSamples(s008, N);
                    s010_Test = ExtractTestingSamples(s010, N);
                    s011_Test = ExtractTestingSamples(s011, N);
                    s012_Test = ExtractTestingSamples(s012, N);
                    s013_Test = ExtractTestingSamples(s013, N);
                    s015_Test = ExtractTestingSamples(s015, N);
                    s016_Test = ExtractTestingSamples(s016, N);
                    s017_Test = ExtractTestingSamples(s017, N);
                    s018_Test = ExtractTestingSamples(s018, N);
                    s019_Test = ExtractTestingSamples(s019, N);
                    s020_Test = ExtractTestingSamples(s020, N);
                    s021_Test = ExtractTestingSamples(s021, N);
                    s022_Test = ExtractTestingSamples(s022, N);
                    s024_Test = ExtractTestingSamples(s024, N);
                    s025_Test = ExtractTestingSamples(s025, N);
                    s026_Test = ExtractTestingSamples(s026, N);
                    s027_Test = ExtractTestingSamples(s027, N);
                    s028_Test = ExtractTestingSamples(s028, N);
                    s029_Test = ExtractTestingSamples(s029, N);
                    s030_Test = ExtractTestingSamples(s030, N);
                    s031_Test = ExtractTestingSamples(s031, N);
                    s032_Test = ExtractTestingSamples(s032, N);
                    s033_Test = ExtractTestingSamples(s033, N);
                    s034_Test = ExtractTestingSamples(s034, N);
                    s035_Test = ExtractTestingSamples(s035, N);
                    s036_Test = ExtractTestingSamples(s036, N);
                    s037_Test = ExtractTestingSamples(s037, N);
                    s038_Test = ExtractTestingSamples(s038, N);
                    s039_Test = ExtractTestingSamples(s039, N);
                    s040_Test = ExtractTestingSamples(s040, N);
                    s041_Test = ExtractTestingSamples(s041, N);
                    s042_Test = ExtractTestingSamples(s042, N);
                    s043_Test = ExtractTestingSamples(s043, N);
                    s044_Test = ExtractTestingSamples(s044, N);
                    s047_Test = ExtractTestingSamples(s047, N);
                    s048_Test = ExtractTestingSamples(s048, N);
                    s049_Test = ExtractTestingSamples(s049, N);
                    s050_Test = ExtractTestingSamples(s050, N);
                    s051_Test = ExtractTestingSamples(s051, N);
                    s052_Test = ExtractTestingSamples(s052, N);
                    s053_Test = ExtractTestingSamples(s053, N);
                    s054_Test = ExtractTestingSamples(s054, N);
                    s055_Test = ExtractTestingSamples(s055, N);
                    s056_Test = ExtractTestingSamples(s056, N);
                    s057_Test = ExtractTestingSamples(s057, N);
                    #endregion

                    CalculateImpostorScores(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mu_s046);

                    FalseRejectRate(s046_Genuine, N); 
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
                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s047_Samples = ExtractTrainingSamples(s047, N);

                    mu_s047 = CalculateTemplateVectors(s047_Samples, N);

                    s047_Test = ExtractTestingSamples(s047, N);

                    s047_Genuine = CalculateGenuineScores(s047_Test, mu_s047, N);

                    #region Extracting all the samples for the impostor calculations
                    s002_Test = ExtractTestingSamples(s002, N);
                    s003_Test = ExtractTestingSamples(s003, N);
                    s004_Test = ExtractTestingSamples(s004, N);
                    s005_Test = ExtractTestingSamples(s005, N);
                    s007_Test = ExtractTestingSamples(s007, N);
                    s008_Test = ExtractTestingSamples(s008, N);
                    s010_Test = ExtractTestingSamples(s010, N);
                    s011_Test = ExtractTestingSamples(s011, N);
                    s012_Test = ExtractTestingSamples(s012, N);
                    s013_Test = ExtractTestingSamples(s013, N);
                    s015_Test = ExtractTestingSamples(s015, N);
                    s016_Test = ExtractTestingSamples(s016, N);
                    s017_Test = ExtractTestingSamples(s017, N);
                    s018_Test = ExtractTestingSamples(s018, N);
                    s019_Test = ExtractTestingSamples(s019, N);
                    s020_Test = ExtractTestingSamples(s020, N);
                    s021_Test = ExtractTestingSamples(s021, N);
                    s022_Test = ExtractTestingSamples(s022, N);
                    s024_Test = ExtractTestingSamples(s024, N);
                    s025_Test = ExtractTestingSamples(s025, N);
                    s026_Test = ExtractTestingSamples(s026, N);
                    s027_Test = ExtractTestingSamples(s027, N);
                    s028_Test = ExtractTestingSamples(s028, N);
                    s029_Test = ExtractTestingSamples(s029, N);
                    s030_Test = ExtractTestingSamples(s030, N);
                    s031_Test = ExtractTestingSamples(s031, N);
                    s032_Test = ExtractTestingSamples(s032, N);
                    s033_Test = ExtractTestingSamples(s033, N);
                    s034_Test = ExtractTestingSamples(s034, N);
                    s035_Test = ExtractTestingSamples(s035, N);
                    s036_Test = ExtractTestingSamples(s036, N);
                    s037_Test = ExtractTestingSamples(s037, N);
                    s038_Test = ExtractTestingSamples(s038, N);
                    s039_Test = ExtractTestingSamples(s039, N);
                    s040_Test = ExtractTestingSamples(s040, N);
                    s041_Test = ExtractTestingSamples(s041, N);
                    s042_Test = ExtractTestingSamples(s042, N);
                    s043_Test = ExtractTestingSamples(s043, N);
                    s044_Test = ExtractTestingSamples(s044, N);
                    s046_Test = ExtractTestingSamples(s046, N);
                    s048_Test = ExtractTestingSamples(s048, N);
                    s049_Test = ExtractTestingSamples(s049, N);
                    s050_Test = ExtractTestingSamples(s050, N);
                    s051_Test = ExtractTestingSamples(s051, N);
                    s052_Test = ExtractTestingSamples(s052, N);
                    s053_Test = ExtractTestingSamples(s053, N);
                    s054_Test = ExtractTestingSamples(s054, N);
                    s055_Test = ExtractTestingSamples(s055, N);
                    s056_Test = ExtractTestingSamples(s056, N);
                    s057_Test = ExtractTestingSamples(s057, N);
                    #endregion

                    CalculateImpostorScores(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mu_s047);

                    FalseRejectRate(s047_Genuine, N); 
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
                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s048_Samples = ExtractTrainingSamples(s048, N);

                    mu_s048 = CalculateTemplateVectors(s048_Samples, N);

                    s048_Test = ExtractTestingSamples(s048, N);

                    s048_Genuine = CalculateGenuineScores(s048_Test, mu_s048, N);

                    #region Extracting all the samples for the impostor calculations
                    s002_Test = ExtractTestingSamples(s002, N);
                    s003_Test = ExtractTestingSamples(s003, N);
                    s004_Test = ExtractTestingSamples(s004, N);
                    s005_Test = ExtractTestingSamples(s005, N);
                    s007_Test = ExtractTestingSamples(s007, N);
                    s008_Test = ExtractTestingSamples(s008, N);
                    s010_Test = ExtractTestingSamples(s010, N);
                    s011_Test = ExtractTestingSamples(s011, N);
                    s012_Test = ExtractTestingSamples(s012, N);
                    s013_Test = ExtractTestingSamples(s013, N);
                    s015_Test = ExtractTestingSamples(s015, N);
                    s016_Test = ExtractTestingSamples(s016, N);
                    s017_Test = ExtractTestingSamples(s017, N);
                    s018_Test = ExtractTestingSamples(s018, N);
                    s019_Test = ExtractTestingSamples(s019, N);
                    s020_Test = ExtractTestingSamples(s020, N);
                    s021_Test = ExtractTestingSamples(s021, N);
                    s022_Test = ExtractTestingSamples(s022, N);
                    s024_Test = ExtractTestingSamples(s024, N);
                    s025_Test = ExtractTestingSamples(s025, N);
                    s026_Test = ExtractTestingSamples(s026, N);
                    s027_Test = ExtractTestingSamples(s027, N);
                    s028_Test = ExtractTestingSamples(s028, N);
                    s029_Test = ExtractTestingSamples(s029, N);
                    s030_Test = ExtractTestingSamples(s030, N);
                    s031_Test = ExtractTestingSamples(s031, N);
                    s032_Test = ExtractTestingSamples(s032, N);
                    s033_Test = ExtractTestingSamples(s033, N);
                    s034_Test = ExtractTestingSamples(s034, N);
                    s035_Test = ExtractTestingSamples(s035, N);
                    s036_Test = ExtractTestingSamples(s036, N);
                    s037_Test = ExtractTestingSamples(s037, N);
                    s038_Test = ExtractTestingSamples(s038, N);
                    s039_Test = ExtractTestingSamples(s039, N);
                    s040_Test = ExtractTestingSamples(s040, N);
                    s041_Test = ExtractTestingSamples(s041, N);
                    s042_Test = ExtractTestingSamples(s042, N);
                    s043_Test = ExtractTestingSamples(s043, N);
                    s044_Test = ExtractTestingSamples(s044, N);
                    s046_Test = ExtractTestingSamples(s046, N);
                    s047_Test = ExtractTestingSamples(s047, N);
                    s049_Test = ExtractTestingSamples(s049, N);
                    s050_Test = ExtractTestingSamples(s050, N);
                    s051_Test = ExtractTestingSamples(s051, N);
                    s052_Test = ExtractTestingSamples(s052, N);
                    s053_Test = ExtractTestingSamples(s053, N);
                    s054_Test = ExtractTestingSamples(s054, N);
                    s055_Test = ExtractTestingSamples(s055, N);
                    s056_Test = ExtractTestingSamples(s056, N);
                    s057_Test = ExtractTestingSamples(s057, N);
                    #endregion


                    // Method calls to calculate the Impostor scores and the False Reject Rates.  
                    CalculateImpostorScores(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mu_s048);

                    FalseRejectRate(s048_Genuine, N); 
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
                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s049_Samples = ExtractTrainingSamples(s049, N);

                    mu_s049 = CalculateTemplateVectors(s049_Samples, N);

                    s049_Test = ExtractTestingSamples(s049, N);

                    s049_Genuine = CalculateGenuineScores(s049_Test, mu_s049, N);

                    #region Extracting all the samples for the impostor calculations
                    s002_Test = ExtractTestingSamples(s002, N);
                    s003_Test = ExtractTestingSamples(s003, N);
                    s004_Test = ExtractTestingSamples(s004, N);
                    s005_Test = ExtractTestingSamples(s005, N);
                    s007_Test = ExtractTestingSamples(s007, N);
                    s008_Test = ExtractTestingSamples(s008, N);
                    s010_Test = ExtractTestingSamples(s010, N);
                    s011_Test = ExtractTestingSamples(s011, N);
                    s012_Test = ExtractTestingSamples(s012, N);
                    s013_Test = ExtractTestingSamples(s013, N);
                    s015_Test = ExtractTestingSamples(s015, N);
                    s016_Test = ExtractTestingSamples(s016, N);
                    s017_Test = ExtractTestingSamples(s017, N);
                    s018_Test = ExtractTestingSamples(s018, N);
                    s019_Test = ExtractTestingSamples(s019, N);
                    s020_Test = ExtractTestingSamples(s020, N);
                    s021_Test = ExtractTestingSamples(s021, N);
                    s022_Test = ExtractTestingSamples(s022, N);
                    s024_Test = ExtractTestingSamples(s024, N);
                    s025_Test = ExtractTestingSamples(s025, N);
                    s026_Test = ExtractTestingSamples(s026, N);
                    s027_Test = ExtractTestingSamples(s027, N);
                    s028_Test = ExtractTestingSamples(s028, N);
                    s029_Test = ExtractTestingSamples(s029, N);
                    s030_Test = ExtractTestingSamples(s030, N);
                    s031_Test = ExtractTestingSamples(s031, N);
                    s032_Test = ExtractTestingSamples(s032, N);
                    s033_Test = ExtractTestingSamples(s033, N);
                    s034_Test = ExtractTestingSamples(s034, N);
                    s035_Test = ExtractTestingSamples(s035, N);
                    s036_Test = ExtractTestingSamples(s036, N);
                    s037_Test = ExtractTestingSamples(s037, N);
                    s038_Test = ExtractTestingSamples(s038, N);
                    s039_Test = ExtractTestingSamples(s039, N);
                    s040_Test = ExtractTestingSamples(s040, N);
                    s041_Test = ExtractTestingSamples(s041, N);
                    s042_Test = ExtractTestingSamples(s042, N);
                    s043_Test = ExtractTestingSamples(s043, N);
                    s044_Test = ExtractTestingSamples(s044, N);
                    s046_Test = ExtractTestingSamples(s046, N);
                    s047_Test = ExtractTestingSamples(s047, N);
                    s048_Test = ExtractTestingSamples(s048, N);
                    s050_Test = ExtractTestingSamples(s050, N);
                    s051_Test = ExtractTestingSamples(s051, N);
                    s052_Test = ExtractTestingSamples(s052, N);
                    s053_Test = ExtractTestingSamples(s053, N);
                    s054_Test = ExtractTestingSamples(s054, N);
                    s055_Test = ExtractTestingSamples(s055, N);
                    s056_Test = ExtractTestingSamples(s056, N);
                    s057_Test = ExtractTestingSamples(s057, N);
                    #endregion

                    CalculateImpostorScores(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mu_s049);

                    FalseRejectRate(s049_Genuine, N); 
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
                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s050_Samples = ExtractTrainingSamples(s050, N);

                    mu_s050 = CalculateTemplateVectors(s050_Samples, N);

                    s050_Test = ExtractTestingSamples(s050, N);

                    s050_Genuine = CalculateGenuineScores(s050_Test, mu_s050, N);

                    #region Extracting all the samples for the impostor calculations
                    s002_Test = ExtractTestingSamples(s002, N);
                    s003_Test = ExtractTestingSamples(s003, N);
                    s004_Test = ExtractTestingSamples(s004, N);
                    s005_Test = ExtractTestingSamples(s005, N);
                    s007_Test = ExtractTestingSamples(s007, N);
                    s008_Test = ExtractTestingSamples(s008, N);
                    s010_Test = ExtractTestingSamples(s010, N);
                    s011_Test = ExtractTestingSamples(s011, N);
                    s012_Test = ExtractTestingSamples(s012, N);
                    s013_Test = ExtractTestingSamples(s013, N);
                    s015_Test = ExtractTestingSamples(s015, N);
                    s016_Test = ExtractTestingSamples(s016, N);
                    s017_Test = ExtractTestingSamples(s017, N);
                    s018_Test = ExtractTestingSamples(s018, N);
                    s019_Test = ExtractTestingSamples(s019, N);
                    s020_Test = ExtractTestingSamples(s020, N);
                    s021_Test = ExtractTestingSamples(s021, N);
                    s022_Test = ExtractTestingSamples(s022, N);
                    s024_Test = ExtractTestingSamples(s024, N);
                    s025_Test = ExtractTestingSamples(s025, N);
                    s026_Test = ExtractTestingSamples(s026, N);
                    s027_Test = ExtractTestingSamples(s027, N);
                    s028_Test = ExtractTestingSamples(s028, N);
                    s029_Test = ExtractTestingSamples(s029, N);
                    s030_Test = ExtractTestingSamples(s030, N);
                    s031_Test = ExtractTestingSamples(s031, N);
                    s032_Test = ExtractTestingSamples(s032, N);
                    s033_Test = ExtractTestingSamples(s033, N);
                    s034_Test = ExtractTestingSamples(s034, N);
                    s035_Test = ExtractTestingSamples(s035, N);
                    s036_Test = ExtractTestingSamples(s036, N);
                    s037_Test = ExtractTestingSamples(s037, N);
                    s038_Test = ExtractTestingSamples(s038, N);
                    s039_Test = ExtractTestingSamples(s039, N);
                    s040_Test = ExtractTestingSamples(s040, N);
                    s041_Test = ExtractTestingSamples(s041, N);
                    s042_Test = ExtractTestingSamples(s042, N);
                    s043_Test = ExtractTestingSamples(s043, N);
                    s044_Test = ExtractTestingSamples(s044, N);
                    s046_Test = ExtractTestingSamples(s046, N);
                    s047_Test = ExtractTestingSamples(s047, N);
                    s048_Test = ExtractTestingSamples(s048, N);
                    s049_Test = ExtractTestingSamples(s049, N);
                    s051_Test = ExtractTestingSamples(s051, N);
                    s052_Test = ExtractTestingSamples(s052, N);
                    s053_Test = ExtractTestingSamples(s053, N);
                    s054_Test = ExtractTestingSamples(s054, N);
                    s055_Test = ExtractTestingSamples(s055, N);
                    s056_Test = ExtractTestingSamples(s056, N);
                    s057_Test = ExtractTestingSamples(s057, N);
                    #endregion

                    CalculateImpostorScores(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mu_s050);

                    FalseRejectRate(s050_Genuine, N);
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
                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s051_Samples = ExtractTrainingSamples(s051, N);

                    mu_s051 = CalculateTemplateVectors(s051_Samples, N);

                    s051_Test = ExtractTestingSamples(s051, N);

                    s051_Genuine = CalculateGenuineScores(s051_Test, mu_s051, N);

                    #region Extracting all the samples for the impostor calculations
                    s002_Test = ExtractTestingSamples(s002, N);
                    s003_Test = ExtractTestingSamples(s003, N);
                    s004_Test = ExtractTestingSamples(s004, N);
                    s005_Test = ExtractTestingSamples(s005, N);
                    s007_Test = ExtractTestingSamples(s007, N);
                    s008_Test = ExtractTestingSamples(s008, N);
                    s010_Test = ExtractTestingSamples(s010, N);
                    s011_Test = ExtractTestingSamples(s011, N);
                    s012_Test = ExtractTestingSamples(s012, N);
                    s013_Test = ExtractTestingSamples(s013, N);
                    s015_Test = ExtractTestingSamples(s015, N);
                    s016_Test = ExtractTestingSamples(s016, N);
                    s017_Test = ExtractTestingSamples(s017, N);
                    s018_Test = ExtractTestingSamples(s018, N);
                    s019_Test = ExtractTestingSamples(s019, N);
                    s020_Test = ExtractTestingSamples(s020, N);
                    s021_Test = ExtractTestingSamples(s021, N);
                    s022_Test = ExtractTestingSamples(s022, N);
                    s024_Test = ExtractTestingSamples(s024, N);
                    s025_Test = ExtractTestingSamples(s025, N);
                    s026_Test = ExtractTestingSamples(s026, N);
                    s027_Test = ExtractTestingSamples(s027, N);
                    s028_Test = ExtractTestingSamples(s028, N);
                    s029_Test = ExtractTestingSamples(s029, N);
                    s030_Test = ExtractTestingSamples(s030, N);
                    s031_Test = ExtractTestingSamples(s031, N);
                    s032_Test = ExtractTestingSamples(s032, N);
                    s033_Test = ExtractTestingSamples(s033, N);
                    s034_Test = ExtractTestingSamples(s034, N);
                    s035_Test = ExtractTestingSamples(s035, N);
                    s036_Test = ExtractTestingSamples(s036, N);
                    s037_Test = ExtractTestingSamples(s037, N);
                    s038_Test = ExtractTestingSamples(s038, N);
                    s039_Test = ExtractTestingSamples(s039, N);
                    s040_Test = ExtractTestingSamples(s040, N);
                    s041_Test = ExtractTestingSamples(s041, N);
                    s042_Test = ExtractTestingSamples(s042, N);
                    s043_Test = ExtractTestingSamples(s043, N);
                    s044_Test = ExtractTestingSamples(s044, N);
                    s046_Test = ExtractTestingSamples(s046, N);
                    s047_Test = ExtractTestingSamples(s047, N);
                    s048_Test = ExtractTestingSamples(s048, N);
                    s049_Test = ExtractTestingSamples(s049, N);
                    s050_Test = ExtractTestingSamples(s050, N);
                    s052_Test = ExtractTestingSamples(s052, N);
                    s053_Test = ExtractTestingSamples(s053, N);
                    s054_Test = ExtractTestingSamples(s054, N);
                    s055_Test = ExtractTestingSamples(s055, N);
                    s056_Test = ExtractTestingSamples(s056, N);
                    s057_Test = ExtractTestingSamples(s057, N);
                    #endregion

                    CalculateImpostorScores(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mu_s002);

                    FalseRejectRate(s051_Genuine, N); 
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
                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s052_Samples = ExtractTrainingSamples(s052, N);

                    mu_s052 = CalculateTemplateVectors(s052_Samples, N);

                    s052_Test = ExtractTestingSamples(s052, N);

                    s052_Genuine = CalculateGenuineScores(s052_Test, mu_s052, N);

                    #region Extracting all the samples for the impostor calculations
                    s002_Test = ExtractTestingSamples(s002, N);
                    s003_Test = ExtractTestingSamples(s003, N);
                    s004_Test = ExtractTestingSamples(s004, N);
                    s005_Test = ExtractTestingSamples(s005, N);
                    s007_Test = ExtractTestingSamples(s007, N);
                    s008_Test = ExtractTestingSamples(s008, N);
                    s010_Test = ExtractTestingSamples(s010, N);
                    s011_Test = ExtractTestingSamples(s011, N);
                    s012_Test = ExtractTestingSamples(s012, N);
                    s013_Test = ExtractTestingSamples(s013, N);
                    s015_Test = ExtractTestingSamples(s015, N);
                    s016_Test = ExtractTestingSamples(s016, N);
                    s017_Test = ExtractTestingSamples(s017, N);
                    s018_Test = ExtractTestingSamples(s018, N);
                    s019_Test = ExtractTestingSamples(s019, N);
                    s020_Test = ExtractTestingSamples(s020, N);
                    s021_Test = ExtractTestingSamples(s021, N);
                    s022_Test = ExtractTestingSamples(s022, N);
                    s024_Test = ExtractTestingSamples(s024, N);
                    s025_Test = ExtractTestingSamples(s025, N);
                    s026_Test = ExtractTestingSamples(s026, N);
                    s027_Test = ExtractTestingSamples(s027, N);
                    s028_Test = ExtractTestingSamples(s028, N);
                    s029_Test = ExtractTestingSamples(s029, N);
                    s030_Test = ExtractTestingSamples(s030, N);
                    s031_Test = ExtractTestingSamples(s031, N);
                    s032_Test = ExtractTestingSamples(s032, N);
                    s033_Test = ExtractTestingSamples(s033, N);
                    s034_Test = ExtractTestingSamples(s034, N);
                    s035_Test = ExtractTestingSamples(s035, N);
                    s036_Test = ExtractTestingSamples(s036, N);
                    s037_Test = ExtractTestingSamples(s037, N);
                    s038_Test = ExtractTestingSamples(s038, N);
                    s039_Test = ExtractTestingSamples(s039, N);
                    s040_Test = ExtractTestingSamples(s040, N);
                    s041_Test = ExtractTestingSamples(s041, N);
                    s042_Test = ExtractTestingSamples(s042, N);
                    s043_Test = ExtractTestingSamples(s043, N);
                    s044_Test = ExtractTestingSamples(s044, N);
                    s046_Test = ExtractTestingSamples(s046, N);
                    s047_Test = ExtractTestingSamples(s047, N);
                    s048_Test = ExtractTestingSamples(s048, N);
                    s049_Test = ExtractTestingSamples(s049, N);
                    s050_Test = ExtractTestingSamples(s050, N);
                    s051_Test = ExtractTestingSamples(s051, N);
                    s053_Test = ExtractTestingSamples(s053, N);
                    s054_Test = ExtractTestingSamples(s054, N);
                    s055_Test = ExtractTestingSamples(s055, N);
                    s056_Test = ExtractTestingSamples(s056, N);
                    s057_Test = ExtractTestingSamples(s057, N);
                    #endregion

                    CalculateImpostorScores(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mu_s052);

                    FalseRejectRate(s052_Genuine, N); 
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
                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s053_Samples = ExtractTrainingSamples(s053, N);

                    mu_s053 = CalculateTemplateVectors(s053_Samples, N);

                    s053_Test = ExtractTestingSamples(s053, N);

                    s053_Genuine = CalculateGenuineScores(s053_Test, mu_s053, N);

                    #region Extracting all the samples for the impostor calculations
                    s002_Test = ExtractTestingSamples(s002, N);
                    s003_Test = ExtractTestingSamples(s003, N);
                    s004_Test = ExtractTestingSamples(s004, N);
                    s005_Test = ExtractTestingSamples(s005, N);
                    s007_Test = ExtractTestingSamples(s007, N);
                    s008_Test = ExtractTestingSamples(s008, N);
                    s010_Test = ExtractTestingSamples(s010, N);
                    s011_Test = ExtractTestingSamples(s011, N);
                    s012_Test = ExtractTestingSamples(s012, N);
                    s013_Test = ExtractTestingSamples(s013, N);
                    s015_Test = ExtractTestingSamples(s015, N);
                    s016_Test = ExtractTestingSamples(s016, N);
                    s017_Test = ExtractTestingSamples(s017, N);
                    s018_Test = ExtractTestingSamples(s018, N);
                    s019_Test = ExtractTestingSamples(s019, N);
                    s020_Test = ExtractTestingSamples(s020, N);
                    s021_Test = ExtractTestingSamples(s021, N);
                    s022_Test = ExtractTestingSamples(s022, N);
                    s024_Test = ExtractTestingSamples(s024, N);
                    s025_Test = ExtractTestingSamples(s025, N);
                    s026_Test = ExtractTestingSamples(s026, N);
                    s027_Test = ExtractTestingSamples(s027, N);
                    s028_Test = ExtractTestingSamples(s028, N);
                    s029_Test = ExtractTestingSamples(s029, N);
                    s030_Test = ExtractTestingSamples(s030, N);
                    s031_Test = ExtractTestingSamples(s031, N);
                    s032_Test = ExtractTestingSamples(s032, N);
                    s033_Test = ExtractTestingSamples(s033, N);
                    s034_Test = ExtractTestingSamples(s034, N);
                    s035_Test = ExtractTestingSamples(s035, N);
                    s036_Test = ExtractTestingSamples(s036, N);
                    s037_Test = ExtractTestingSamples(s037, N);
                    s038_Test = ExtractTestingSamples(s038, N);
                    s039_Test = ExtractTestingSamples(s039, N);
                    s040_Test = ExtractTestingSamples(s040, N);
                    s041_Test = ExtractTestingSamples(s041, N);
                    s042_Test = ExtractTestingSamples(s042, N);
                    s043_Test = ExtractTestingSamples(s043, N);
                    s044_Test = ExtractTestingSamples(s044, N);
                    s046_Test = ExtractTestingSamples(s046, N);
                    s047_Test = ExtractTestingSamples(s047, N);
                    s048_Test = ExtractTestingSamples(s048, N);
                    s049_Test = ExtractTestingSamples(s049, N);
                    s050_Test = ExtractTestingSamples(s050, N);
                    s051_Test = ExtractTestingSamples(s051, N);
                    s052_Test = ExtractTestingSamples(s052, N);
                    s054_Test = ExtractTestingSamples(s054, N);
                    s055_Test = ExtractTestingSamples(s055, N);
                    s056_Test = ExtractTestingSamples(s056, N);
                    s057_Test = ExtractTestingSamples(s057, N);
                    #endregion

                    CalculateImpostorScores(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mu_s053);

                    FalseRejectRate(s053_Genuine, N);
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
                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s054_Samples = ExtractTrainingSamples(s054, N);

                    mu_s054 = CalculateTemplateVectors(s054_Samples, N);

                    s054_Test = ExtractTestingSamples(s054, N);

                    s054_Genuine = CalculateGenuineScores(s054_Test, mu_s054, N);

                    #region Extracting all the samples for the impostor calculations
                    s002_Test = ExtractTestingSamples(s002, N);
                    s003_Test = ExtractTestingSamples(s003, N);
                    s004_Test = ExtractTestingSamples(s004, N);
                    s005_Test = ExtractTestingSamples(s005, N);
                    s007_Test = ExtractTestingSamples(s007, N);
                    s008_Test = ExtractTestingSamples(s008, N);
                    s010_Test = ExtractTestingSamples(s010, N);
                    s011_Test = ExtractTestingSamples(s011, N);
                    s012_Test = ExtractTestingSamples(s012, N);
                    s013_Test = ExtractTestingSamples(s013, N);
                    s015_Test = ExtractTestingSamples(s015, N);
                    s016_Test = ExtractTestingSamples(s016, N);
                    s017_Test = ExtractTestingSamples(s017, N);
                    s018_Test = ExtractTestingSamples(s018, N);
                    s019_Test = ExtractTestingSamples(s019, N);
                    s020_Test = ExtractTestingSamples(s020, N);
                    s021_Test = ExtractTestingSamples(s021, N);
                    s022_Test = ExtractTestingSamples(s022, N);
                    s024_Test = ExtractTestingSamples(s024, N);
                    s025_Test = ExtractTestingSamples(s025, N);
                    s026_Test = ExtractTestingSamples(s026, N);
                    s027_Test = ExtractTestingSamples(s027, N);
                    s028_Test = ExtractTestingSamples(s028, N);
                    s029_Test = ExtractTestingSamples(s029, N);
                    s030_Test = ExtractTestingSamples(s030, N);
                    s031_Test = ExtractTestingSamples(s031, N);
                    s032_Test = ExtractTestingSamples(s032, N);
                    s033_Test = ExtractTestingSamples(s033, N);
                    s034_Test = ExtractTestingSamples(s034, N);
                    s035_Test = ExtractTestingSamples(s035, N);
                    s036_Test = ExtractTestingSamples(s036, N);
                    s037_Test = ExtractTestingSamples(s037, N);
                    s038_Test = ExtractTestingSamples(s038, N);
                    s039_Test = ExtractTestingSamples(s039, N);
                    s040_Test = ExtractTestingSamples(s040, N);
                    s041_Test = ExtractTestingSamples(s041, N);
                    s042_Test = ExtractTestingSamples(s042, N);
                    s043_Test = ExtractTestingSamples(s043, N);
                    s044_Test = ExtractTestingSamples(s044, N);
                    s046_Test = ExtractTestingSamples(s046, N);
                    s047_Test = ExtractTestingSamples(s047, N);
                    s048_Test = ExtractTestingSamples(s048, N);
                    s049_Test = ExtractTestingSamples(s049, N);
                    s050_Test = ExtractTestingSamples(s050, N);
                    s051_Test = ExtractTestingSamples(s051, N);
                    s052_Test = ExtractTestingSamples(s052, N);
                    s053_Test = ExtractTestingSamples(s053, N);
                    s055_Test = ExtractTestingSamples(s055, N);
                    s056_Test = ExtractTestingSamples(s056, N);
                    s057_Test = ExtractTestingSamples(s057, N);
                    #endregion

                    CalculateImpostorScores(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s055_Test, s056_Test, s057_Test, N, mu_s054);

                    FalseRejectRate(s054_Genuine, N);
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
                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s055_Samples = ExtractTrainingSamples(s055, N);

                    mu_s055 = CalculateTemplateVectors(s055_Samples, N);

                    s055_Test = ExtractTestingSamples(s055, N);

                    s055_Genuine = CalculateGenuineScores(s055_Test, mu_s055, N);

                    #region Extracting all the samples for the impostor calculations
                    s002_Test = ExtractTestingSamples(s002, N);
                    s003_Test = ExtractTestingSamples(s003, N);
                    s004_Test = ExtractTestingSamples(s004, N);
                    s005_Test = ExtractTestingSamples(s005, N);
                    s007_Test = ExtractTestingSamples(s007, N);
                    s008_Test = ExtractTestingSamples(s008, N);
                    s010_Test = ExtractTestingSamples(s010, N);
                    s011_Test = ExtractTestingSamples(s011, N);
                    s012_Test = ExtractTestingSamples(s012, N);
                    s013_Test = ExtractTestingSamples(s013, N);
                    s015_Test = ExtractTestingSamples(s015, N);
                    s016_Test = ExtractTestingSamples(s016, N);
                    s017_Test = ExtractTestingSamples(s017, N);
                    s018_Test = ExtractTestingSamples(s018, N);
                    s019_Test = ExtractTestingSamples(s019, N);
                    s020_Test = ExtractTestingSamples(s020, N);
                    s021_Test = ExtractTestingSamples(s021, N);
                    s022_Test = ExtractTestingSamples(s022, N);
                    s024_Test = ExtractTestingSamples(s024, N);
                    s025_Test = ExtractTestingSamples(s025, N);
                    s026_Test = ExtractTestingSamples(s026, N);
                    s027_Test = ExtractTestingSamples(s027, N);
                    s028_Test = ExtractTestingSamples(s028, N);
                    s029_Test = ExtractTestingSamples(s029, N);
                    s030_Test = ExtractTestingSamples(s030, N);
                    s031_Test = ExtractTestingSamples(s031, N);
                    s032_Test = ExtractTestingSamples(s032, N);
                    s033_Test = ExtractTestingSamples(s033, N);
                    s034_Test = ExtractTestingSamples(s034, N);
                    s035_Test = ExtractTestingSamples(s035, N);
                    s036_Test = ExtractTestingSamples(s036, N);
                    s037_Test = ExtractTestingSamples(s037, N);
                    s038_Test = ExtractTestingSamples(s038, N);
                    s039_Test = ExtractTestingSamples(s039, N);
                    s040_Test = ExtractTestingSamples(s040, N);
                    s041_Test = ExtractTestingSamples(s041, N);
                    s042_Test = ExtractTestingSamples(s042, N);
                    s043_Test = ExtractTestingSamples(s043, N);
                    s044_Test = ExtractTestingSamples(s044, N);
                    s046_Test = ExtractTestingSamples(s046, N);
                    s047_Test = ExtractTestingSamples(s047, N);
                    s048_Test = ExtractTestingSamples(s048, N);
                    s049_Test = ExtractTestingSamples(s049, N);
                    s050_Test = ExtractTestingSamples(s050, N);
                    s051_Test = ExtractTestingSamples(s051, N);
                    s052_Test = ExtractTestingSamples(s052, N);
                    s053_Test = ExtractTestingSamples(s053, N);
                    s054_Test = ExtractTestingSamples(s054, N);
                    s056_Test = ExtractTestingSamples(s056, N);
                    s057_Test = ExtractTestingSamples(s057, N);
                    #endregion

                    CalculateImpostorScores(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s056_Test, s057_Test, N, mu_s055);

                    FalseRejectRate(s055_Genuine, N);
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
                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s056_Samples = ExtractTrainingSamples(s056, N);

                    mu_s056 = CalculateTemplateVectors(s056_Samples, N);

                    s056_Test = ExtractTestingSamples(s056, N);

                    s056_Genuine = CalculateGenuineScores(s056_Test, mu_s056, N);

                    #region Extracting all the samples for the impostor calculations
                    s002_Test = ExtractTestingSamples(s002, N);
                    s003_Test = ExtractTestingSamples(s003, N);
                    s004_Test = ExtractTestingSamples(s004, N);
                    s005_Test = ExtractTestingSamples(s005, N);
                    s007_Test = ExtractTestingSamples(s007, N);
                    s008_Test = ExtractTestingSamples(s008, N);
                    s010_Test = ExtractTestingSamples(s010, N);
                    s011_Test = ExtractTestingSamples(s011, N);
                    s012_Test = ExtractTestingSamples(s012, N);
                    s013_Test = ExtractTestingSamples(s013, N);
                    s015_Test = ExtractTestingSamples(s015, N);
                    s016_Test = ExtractTestingSamples(s016, N);
                    s017_Test = ExtractTestingSamples(s017, N);
                    s018_Test = ExtractTestingSamples(s018, N);
                    s019_Test = ExtractTestingSamples(s019, N);
                    s020_Test = ExtractTestingSamples(s020, N);
                    s021_Test = ExtractTestingSamples(s021, N);
                    s022_Test = ExtractTestingSamples(s022, N);
                    s024_Test = ExtractTestingSamples(s024, N);
                    s025_Test = ExtractTestingSamples(s025, N);
                    s026_Test = ExtractTestingSamples(s026, N);
                    s027_Test = ExtractTestingSamples(s027, N);
                    s028_Test = ExtractTestingSamples(s028, N);
                    s029_Test = ExtractTestingSamples(s029, N);
                    s030_Test = ExtractTestingSamples(s030, N);
                    s031_Test = ExtractTestingSamples(s031, N);
                    s032_Test = ExtractTestingSamples(s032, N);
                    s033_Test = ExtractTestingSamples(s033, N);
                    s034_Test = ExtractTestingSamples(s034, N);
                    s035_Test = ExtractTestingSamples(s035, N);
                    s036_Test = ExtractTestingSamples(s036, N);
                    s037_Test = ExtractTestingSamples(s037, N);
                    s038_Test = ExtractTestingSamples(s038, N);
                    s039_Test = ExtractTestingSamples(s039, N);
                    s040_Test = ExtractTestingSamples(s040, N);
                    s041_Test = ExtractTestingSamples(s041, N);
                    s042_Test = ExtractTestingSamples(s042, N);
                    s043_Test = ExtractTestingSamples(s043, N);
                    s044_Test = ExtractTestingSamples(s044, N);
                    s046_Test = ExtractTestingSamples(s046, N);
                    s047_Test = ExtractTestingSamples(s047, N);
                    s048_Test = ExtractTestingSamples(s048, N);
                    s049_Test = ExtractTestingSamples(s049, N);
                    s050_Test = ExtractTestingSamples(s050, N);
                    s051_Test = ExtractTestingSamples(s051, N);
                    s052_Test = ExtractTestingSamples(s052, N);
                    s053_Test = ExtractTestingSamples(s053, N);
                    s054_Test = ExtractTestingSamples(s054, N);
                    s055_Test = ExtractTestingSamples(s055, N);
                    s057_Test = ExtractTestingSamples(s057, N);
                    #endregion

                    CalculateImpostorScores(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s057_Test, N, mu_s056);

                    FalseRejectRate(s056_Genuine, N);
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
                Console.Write("Enter N: The number of samples. Value of N could be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string inputN = Console.ReadLine();

                if (inputN == "100" || inputN == "200" || inputN == "300")
                {
                    int N = int.Parse(inputN);

                    double[,] s057_Samples = ExtractTrainingSamples(s057, N);

                    mu_s057 = CalculateTemplateVectors(s057_Samples, N);
                    s057_Test = ExtractTestingSamples(s057, N);

                    s057_Genuine = CalculateGenuineScores(s057_Test, mu_s057, N);

                    #region Extracting all the samples for the impostor calculations
                    s002_Test = ExtractTestingSamples(s002, N);
                    s003_Test = ExtractTestingSamples(s003, N);
                    s004_Test = ExtractTestingSamples(s004, N);
                    s005_Test = ExtractTestingSamples(s005, N);
                    s007_Test = ExtractTestingSamples(s007, N);
                    s008_Test = ExtractTestingSamples(s008, N);
                    s010_Test = ExtractTestingSamples(s010, N);
                    s011_Test = ExtractTestingSamples(s011, N);
                    s012_Test = ExtractTestingSamples(s012, N);
                    s013_Test = ExtractTestingSamples(s013, N);
                    s015_Test = ExtractTestingSamples(s015, N);
                    s016_Test = ExtractTestingSamples(s016, N);
                    s017_Test = ExtractTestingSamples(s017, N);
                    s018_Test = ExtractTestingSamples(s018, N);
                    s019_Test = ExtractTestingSamples(s019, N);
                    s020_Test = ExtractTestingSamples(s020, N);
                    s021_Test = ExtractTestingSamples(s021, N);
                    s022_Test = ExtractTestingSamples(s022, N);
                    s024_Test = ExtractTestingSamples(s024, N);
                    s025_Test = ExtractTestingSamples(s025, N);
                    s026_Test = ExtractTestingSamples(s026, N);
                    s027_Test = ExtractTestingSamples(s027, N);
                    s028_Test = ExtractTestingSamples(s028, N);
                    s029_Test = ExtractTestingSamples(s029, N);
                    s030_Test = ExtractTestingSamples(s030, N);
                    s031_Test = ExtractTestingSamples(s031, N);
                    s032_Test = ExtractTestingSamples(s032, N);
                    s033_Test = ExtractTestingSamples(s033, N);
                    s034_Test = ExtractTestingSamples(s034, N);
                    s035_Test = ExtractTestingSamples(s035, N);
                    s036_Test = ExtractTestingSamples(s036, N);
                    s037_Test = ExtractTestingSamples(s037, N);
                    s038_Test = ExtractTestingSamples(s038, N);
                    s039_Test = ExtractTestingSamples(s039, N);
                    s040_Test = ExtractTestingSamples(s040, N);
                    s041_Test = ExtractTestingSamples(s041, N);
                    s042_Test = ExtractTestingSamples(s042, N);
                    s043_Test = ExtractTestingSamples(s043, N);
                    s044_Test = ExtractTestingSamples(s044, N);
                    s046_Test = ExtractTestingSamples(s046, N);
                    s047_Test = ExtractTestingSamples(s047, N);
                    s048_Test = ExtractTestingSamples(s048, N);
                    s049_Test = ExtractTestingSamples(s049, N);
                    s050_Test = ExtractTestingSamples(s050, N);
                    s051_Test = ExtractTestingSamples(s051, N);
                    s052_Test = ExtractTestingSamples(s052, N);
                    s053_Test = ExtractTestingSamples(s053, N);
                    s054_Test = ExtractTestingSamples(s054, N);
                    s055_Test = ExtractTestingSamples(s055, N);
                    s056_Test = ExtractTestingSamples(s056, N);
                    #endregion

                    CalculateImpostorScores(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, N, mu_s057);

                    FalseRejectRate(s057_Genuine, N);
                }

                else if (inputN != "100" || inputN == "200" || inputN != "300")
                {
                    Console.WriteLine("Your input sampling is too large, the program will now quit");
                    Console.ReadKey();
                }
            }
            #endregion
        }

        #region Calculating the False Reject Rate
        /// <summary>
        /// This will be calculating the false reject rate, given a threshold T, and the number of samples N. 
        /// </summary>
        /// <param name="s002_Genuine">These are the genuine scores which have been calculated</param>
        /// <param name="N">The number of samples, N.  This is an integer</param>
        static void FalseRejectRate(double[,] s002_Genuine, int N)
        {
            Console.Write("Enter your threshold T to find out the False Reject Rate for " + N + " samples." + Environment.NewLine + "T = ");
            double threshold_FRR = double.Parse(Console.ReadLine());

            int impostor = 0, genuine = 0;
            int FRR_Total = N * 51; 

            // Using the nested for loop to find out where the false reject rates occur
            // The logic here is a bit funky, but it works at the moment.  
            for (int i = 0; i < s002_Genuine.GetLength(0); i++)
            {
                for (int j = 0; j < s002_Genuine.GetLength(1); j++)
                {
                    if (threshold_FRR <= s002_Genuine[i, j])
                    {
                        impostor++;
                    }
                    else genuine++; 
                }
            }

            Console.Write(impostor + " scores which have been marked as impostor out of " + FRR_Total + " scores.");

            double FRR = Convert.ToDouble(impostor) / FRR_Total;

            Console.Write("The false reject rate, FRR = " + FRR + " with N = " + N + " samples at the threshold T = " + threshold_FRR + Environment.NewLine);

            #region Prompting the user whether or not to restart the whole program again
            Console.Write("Do you want to go again?" + Environment.NewLine + "Press y or n" + Environment.NewLine);
            string choice = Console.ReadLine();

            if (choice == "y")
            {
                Main();
            }

            if (choice == "n")
            {
                Console.Write("Thanks for using the Biometric Keyset Analyzer! Press any key to quit");
                Console.ReadKey();
            }
            #endregion
        }
        #endregion

        #region Method to calculate the Impostor Scores
        /// <summary>
        /// This is the method that is going to calculate the impostor scores using the data from other users
        /// but the user that the end user has specified.  This we refer to as the zero-effort impostor
        /// </summary>
        /// <param name="s003_Test">Test vector</param>
        /// <param name="s004_Test">Test vector</param>
        /// <param name="s005_Test">Test vector</param>
        /// <param name="s007_Test">Test vector</param>
        /// <param name="s008_Test">Test vector</param>
        /// <param name="s010_Test">Test vector</param>
        /// <param name="s011_Test">Test vector</param>
        /// <param name="s012_Test">Test vector</param>
        /// <param name="s013_Test">Test vector</param>
        /// <param name="s015_Test">Test vector</param>
        /// <param name="s016_Test">Test vector</param>
        /// <param name="s017_Test">Test vector</param>
        /// <param name="s018_Test">Test vector</param>
        /// <param name="s019_Test">Test vector</param>
        /// <param name="s020_Test">Test vector</param>
        /// <param name="s021_Test">Test vector</param>
        /// <param name="s022_Test">Test vector</param>
        /// <param name="s024_Test">Test vector</param>
        /// <param name="s025_Test">Test vector</param>
        /// <param name="s026_Test">Test vector</param>
        /// <param name="s027_Test">Test vector</param>
        /// <param name="s028_Test">Test vector</param>
        /// <param name="s029_Test">Test vector</param>
        /// <param name="s030_Test">Test vector</param>
        /// <param name="s031_Test">Test vector</param>
        /// <param name="s032_Test">Test vector</param>
        /// <param name="s033_Test">Test vector</param>
        /// <param name="s034_Test">Test vector</param>
        /// <param name="s035_Test">Test vector</param>
        /// <param name="s036_Test">Test vector</param>
        /// <param name="s037_Test">Test vector</param>
        /// <param name="s038_Test">Test vector</param>
        /// <param name="s039_Test">Test vector</param>
        /// <param name="s040_Test">Test vector</param>
        /// <param name="s041_Test">Test vector</param>
        /// <param name="s042_Test">Test vector</param>
        /// <param name="s043_Test">Test vector</param>
        /// <param name="s044_Test">Test vector</param>
        /// <param name="s046_Test">Test vector</param>
        /// <param name="s047_Test">Test vector</param>
        /// <param name="s048_Test">Test vector</param>
        /// <param name="s049_Test">Test vector</param>
        /// <param name="s050_Test">Test vector</param>
        /// <param name="s051_Test">Test vector</param>
        /// <param name="s052_Test">Test vector</param>
        /// <param name="s053_Test">Test vector</param>
        /// <param name="s054_Test">Test vector</param>
        /// <param name="s055_Test">Test vector</param>
        /// <param name="s056_Test">Test vector</param>
        /// <param name="s057_Test">Test vector</param>
        /// <param name="N">The number of samples</param>
        /// <param name="mu_s002">The average vector of the specified user</param>
        public static void CalculateImpostorScores(double[,] s003_Test, double[,] s004_Test, double[,] s005_Test, double[,] s007_Test, double[,] s008_Test, double[,] s010_Test, double[,] s011_Test, double[,] s012_Test, double[,] s013_Test, double[,] s015_Test, double[,] s016_Test, double[,] s017_Test, double[,] s018_Test, double[,] s019_Test, double[,] s020_Test, double[,] s021_Test, double[,] s022_Test, double[,] s024_Test, double[,] s025_Test, double[,] s026_Test, double[,] s027_Test, double[,] s028_Test, double[,] s029_Test, double[,] s030_Test, double[,] s031_Test, double[,] s032_Test, double[,] s033_Test, double[,] s034_Test, double[,] s035_Test, double[,] s036_Test, double[,] s037_Test, double[,] s038_Test, double[,] s039_Test, double[,] s040_Test, double[,] s041_Test, double[,] s042_Test, double[,] s043_Test, double[,] s044_Test, double[,] s046_Test, double[,] s047_Test, double[,] s048_Test, double[,] s049_Test, double[,] s050_Test, double[,] s051_Test, double[,] s052_Test, double[,] s053_Test, double[,] s054_Test, double[,] s055_Test, double[,] s056_Test, double[,] s057_Test, int N, double[] mu_s002)
        {
            #region 50 double arrays that represent the Impostor scores
            double[,] imp1 = new double[s003_Test.GetLength(0), 21];
            double[,] imp2 = new double[s003_Test.GetLength(0), 21];
            double[,] imp3 = new double[s003_Test.GetLength(0), 21];
            double[,] imp4 = new double[s003_Test.GetLength(0), 21];
            double[,] imp5 = new double[s003_Test.GetLength(0), 21];
            double[,] imp6 = new double[s003_Test.GetLength(0), 21];
            double[,] imp7 = new double[s003_Test.GetLength(0), 21];
            double[,] imp8 = new double[s003_Test.GetLength(0), 21];
            double[,] imp9 = new double[s003_Test.GetLength(0), 21];
            double[,] imp10 = new double[s003_Test.GetLength(0), 21];
            double[,] imp11 = new double[s003_Test.GetLength(0), 21];
            double[,] imp12 = new double[s003_Test.GetLength(0), 21];
            double[,] imp13 = new double[s003_Test.GetLength(0), 21];
            double[,] imp14 = new double[s003_Test.GetLength(0), 21];
            double[,] imp15 = new double[s003_Test.GetLength(0), 21];
            double[,] imp16 = new double[s003_Test.GetLength(0), 21];
            double[,] imp17 = new double[s003_Test.GetLength(0), 21];
            double[,] imp18 = new double[s003_Test.GetLength(0), 21];
            double[,] imp19 = new double[s003_Test.GetLength(0), 21];
            double[,] imp20 = new double[s003_Test.GetLength(0), 21];
            double[,] imp21 = new double[s003_Test.GetLength(0), 21];
            double[,] imp22 = new double[s003_Test.GetLength(0), 21];
            double[,] imp23 = new double[s003_Test.GetLength(0), 21];
            double[,] imp24 = new double[s003_Test.GetLength(0), 21];
            double[,] imp25 = new double[s003_Test.GetLength(0), 21];
            double[,] imp26 = new double[s003_Test.GetLength(0), 21];
            double[,] imp27 = new double[s003_Test.GetLength(0), 21];
            double[,] imp28 = new double[s003_Test.GetLength(0), 21];
            double[,] imp29 = new double[s003_Test.GetLength(0), 21];
            double[,] imp30 = new double[s003_Test.GetLength(0), 21];
            double[,] imp31 = new double[s003_Test.GetLength(0), 21];
            double[,] imp32 = new double[s003_Test.GetLength(0), 21];
            double[,] imp33 = new double[s003_Test.GetLength(0), 21];
            double[,] imp34 = new double[s003_Test.GetLength(0), 21];
            double[,] imp35 = new double[s003_Test.GetLength(0), 21];
            double[,] imp36 = new double[s003_Test.GetLength(0), 21];
            double[,] imp37 = new double[s003_Test.GetLength(0), 21];
            double[,] imp38 = new double[s003_Test.GetLength(0), 21];
            double[,] imp39 = new double[s003_Test.GetLength(0), 21];
            double[,] imp40 = new double[s003_Test.GetLength(0), 21];
            double[,] imp41 = new double[s003_Test.GetLength(0), 21];
            double[,] imp42 = new double[s003_Test.GetLength(0), 21];
            double[,] imp43 = new double[s003_Test.GetLength(0), 21];
            double[,] imp44 = new double[s003_Test.GetLength(0), 21];
            double[,] imp45 = new double[s003_Test.GetLength(0), 21];
            double[,] imp46 = new double[s003_Test.GetLength(0), 21];
            double[,] imp47 = new double[s003_Test.GetLength(0), 21];
            double[,] imp48 = new double[s003_Test.GetLength(0), 21];
            double[,] imp49 = new double[s003_Test.GetLength(0), 21];
            double[,] imp50 = new double[s003_Test.GetLength(0), 21]; 
            #endregion

            #region Populating all the arrays at one go. 
            for (int i = 0; i < s003_Test.GetLength(0); i++)
            {
                for (int j = 0; j < s003_Test.GetLength(1); j++)
                {
                    imp1[i,j] += (Math.Abs(s003_Test[i, j] - mu_s002[j]) / 2);
                    imp2[i,j] += (Math.Abs(s004_Test[i, j] - mu_s002[j]) / 2);
                    imp3[i,j] += (Math.Abs(s005_Test[i, j] - mu_s002[j]) / 2);
                    imp4[i,j] += (Math.Abs(s007_Test[i, j] - mu_s002[j]) / 2);
                    imp5[i,j] += (Math.Abs(s008_Test[i, j] - mu_s002[j]) / 2);
                    imp6[i,j] += (Math.Abs(s010_Test[i, j] - mu_s002[j]) / 2);
                    imp7[i,j] += (Math.Abs(s011_Test[i, j] - mu_s002[j]) / 2);
                    imp8[i,j] += (Math.Abs(s012_Test[i, j] - mu_s002[j]) / 2);
                    imp9[i,j] += (Math.Abs(s013_Test[i, j] - mu_s002[j]) / 2);
                    imp10[i,j] += (Math.Abs(s015_Test[i, j] - mu_s002[j]) / 2);
                    imp11[i,j] += (Math.Abs(s016_Test[i, j] - mu_s002[j]) / 2);
                    imp12[i,j] += (Math.Abs(s017_Test[i, j] - mu_s002[j]) / 2);
                    imp13[i,j] += (Math.Abs(s018_Test[i, j] - mu_s002[j]) / 2);
                    imp14[i,j] += (Math.Abs(s019_Test[i, j] - mu_s002[j]) / 2);
                    imp15[i,j] += (Math.Abs(s020_Test[i, j] - mu_s002[j]) / 2);
                    imp16[i,j] += (Math.Abs(s021_Test[i, j] - mu_s002[j]) / 2);
                    imp17[i,j] += (Math.Abs(s022_Test[i, j] - mu_s002[j]) / 2);
                    imp18[i,j] += (Math.Abs(s024_Test[i, j] - mu_s002[j]) / 2);
                    imp19[i,j] += (Math.Abs(s025_Test[i, j] - mu_s002[j]) / 2);
                    imp20[i,j] += (Math.Abs(s026_Test[i, j] - mu_s002[j]) / 2);
                    imp21[i,j] += (Math.Abs(s027_Test[i, j] - mu_s002[j]) / 2);
                    imp22[i,j] += (Math.Abs(s028_Test[i, j] - mu_s002[j]) / 2);
                    imp23[i,j] += (Math.Abs(s029_Test[i, j] - mu_s002[j]) / 2);
                    imp24[i,j] += (Math.Abs(s030_Test[i, j] - mu_s002[j]) / 2);
                    imp25[i,j] += (Math.Abs(s031_Test[i, j] - mu_s002[j]) / 2);
                    imp26[i,j] += (Math.Abs(s032_Test[i, j] - mu_s002[j]) / 2);
                    imp27[i,j] += (Math.Abs(s033_Test[i, j] - mu_s002[j]) / 2);
                    imp28[i,j] += (Math.Abs(s034_Test[i, j] - mu_s002[j]) / 2);
                    imp29[i,j] += (Math.Abs(s035_Test[i, j] - mu_s002[j]) / 2);
                    imp30[i,j] += (Math.Abs(s036_Test[i, j] - mu_s002[j]) / 2);
                    imp31[i,j] += (Math.Abs(s037_Test[i, j] - mu_s002[j]) / 2);
                    imp32[i,j] += (Math.Abs(s038_Test[i, j] - mu_s002[j]) / 2);
                    imp33[i,j] += (Math.Abs(s039_Test[i, j] - mu_s002[j]) / 2);
                    imp34[i,j] += (Math.Abs(s040_Test[i, j] - mu_s002[j]) / 2);
                    imp35[i,j] += (Math.Abs(s041_Test[i, j] - mu_s002[j]) / 2);
                    imp36[i,j] += (Math.Abs(s042_Test[i, j] - mu_s002[j]) / 2);
                    imp37[i,j] += (Math.Abs(s043_Test[i, j] - mu_s002[j]) / 2);
                    imp38[i,j] += (Math.Abs(s044_Test[i, j] - mu_s002[j]) / 2);
                    imp39[i,j] += (Math.Abs(s046_Test[i, j] - mu_s002[j]) / 2);
                    imp40[i,j] += (Math.Abs(s047_Test[i, j] - mu_s002[j]) / 2);
                    imp41[i,j] += (Math.Abs(s048_Test[i, j] - mu_s002[j]) / 2);
                    imp42[i,j] += (Math.Abs(s049_Test[i, j] - mu_s002[j]) / 2);
                    imp43[i,j] += (Math.Abs(s050_Test[i, j] - mu_s002[j]) / 2);
                    imp44[i,j] += (Math.Abs(s051_Test[i, j] - mu_s002[j]) / 2);
                    imp45[i,j] += (Math.Abs(s052_Test[i, j] - mu_s002[j]) / 2);
                    imp46[i,j] += (Math.Abs(s053_Test[i, j] - mu_s002[j]) / 2);
                    imp47[i,j] += (Math.Abs(s054_Test[i, j] - mu_s002[j]) / 2);
                    imp48[i,j] += (Math.Abs(s055_Test[i, j] - mu_s002[j]) / 2);
                    imp49[i,j] += (Math.Abs(s056_Test[i, j] - mu_s002[j]) / 2);
                    imp50[i,j] += (Math.Abs(s057_Test[i, j] - mu_s002[j]) / 2);
                }
            }
            #endregion

            Console.Write("Now to calculate the Impostor Pass Rate, please enter a threshold value of T." + Environment.NewLine + "T = ");
            string threshold = Console.ReadLine();
            double T = double.Parse(threshold); 

            // This is the method call for finding out the impostor pass rate
            ImpostorPassRate(imp1, imp2, imp3, imp4, imp5, imp6, imp7, imp8, imp9, imp10, imp11, imp12, imp13, imp14, imp15, imp16, imp17, imp18, imp19, imp20, imp21, imp22, imp23, imp24, imp25, imp26, imp27, imp28, imp29, imp30, imp31, imp32, imp33, imp34, imp35, imp36, imp37, imp38, imp39, imp40, imp41, imp42, imp43, imp44, imp45, imp46, imp47, imp48, imp49, imp50, T, N); 
        }
        #endregion

        #region Calculating the Impostor Pass Rate
        /// <summary>
        /// This method will calculate the Impostor Pass Rate, also known as the 
        /// False Accept Rate
        /// </summary>
        /// <param name="N">This is the number of samples, that is originally input from the beginning.</param>
        /// <param name="T">Threshold value, T which the user also inputs. </param>
        static void ImpostorPassRate(double[,] imp1, double[,] imp2, double[,] imp3, double[,] imp4, double[,] imp5, double[,] imp6, double[,] imp7, double[,] imp8, double[,] imp9, double[,] imp10, double[,] imp11, double[,] imp12, double[,] imp13, double[,] imp14, double[,] imp15, double[,] imp16, double[,] imp17, double[,] imp18, double[,] imp19, double[,] imp20, double[,] imp21, double[,] imp22, double[,] imp23, double[,] imp24, double[,] imp25, double[,] imp26, double[,] imp27, double[,] imp28, double[,] imp29, double[,] imp30, double[,] imp31, double[,] imp32, double[,] imp33, double[,] imp34, double[,] imp35, double[,] imp36, double[,] imp37, double[,] imp38, double[,] imp39, double[,] imp40, double[,] imp41, double[,] imp42, double[,] imp43, double[,] imp44, double[,] imp45, double[,] imp46, double[,] imp47, double[,] imp48, double[,] imp49, double[,] imp50, double T, int N)
        {
            int totalScores = 51 * 50 * N; 
            Console.Write("Your threshold T = " + T + ". Your sample size, N = " + N + "." + Environment.NewLine + "Total number of scores presented to the user are " + totalScores + Environment.NewLine);
            int genuine = 0;
           
            for (int i = 0; i < imp1.GetLength(0); i++)
            {
                for (int j = 0; j < imp1.GetLength(1); j++)
                {
                    #region Checking with the threshold whether or not if the impostor score is marked as genuine, that means the impostor is getting through.
                    if (imp1[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (imp2[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (imp3[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (imp4[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (imp5[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (imp6[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (imp7[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (imp8[i, j] <= T)
                    {
                        genuine++;
                    }


                    if (imp9[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (imp10[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (imp11[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (imp12[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (imp13[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (imp14[i, j] <= T)
                    {
                        genuine++;
                    }


                    if (imp15[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (imp16[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (imp17[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (imp18[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (imp19[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (imp20[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (imp21[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (imp22[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (imp23[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (imp24[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (imp25[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (imp26[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (imp27[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (imp28[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (imp29[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (imp30[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (imp31[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (imp32[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (imp33[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (imp34[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (imp35[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (imp36[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (imp37[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (imp38[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (imp39[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (imp40[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (imp41[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (imp42[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (imp43[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (imp44[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (imp45[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (imp46[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (imp47[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (imp48[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (imp49[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (imp50[i, j] <= T)
                    {
                        genuine++;
                    }
                    #endregion
                }
            }

            Console.WriteLine(genuine + " scores");

            double IPR = Convert.ToDouble(genuine) / totalScores;
            Console.WriteLine("Thus, given the sample size of N = " + N + ", the IPR = " + IPR);
        }
        #endregion

        #region This method will calculate the genuine scores
        /// <summary>
        /// Here, this method will be calculating the genuine scores
        /// </summary>
        /// <param name="s002_Test">The test vector that contains 400 - N samples</param>
        /// <param name="mu_s002">This is the mean or template vector of the first N samples</param>
        /// <param name="N">Static (fixed) integer value which contains the first N samples upon which analysis will be conducted</param>
        /// <note>Please note that I am making the assumption that for the Manhattan Verifier is being used with the value of n as the number of samples (N)</note>
        static double[,] CalculateGenuineScores(double[,] s002_Test, double[] mu_s002, int N)
        {
            // Initialize the 2D double array
            double[,] difference = new double[s002_Test.GetLength(0), 21];

            // Iterating over the nested for loop and making column wise calculations
            for (int i = 0; i < s002_Test.GetLength(0); i++)
            {
                for (int j = 0; j < s002_Test.GetLength(1) ; j++)
                {
                    // This is the first part to the Manhattan Distance verifier
                    difference[i, j] += (Math.Abs(s002_Test[i, j] - mu_s002[j])) / 2; 
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
                    for (int j = 0; j < test100.GetLength(1) - 1; j++)
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
            for (int k = 0; k < sum.Length; k++)
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
    }
}