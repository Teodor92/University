namespace _01.FileWriter
{
    using System;
    using System.IO;
    using System.Text;

    public class DirecotryScanner
    {
        private readonly StringBuilder buffer = new StringBuilder();

        public void ScanPath(string path, string outputFilePath = "../../files.txt")
        {
            this.GetSubDirs(path);

            using (var writer = new StreamWriter(outputFilePath))
            {
                writer.Write(this.buffer.ToString());
            }

            Console.WriteLine(this.buffer.ToString());
            this.buffer.Clear();
        }

        private void GetSubDirs(string path)
        {
            try
            {
                this.ShowFiles(path);

                var directories = Directory.GetDirectories(path);

                if (directories.Length > 0)
                {
                    foreach (string directory in directories)
                    {
                        this.GetSubDirs(directory);
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Directory: {0}, CAN NOT be accessed!", path);
            }
        }

        private void ShowFiles(string path)
        {
            var files = Directory.GetFiles(path);

            foreach (string file in files)
            {
                this.buffer.AppendLine(file);
            }
        }
    }
}
