using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class FormMap : Form
    {
        public FormMap()
        {
            InitializeComponent();
            gMapControl1.ShowCenter = false;

            gMapControl1.MapProvider = GMapProviders.GoogleMap;
           
            gMapControl1.Position = new PointLatLng(53.6853984,23.8377546);
            gMapControl1.MinZoom = 5;
            gMapControl1.MaxZoom = 100;
            gMapControl1.Zoom = 15;
            PointLatLng point1 = new PointLatLng(53.6854420, 23.8399558);
            PointLatLng point2 = new PointLatLng(53.67801, 23.837304);
            PointLatLng point3 = new PointLatLng(53.6802149, 23.827999);
            PointLatLng point4 = new PointLatLng(53.6954111, 23.8266502);
            PointLatLng point5 = new PointLatLng(53.6952161, 23.7933801);
            GMapMarker marker1 = new GMarkerGoogle(point1, GMarkerGoogleType.red);
            GMapMarker marker2 = new GMarkerGoogle(point2, GMarkerGoogleType.red);
            GMapMarker marker3 = new GMarkerGoogle(point3, GMarkerGoogleType.red);
            GMapMarker marker4 = new GMarkerGoogle(point4, GMarkerGoogleType.red);
            GMapMarker marker5 = new GMarkerGoogle(point5, GMarkerGoogleType.red);
            GMapOverlay markers = new GMapOverlay("markers");
            marker1.ToolTipText = "Стловая ГрГУ";
            markers.Markers.Add(marker1);
            markers.Markers.Add(marker2);
            markers.Markers.Add(marker3);
            markers.Markers.Add(marker4);
            markers.Markers.Add(marker5);
            gMapControl1.Overlays.Add(markers);
        }
    }
}
