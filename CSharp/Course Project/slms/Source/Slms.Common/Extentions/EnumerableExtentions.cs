namespace Slms.Common.Extentions
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;

    public static class EnumerableExtentions
    {
        public static DataTable ToDataTable<T>(this IEnumerable<T> data)
        {
            var properties = TypeDescriptor.GetProperties(typeof(T));
            var outputTable = new DataTable();

            for (int i = 0; i < properties.Count; i++)
            {
                var property = properties[i];
                if (string.IsNullOrWhiteSpace(property.Description))
                {
                    outputTable.Columns.Add(property.Name, property.PropertyType);
                }
                else
                {
                    outputTable.Columns.Add(property.Description, property.PropertyType);
                }
            }

            var values = new object[properties.Count];
            foreach (var item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = properties[i].GetValue(item);
                }

                outputTable.Rows.Add(values);
            }

            return outputTable;
        }
    }
}
