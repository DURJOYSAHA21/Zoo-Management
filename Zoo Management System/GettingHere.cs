using GMap.NET;
using GMap.NET.MapProviders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooManagementSystem
{
    public partial class GettingHere : Form
    {
        private int userID;
        public GettingHere(int userId)
        {
            userID = userId;
            InitializeComponent();
        }

        private void GettingHere_Load(object sender, EventArgs e)
        {
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            //GoogleMapProvider.Instance.ApiKey = "";

            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            gMapControl1.Position = new GMap.NET.PointLatLng(51.53540419583945, -0.1534133561299255);
            gMapControl1.Zoom = 15;

            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.ShowCenter = false;


            var marker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(
                new GMap.NET.PointLatLng(51.5353, -0.1534),
                GMap.NET.WindowsForms.Markers.GMarkerGoogleType.red);
            var markers = new GMap.NET.WindowsForms.GMapOverlay("markers");
            markers.Markers.Add(marker);
            gMapControl1.Overlays.Add(markers);
        }

        private void gMapControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            gMapControl1.Position = new PointLatLng(51.53540419583945, -0.1534133561299255);
            gMapControl1.Zoom = 15;
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            visitorHome home = new visitorHome(userID);
            home.Show();
            this.Hide();
        }
    }
}
