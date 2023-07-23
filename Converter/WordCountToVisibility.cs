using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Converter
{
    public class WordCountToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string text)
            {
                // Split the text into words using space as the delimiter
                string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                // Determine visibility based on the number of words (e.g., show button if more than 5 words)
                return words.Length > 20; // Change the condition as needed
            }

            return false; // Default visibility
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
