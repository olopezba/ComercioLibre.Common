using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace ComercioLibre.Converters
{
    public class BooleanToSiNo : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string resultado = "";
            var valor = (Boolean)value;
            if (valor==true)
            {
                resultado = "SI";
            }
            else
            {
                resultado = "NO";
            }
            return resultado;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Boolean resultado = false;
            string valor = (string)value;
            if (valor == "SI")
            {
                resultado = true;
            }

            return resultado;
        }
    }
}
