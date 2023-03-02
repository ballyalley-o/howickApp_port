using System;
using System.Globalization;
using System.Windows.Data;

namespace xamlcs_howick_res_d.Helper
{
    //conv isLess
    public class IsLessThanConverter : IValueConverter
    {
        public static readonly IsLessThanConverter Instance = new IsLessThanConverter();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double doubleValue = System.Convert.ToDouble(value);
            double compareToValue = System.Convert.ToDouble(parameter);

            return doubleValue < compareToValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public static implicit operator IsLessThanConverter(IsGreaterThanConverter v)
        {
            throw new NotImplementedException();
        }
    }

    // conv isGreater

    public class IsGreaterThanConverter : IValueConverter
    {
        public static readonly IValueConverter Instance = new IsGreaterThanConverter();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double doubleValue = System.Convert.ToDouble(value);
            double compareToValue = System.Convert.ToDouble(parameter);

            return doubleValue > compareToValue; 
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }

}
