using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Test.Converter
{
    public class EventTypeToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string eventType = value as string;

            // Define your color mappings based on event type
            if (eventType == "Club")
                return Colors.Red; // Red color
            else if (eventType == "Bar")
                return Colors.Green;// Green color
            else if (eventType == "Party")
                return Colors.Blue; // Blue color

            return Colors.Black; // Default color
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
