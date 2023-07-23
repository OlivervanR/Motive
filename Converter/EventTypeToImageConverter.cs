using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Test.Converter
{
    public class EventTypeToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string eventType = value as string;

            if (eventType == "Club")
                return "sound.png";
            else if (eventType == "Bar")
                return "beer.png";
            else if (eventType == "Party")
                return "fireworks.png";
            else if (eventType == "Music")
                return "music.png";

            return null; // Default color
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
