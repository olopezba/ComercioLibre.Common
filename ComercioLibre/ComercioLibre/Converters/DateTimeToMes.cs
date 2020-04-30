using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace ComercioLibre.Converters
{
    public class DateTimeToMes : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var valor = (DateTime)value;
            return string.Format("{0} {1}", valor.ToString("MMMM").ToUpper(),valor.ToString("yyyy"));
            //myDate.ToString("MMMM dd, yyyy")

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
