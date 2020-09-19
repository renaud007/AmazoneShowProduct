using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace AmazoneShowProduct.Converters
{
    public class BoolToStringConverter : IValueConverter
    {
        public string trueString { get; set; }
        public string falseString { get; set; }
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((bool)value == true)
            {
                return trueString;
            }
            else
            {
                return falseString;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
