using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace ComercioLibre.Converters
{
    public class EstadoReservaToColor:IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Color color = new Color();
            color = Color.White;
            switch (value)
            {
                case 0:
                    color = Color.LightGreen;
                    break;
                case 1:
                    color = Color.LightGray;
                    break;
                case 2:
                    color = Color.LightBlue;
                    break;
            }
            return color;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int resultado = 0;
            Color color = new Color();
            color = (Color)value;

            if (color.GetType().Name == "LightGray")
            {
                resultado = 0;
            }

            return resultado;
        }
    }
}
