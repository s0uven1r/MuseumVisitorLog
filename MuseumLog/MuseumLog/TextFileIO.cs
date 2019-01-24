using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MuseumLog
{
    public class TextFileIO<T> where T : class, new()
    {
        private List<PropertyInfo> _properties;
        private char _separator = ',';
        private string _newlineReplacement = ((char)0x254).ToString();
        private string _replacement = ((char)0x255).ToString();
        private string _rowNumberColumnTitle = "RowNumber";
        private bool _useLineNumbers = true;
        private bool _ignoreEmptyLines = true;
        private bool _ignoreReferenceTypesExceptString = true;
        private bool _useTextQualifier = false;

        public char Separator
        {
            get { return _separator; }
            set { _separator = value; }
        }
        public string NewlineReplacement
        {
            get { return _newlineReplacement; }
            set { _newlineReplacement = value; }
        }
        public string Replacement
        {
            get { return _replacement; }
            set { _replacement = value; }
        }
        public string RowNumberColumnTitle
        {
            get { return _rowNumberColumnTitle; }
            set { _rowNumberColumnTitle = value; }
        }
        public bool UseLineNumbers
        {
            get { return _useLineNumbers; }
            set { _useLineNumbers = value; }
        }
        public bool IgnoreEmptyLines
        {
            get { return _ignoreEmptyLines; }
            set { _ignoreEmptyLines = value; }
        }
        public bool IgnoreReferenceTypesExceptString
        {

            get { return _ignoreReferenceTypesExceptString; }
            set { _ignoreReferenceTypesExceptString = value; }

        }
        public bool UseTextQualifier
        {
            get { return _useTextQualifier; }
            set { _useTextQualifier = value; }
        }

        /// <summary>
        /// Csv Serializer
        /// Initialize by selected properties from the type to be de/serialized
        /// </summary>
        public TextFileIO()
        {
            Type type = typeof(T);

            PropertyInfo[] properties = type.GetProperties(
                BindingFlags.Public
                | BindingFlags.Instance
                | BindingFlags.GetProperty
                | BindingFlags.SetProperty
                );

            IQueryable<PropertyInfo> q = properties.AsQueryable();

            if (IgnoreReferenceTypesExceptString)
            {
                q = q.Where(
                    x => x.PropertyType.IsValueType || x.PropertyType.Name == "String"
                    );
            }

            IQueryable<PropertyInfo> r = q.Where(
                     y => y.GetCustomAttribute<CsvIgnoreAttribute>() == null
                );

            _properties = r.ToList();
        }

        /// <summary>
        /// GetHeader using property name
        /// </summary>
        /// <returns>string</returns>
        private string GetHeader()
        {
            var header = _properties.Select(a => a.Name);

            if (UseLineNumbers)
            {
                header = new string[] { RowNumberColumnTitle }.Union(header);
            }

            return string.Join(Separator.ToString(), header.ToArray());
        }

        private string GetData(IList<T> data, int row)
        {
            var sb = new StringBuilder();
            var values = new List<string>();
            if (row < 1)
            {
                row = 1;
                sb.AppendLine(GetHeader());
            }
            foreach (var item in data)
            {
                values.Clear();
                if (UseLineNumbers)
                {
                    values.Add(row++.ToString());
                }

                foreach (var p in _properties)
                {
                    var raw = p.GetValue(item);
                    var value = raw == null ? "" :
                        raw.ToString()
                        .Replace(Separator.ToString(), Replacement)
                        .Replace(Environment.NewLine, NewlineReplacement);

                    if (UseTextQualifier)
                    {
                        value = string.Format("\"{0}\"", value);
                    }

                    values.Add(value);
                }

                sb.AppendLine(string.Join(Separator.ToString(), values.ToArray()));
            }
            return sb.ToString().Trim();
        }

        /// <summary>
        /// Serialize
        /// </summary>
        /// <param name="stream">stream</param>
        /// <param name="data">data</param>
        public void WriteToFile(Stream stream, IList<T> data)
        {
            string dataToWrite = GetData(data, 0);

            using (var sw = new StreamWriter(stream))
            {
                sw.Write(dataToWrite);
            }
        }

        /// <summary>
        /// Serialize Append
        /// </summary>
        /// <param name="reader">reader</param>
        /// <param name="data">data</param>
        public void AppendToFile(Stream stream, IList<T> data)
        {
            string[] columns;
            string line;
            int rowNo = 0;
            try
            {
                using (var sr = new StreamReader(stream))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        columns = line.Split(Separator);
                        Int32.TryParse(columns[0], out rowNo);
                    }
                }

                string dataToWrite = GetData(data, (rowNo + 1));
                //use of file getter setter
                using (StreamWriter sw = File.AppendText("VisitorInformation.csv"))
                {
                    sw.WriteLine(dataToWrite);
                }

            }
            catch (Exception ex)
            {
                throw new InvalidCsvFormatException("The CSV File is Invalid. See Inner Exception for more inoformation.", ex);
            }

        }

        /// <summary>
        /// Deserilaize or Read from file
        /// </summary>
        /// <param name="stream"></param>
        public List<T> ReadFromFile(Stream stream)
        {
            string[] columns;
            string[] rows;

            try
            {
                using (StreamReader sr = new StreamReader(stream))
                {
                    columns = sr.ReadLine().Split(Separator);
                    rows = sr.ReadToEnd().Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                }

            }
            catch (Exception ex)
            {
                throw new InvalidCsvFormatException("The CSV File is Invalid. See Inner Exception for more inoformation.", ex);
            }

            List<T> data = new List<T>();
            for (int row = 0; row < rows.Length; row++)
            {
                string line = rows[row];

                if (IgnoreEmptyLines && string.IsNullOrWhiteSpace(line))
                {
                    continue;
                }
                else if (!IgnoreEmptyLines && string.IsNullOrWhiteSpace(line))
                {
                    throw new InvalidCsvFormatException(string.Format(@"Error: Empty line at line number: {0}", row));
                }

                string[] parts = line.Split(Separator);

                T datum = new T();
                int start = UseLineNumbers ? 1 : 0;

                for (int x = start; x < parts.Length; x++)
                {
                    string value = parts[x];
                    string column = columns[x];

                    if (column.Equals(RowNumberColumnTitle) && !_properties.Any(a => a.Name.Equals(RowNumberColumnTitle)))
                    {
                        continue;
                    }

                    value = value
                        .Replace(Replacement, Separator.ToString())
                        .Replace(NewlineReplacement, Environment.NewLine).Trim();

                    PropertyInfo p = _properties.FirstOrDefault(a => a.Name.Equals(column, StringComparison.InvariantCultureIgnoreCase));
                    if (p == null)
                    {
                        continue;
                    }

                    if (UseTextQualifier && !String.IsNullOrEmpty(value))
                    {

                        if (value.IndexOf("\"") == 0)
                            value = value.Substring(1);

                        if (value[value.Length - 1].ToString() == "\"")
                            value = value.Substring(0, value.Length - 1);
                    }

                    TypeConverter converter = TypeDescriptor.GetConverter(p.PropertyType);
                    var convertedValue = converter.ConvertFrom(value);

                    p.SetValue(datum, convertedValue);
                }
                data.Add(datum);
            }

            return data;
        }

        public List<T> SearchInFile(Stream stream, string valueToSearch)
        {
            List<string> matchedData = new List<string>();
            string[] columns;
            string line;

            try
            {
                using (StreamReader sr = new StreamReader(stream))
                {
                    columns = sr.ReadLine().Split(Separator);
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.Contains(valueToSearch))
                        {
                            matchedData.Add(line);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                throw new InvalidCsvFormatException("The CSV File is Invalid. See Inner Exception for more inoformation.", ex);
            }

            List<T> data = new List<T>();
            foreach (string row in matchedData)
            {
                string[] parts = row.Split(Separator);

                T datum = new T();
                int start = UseLineNumbers ? 1 : 0;

                for (int x = start; x < parts.Length; x++)
                {
                    string value = parts[x];
                    string column = columns[x];

                    if (column.Equals(RowNumberColumnTitle) && !_properties.Any(a => a.Name.Equals(RowNumberColumnTitle)))
                    {
                        continue;
                    }

                    value = value
                        .Replace(Replacement, Separator.ToString())
                        .Replace(NewlineReplacement, Environment.NewLine).Trim();

                    PropertyInfo p = _properties.FirstOrDefault(a => a.Name.Equals(column, StringComparison.InvariantCultureIgnoreCase));
                    if (p == null)
                    {
                        continue;
                    }

                    if (UseTextQualifier && !String.IsNullOrEmpty(value))
                    {

                        if (value.IndexOf("\"") == 0)
                            value = value.Substring(1);

                        if (value[value.Length - 1].ToString() == "\"")
                            value = value.Substring(0, value.Length - 1);
                    }

                    TypeConverter converter = TypeDescriptor.GetConverter(p.PropertyType);
                    var convertedValue = converter.ConvertFrom(value);

                    p.SetValue(datum, convertedValue);
                }
                data.Add(datum);
            }

            return data;
        }

    }
    public class CsvIgnoreAttribute : Attribute { }

    public class InvalidCsvFormatException : Exception
    {
        /// <summary>
        /// Invalid Csv Format Exception
        /// </summary>
        /// <param name="message">message</param>
        public InvalidCsvFormatException(string message)
            : base(message)
        {
        }

        public InvalidCsvFormatException(string message, Exception ex)
            : base(message, ex)
        {
        }
    }
}
