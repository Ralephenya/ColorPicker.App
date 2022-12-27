using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorPicker.Converter
{
    public class ColorConverter : IValueConverter
    {
        [Obsolete]
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            return Color.FromHex(value.ToString());


        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
