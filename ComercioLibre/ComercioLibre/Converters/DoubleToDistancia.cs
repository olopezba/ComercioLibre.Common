using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace ComercioLibre.Converters
{
    public class DoubleToDistancia : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string resultado = "";
            //recojo el valor
            var valor = (double)value ;

            if (valor < 1)
            {
                //LO PASO A METROS
                resultado = string.Format("{0:0}", valor*1000) +"m";
            }
            else 
            {
                //LO VUELVO A PASAR A KMS y dos decimales
                resultado =string.Format("{0:0.00}", valor)+"Km";
            }
            return resultado;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string valor = (string)value;
            return valor.Remove(0);
        }
    }
}
