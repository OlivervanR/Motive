using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Test.Converter
{
    public class EventTypeToWImageConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string eventType = value as string;

            if (eventType == "Club")
                return "soundwhite.png";
            else if (eventType == "Bar")
                return "beerwhite.png";
            else if (eventType == "Party")
                return "fireworkswhite.png";
            else if (eventType == "Music")
                return "musicwhite.png";

            return null; // Default color
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
