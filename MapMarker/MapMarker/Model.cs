using Syncfusion.SfMaps.XForms;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xamarin.Forms;

namespace MapMarker_Collection
{
    public class CustomMarker : MapMarker
    {
        public ImageSource ImageName { get; set; }
        public double Population { get; set; }
        public CustomMarker()
        {
            ImageName = ImageSource.FromResource("MapMarker_Collection.pin.png", typeof(CustomMarker).GetTypeInfo().Assembly);
        }
    }
}
