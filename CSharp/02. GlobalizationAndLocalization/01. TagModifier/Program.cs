namespace _01.TagModifier
{
    using System.Text.RegularExpressions;

    using Homework.Common;

    /// <summary>
    /// Converts to uppercase all the letters between every <up> and </up> tags in text entered by a user.
    /// </summary>
    public class Program
    {
        private const string GreetingMessage = "Please enter the text with raw tags.";
        private const string UpperCaseTag = "<up>";
        private static readonly MatchEvaluator UpperCaseModifier = x => x.Groups[1].Value.ToUpper();

        public static string TransformText(
            string input,
            string tagType = UpperCaseTag,
            MatchEvaluator expression = null)
        {
            if (expression == null)
            {
                expression = UpperCaseModifier;
            }

            string regex = string.Format("{0}(.*?){1}", tagType, GetEndTag(tagType));

            return Regex.Replace(
                input,
                regex,
                expression);
        }

        internal static void Main(string[] args)
        {
            const string SampleString = "Sample <up>tagged</up> text with MANY <up>Tags</up>!";
            var userText = ConsoleInputHelper.SafeRead<string>(GreetingMessage);
            ConsoleOutputHelper.WriteMessage(TransformText(userText), ConsoleMessageType.Success);
        }

        private static string GetEndTag(string tag)
        {
            return tag.Insert(1, "/");
        }
    }
}
