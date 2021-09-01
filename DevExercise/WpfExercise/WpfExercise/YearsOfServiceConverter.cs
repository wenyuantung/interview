using System;
using System.Globalization;
using System.Windows.Data;

namespace WpfExercise
{
    public  class YearsOfServiceConverter: IValueConverter {
       

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value == null) return false;
            if(parameter == null) return false;

            double ysParam, ysValue;
            if(!double.TryParse(value+"", out ysValue) ||
                !double.TryParse(parameter+"", out ysParam)) return false;

            return ysValue >= ysParam;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
