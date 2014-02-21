namespace _01.TaskExecutor
{
    using System.Collections.Generic;

    public class Program
    {
        internal static void Main(string[] args)
        {
            var tasks = LoadTasks();

            foreach (var task in tasks)
            {
                task.ExecuteTask();
            }
        }

        private static IEnumerable<Task> LoadTasks()
        {
            return new HashSet<Task>()
            {
                new TagModifierTask(),
                new SentenceExtractorTask(),
                new TagModifierTask()
            };
        }
    }
}
