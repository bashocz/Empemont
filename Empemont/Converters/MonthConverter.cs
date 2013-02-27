using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Windows.Data;

namespace Empemont
{
    class MonthConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            DateTime date = (DateTime)values[0];
            bool actualMonth = (bool)values[1];

            if ((date.Day == 1) || ((date.DayOfWeek == DayOfWeek.Monday) && !actualMonth))
            {
                CultureInfo csCZ = new CultureInfo("cs-CZ");
                string month = date.ToString("MMMM", csCZ);
                if (month.Length > 0)
                    month = char.ToUpper(month[0]) + month.Substring(1);
                return month;
            }
            return string.Empty;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
