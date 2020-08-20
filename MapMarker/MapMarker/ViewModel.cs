using Syncfusion.SfMaps.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MapMarker_Collection
{
    public class ViewModel
    {
        public ObservableCollection<MapMarker> CustomMarkers { get; set; }
        public ViewModel()
        {
            CustomMarkers = new ObservableCollection<MapMarker>();
            CustomMarkers.Add(new CustomMarker() { Label = "United States", Latitude = "38.8833", Longitude = "-77.0167", Population = 321174000 });
            CustomMarkers.Add(new CustomMarker() { Label = "Brazil", Latitude = "-15.7833", Longitude = "-47.8667", Population = 204436000 });
            CustomMarkers.Add(new CustomMarker() { Label = "India", Latitude = "21.0000", Longitude = "78.0000", Population = 1272470000 });
            CustomMarkers.Add(new CustomMarker() { Label = "China", Latitude = "35.0000", Longitude = "103.0000", Population = 1370320000 });
            CustomMarkers.Add(new CustomMarker() { Label = "Indonesia", Latitude = "-6.1750", Longitude = "106.8283", Population = 255461700 });
        }
    }
}
