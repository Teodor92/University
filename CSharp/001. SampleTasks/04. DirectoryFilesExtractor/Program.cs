namespace _04.DirectoryFilesExtractor
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Program
    {
        internal static void Main(string[] args)
        {
            var directory = @"E:\Elmah";
            var files = Directory.GetFiles(directory);
            var fileFragments = new List<FileFragment>();

            foreach (var file in files)
            {
                fileFragments.Add(new FileFragment()
                {
                    Name = Path.GetFileName(file),
                    CreateDate = File.GetCreationTime(file)
                });
            }

            var orderedFiles = fileFragments.OrderBy(x => x.CreateDate);

            using (var writer = new StreamWriter(@"../../orderedFiles.txt"))
            {
                foreach (var fileFragment in fileFragments)
                {
                    writer.WriteLine("Name: {0} | Create Date: {1}", fileFragment.Name, fileFragment.CreateDate);
                }
            }
        }
    }
}
