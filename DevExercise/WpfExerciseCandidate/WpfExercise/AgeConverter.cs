using System;
using System.Globalization;
using System.Windows.Data;

namespace WpfExercise
{
    public  class AgeConverter: IValueConverter {
       

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value == null) return false;
            if(parameter == null) return false;

            double ageParam, ageValue;
            if(!double.TryParse(value+"", out ageValue) ||
                !double.TryParse(parameter+"", out ageParam)) return false;

            return ageValue > ageParam;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
