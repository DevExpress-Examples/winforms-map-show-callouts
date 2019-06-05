using System;
using System.Windows.Forms;
using DevExpress.XtraMap;

namespace AddItemsManually {

    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Create a map control with initial settings and add it to the form.
            MapControl map = new MapControl() 
                             { Dock = DockStyle.Fill, ZoomLevel = 4, CenterPoint = new GeoPoint(43, 15) };
            this.Controls.Add(map);

            // Create a layer to load image tiles from OpenStreetMap.
            ImageLayer tileLayer = new ImageLayer();
            tileLayer.DataProvider = new BingMapDataProvider();
            map.Layers.Add(tileLayer);

            // Create a layer to display vector items.
            VectorItemsLayer itemsLayer = new VectorItemsLayer();
            map.Layers.Add(itemsLayer);

            // Create a storage for map items and generate them.
            MapItemStorage storage = new MapItemStorage();
            MapItem[] capitals = GetCapitals();
            storage.Items.AddRange(capitals);
            itemsLayer.Data = storage;
        }

        // Create an array of callouts for 5 capital cities.
        MapItem[] GetCapitals() {
            return new MapItem[] { 
                new MapCallout() { Text = "London", Location = new GeoPoint(51.507222, -0.1275) },
                new MapCallout() { Text = "Rome", Location = new GeoPoint(41.9, 12.5) },
                new MapCallout() { Text = "Paris", Location = new GeoPoint(48.8567, 2.3508) },
                new MapCallout() { Text = "Berlin", Location = new GeoPoint(52.52, 13.38) },
                new MapCallout() { Text = "Madrid", Location = new GeoPoint(40.4, -3.68) }
            };
        }
    }

}

