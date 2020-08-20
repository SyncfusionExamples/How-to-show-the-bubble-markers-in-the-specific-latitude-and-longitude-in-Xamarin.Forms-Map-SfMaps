using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace MapMarker_Collection
{
    public class TemplateConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                var population = (value as CustomMarker).Population;

                var isLowRange = population < 250000000;

                var isMiddleRange = population >= 250000000 && population < 400000000;

                double radius = isLowRange ? 5 : isMiddleRange ? 10 : 15;

                (parameter as BoxView).HeightRequest = (parameter as BoxView).WidthRequest = radius * 2;
                (parameter as BoxView).BackgroundColor = radius == 5 ? Color.FromHex("#2E769F") : (radius == 10) ? Color.FromHex("#D84444") : Color.FromHex("#816F28");
                return radius;
            }

            return 0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
