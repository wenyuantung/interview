using System;
using System.Globalization;
using System.Windows.Data;

namespace Interview.Binding
{
    public  class AgeConverter: IValueConverter {
       

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value == null) return false;
            if(parameter == null) return false;
            double age;
            if(!double.TryParse(parameter+"", out age)) return false;
            return (((double)value) > age);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
