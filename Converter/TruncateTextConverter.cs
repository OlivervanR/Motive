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
        public int WordCountToShow { get; set; } = 20; // Default value is 20

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Implement your conversion logic based on the flag
            if (parameter is not bool isButtonClicked && value is string text)
            {
                // Split the text into words using space as the delimiter
                string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string dots = "";
                if (words.Length > WordCountToShow) { dots = "..."; }

                // Join the first 'WordCountToShow' words to create the truncated text
                string truncatedText = string.Join(" ", words, 0, Math.Min(words.Length, WordCountToShow)) + dots;

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
