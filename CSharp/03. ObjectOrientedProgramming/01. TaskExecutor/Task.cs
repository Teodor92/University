namespace _01.TaskExecutor
{
    using Homework.Common;

    public class Task
    {
        private const string DefaultTaskName = "Sample taks";

        public Task()
        {
            this.TaskName = DefaultTaskName;
        }

        protected string TaskName { get; set; }

        public virtual void ExecuteTask()
        {
            ConsoleOutputHelper.WriteMessage(this.TaskName, ConsoleMessageType.Info);
        }

        protected void ShowResult(string output)
        {
            ConsoleOutputHelper.WriteMessage(output, ConsoleMessageType.Success);
        }
    }
}
