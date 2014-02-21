namespace _01.TaskExecutor
{
    using System.Text.RegularExpressions;

    using Homework.Common;

    public class TagModifierTask : Task
    {

        private const string GreetingMessage = "Please enter the text with raw tags.";
        private const string UpperCaseTag = "<up>";
        private const string CurrentTaskName = "Tag Modifier";
        private static readonly MatchEvaluator UpperCaseModifier = x => x.Groups[1].Value.ToUpper();

        public TagModifierTask()
        {
            this.TaskName = CurrentTaskName;
        }

        public override void ExecuteTask()
        {
            base.ExecuteTask();

            const string SampleString = "Sample <up>tagged</up> text with MANY <up>Tags</up>!";
            var userText = ConsoleInputHelper.SafeRead<string>(GreetingMessage);
            this.ShowResult(this.TransformText(userText));
        }

        private string TransformText(
            string input,
            string tagType = UpperCaseTag,
            MatchEvaluator expression = null)
        {
            if (expression == null)
            {
                expression = UpperCaseModifier;
            }

            string regex = string.Format("{0}(.*?){1}", tagType, this.GetEndTag(tagType));

            return Regex.Replace(
                input,
                regex,
                expression);
        }

        private string GetEndTag(string tag)
        {
            return tag.Insert(1, "/");
        }
    }
}
