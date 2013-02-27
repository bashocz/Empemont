using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Globalization;

namespace Empemont
{
    public class DurationProgressIndicatorConverter : IMultiValueConverter
    {
        public object Convert(
            object[] values, Type targetType,
            object parameter, CultureInfo culture)
        {
            TimeSpan duration = (TimeSpan)values[0];
            double availableWidth = (double)values[1];
            double percentComplete = duration.TotalMilliseconds / Configuration.AnnouncementMaxDuration.TotalMilliseconds;
            if (percentComplete > 1)
                percentComplete = 1;
            return availableWidth * percentComplete;
        }

        public object[] ConvertBack(
         object value, Type[] targetTypes,
         object parameter, CultureInfo culture)
        {
            throw new NotSupportedException("Cannot convert back");
        }
    }
}
