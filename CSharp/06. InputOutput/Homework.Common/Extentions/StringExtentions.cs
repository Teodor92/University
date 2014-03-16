namespace Homework.Common.Extentions
{
    using System.ComponentModel;
    using System.Text;

    public static class StringExtentions
    {
        public static T Convert<T>(this string input)
        {
            var converter = TypeDescriptor.GetConverter(typeof(T));
            if (converter != null)
            {
                return (T)converter.ConvertFromString(input);
            }

            return default(T);
        }

        public static string Create(this string input, string element, int times, char separator)
        {
            var output = new StringBuilder();
            for (int i = 0; i < times; i++)
            {
                output.Append(element);
                output.Append(separator);
                output.Append(' ');
            }

            return output.ToString().Trim(new[] { separator, ' ' });
        }
    }
}
