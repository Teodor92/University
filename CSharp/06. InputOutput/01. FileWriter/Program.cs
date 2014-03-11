namespace _01.FileWriter
{
    using System;
    using System.IO;

    public class Program
    {
        internal static void Main(string[] args)
        {
            // Allow the user to select which special directory to start from, this can be some kind of menu or just asking about the name of the directory. 
            // Ask the user about a name for the file where you will write all the information
            string[] directories = Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            Console.WriteLine("Starting from:{0}{1}{1}Directories:{1}", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), Environment.NewLine);
            foreach (string directory in directories)
            {
                Console.WriteLine(directory);
            }

            string[] files = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            Console.WriteLine("{0}Files:{0}", Environment.NewLine);

            foreach (string file in files)
            {
                Console.WriteLine(file);
            }

            // write the results above in a file with the chosen name         
            // Put all the iterating actions in a method and use recursion in order to read all the files and directories in the results of the previous reading. This should continue until there are no more subdirectories found.  
        }
    }
}
