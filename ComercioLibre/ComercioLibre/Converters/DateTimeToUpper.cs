using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace ComercioLibre.Converters
{
    public class DateTimeToUpper : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var valor = (DateTime)value;
          //  StringFormat = '{0:dddd dd MMMM}'
            return string.Format("{0} {1} {2}", valor.ToString("dddd").ToUpper(), valor.ToString("dd"),valor.ToString("MMMM").ToUpper());
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
