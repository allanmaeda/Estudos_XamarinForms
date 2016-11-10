using System;
using System.Globalization;
using Xamarin.Forms;

namespace XF_DataBinding6
{
    public class DoubleToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double result;
            if (!double.TryParse(value as string, out result))
                result = 0;
            return result;
        }
    }
}
