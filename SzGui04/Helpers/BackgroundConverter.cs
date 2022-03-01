using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;
using SzGui04.Models;

namespace SzGui04.Helpers
{
    internal class BackgroundConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string alignment =value.ToString();
            if (alignment=="bad")
            {
                return Brushes.LightSalmon;
            }
            else if (alignment == "neutral")
            {
                return Brushes.LightYellow;
            }
            else
            {
                return Brushes.LightGreen;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }
}
