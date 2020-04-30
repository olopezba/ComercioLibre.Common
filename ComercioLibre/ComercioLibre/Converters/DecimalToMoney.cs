using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace ComercioLibre.Converters
{
    public class DecimalToMoney : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var valor = (decimal)value;
            return valor.ToString("€");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string valor = (string)value;
            return valor.Remove(0);
        }
    }
}
