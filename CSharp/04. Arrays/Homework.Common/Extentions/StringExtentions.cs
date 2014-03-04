namespace Homework.Common.Extentions
{
    using System.ComponentModel;

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
    }
}
