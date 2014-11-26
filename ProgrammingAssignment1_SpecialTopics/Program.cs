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
/// 25th November 2014
/// * Tearing this code down, and will now be reconstructing this code with the latest developments
/// which I know have worked after testing various methods.  
/// * I will be able to have the user select the user(s) and the sample size (N) for which they can be 
/// able to calculate and generate the genuine scores.
/// * For now, I will have the data being shown so that way I know that my logic is working as I originally
/// envisioned/thought of.
/// * Now here is the plan of attack:
///     1. Take the PasswordData.csv file and break it up into 50 or so separate csv files based upon the user subject ID
///     2. Have my code that is below to be user friendly, and (hopefully) efficient enough where the user can be able to control
///     the experiments.  
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
            Console.Write("We will now be starting to take data from various users and begin to calculate various rates. Begin by selecting the user to analyze.");
            #endregion


            Console.ReadKey(); // Default program termination
        }
    }
}