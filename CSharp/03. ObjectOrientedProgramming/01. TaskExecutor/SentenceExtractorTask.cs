namespace _01.TaskExecutor
{
    using System;
    using System.Linq;

    using Homework.Common;

    public class SentenceExtractorTask : Task
    {
        private const string CurrentTaskName = "Sentence Extracor";
        private const string GreetingMessage = "Enter all the sentance separtad by '.'.";
        private const string SearchWordPromt = "Enter a word to search for.";

        public SentenceExtractorTask()
        {
            this.TaskName = CurrentTaskName;
        }

        public override void ExecuteTask()
        {
            base.ExecuteTask();

            var userText = ConsoleInputHelper.SafeRead<string>(GreetingMessage);
            var searchWord = ConsoleInputHelper.SafeRead<string>(SearchWordPromt);

            var setnaces = userText.Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var setnace in setnaces)
            {
                if (setnace.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Any(x => x == searchWord))
                {
                    this.ShowResult(setnace.Trim());
                }
            }
        }
    }
}
