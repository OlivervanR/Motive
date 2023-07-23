using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Converter
{
    public class TruncateTextConverter : IValueConverter
    {
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            // Implement your conversion logic based on the flag
            if (parameter is not bool isButtonClicked && value is string text)
            {
                // Get the desired number of words to display
                int wordCountToShow = 20; // Change this value as needed

                // Split the text into words using space as the delimiter
                string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string dots = "";
                if (words.Length > wordCountToShow) { dots = "..."; }

                // Join the first 'wordCountToShow' words to create the truncated text
                string truncatedText = string.Join(" ", words, 0, Math.Min(words.Length, wordCountToShow)) + dots;

                return truncatedText;
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            // Implement your conversion back logic here (if needed)
            throw new NotImplementedException();
        }


    }
}
