namespace _01.FileWriter
{
    using System;

    using Homework.Common;

    public class Program
    {
        internal static void Main(string[] args)
        {
            // Allow the user to select which special directory to start from, this can be some kind of menu or just asking about the name of the directory. 
            // Ask the user about a name for the file where you will write all the information
            var specialFolder = ConsoleInputHelper.SafeRead<Environment.SpecialFolder>();
            var directoryScanner = new DirecotryScanner();
            directoryScanner.ScanPath(Environment.GetFolderPath(specialFolder));

            // write the results above in a file with the chosen name         
            // Put all the iterating actions in a method and use recursion in order to read all the files and directories in the results of the previous reading. This should continue until there are no more subdirectories found.  
        }
    }
}
