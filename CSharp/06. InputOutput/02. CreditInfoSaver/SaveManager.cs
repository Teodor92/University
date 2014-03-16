namespace _02.CreditInfoSaver
{
    using System.Collections.Generic;
    using System.IO;

    public class SaveManager
    {
        public static void SaveCollectionToFile(IEnumerable<object> objects)
        {
            foreach (var obj in objects)
            {
                SaveObjectToFile(obj);
            }
        }

        public static void SaveObjectToFile(object input)
        {
            string filePath;

            if (input is Credit)
            {
                filePath = "../../Credits.txt";
            }
            else if (input is Borrower)
            {
                filePath = "../../Borrowers.txt";
            }
            else
            {
                filePath = "../../Unknown.txt";
            }

            using (var writer = File.AppendText(filePath))
            {
                writer.WriteLineAsync(input.ToString());
            }
        }
    }
}
