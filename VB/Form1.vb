Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraMap

Namespace AddItemsManually

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            ' Create a map control with initial settings and add it to the form.
            Dim map As MapControl = New MapControl() With {.Dock = DockStyle.Fill, .ZoomLevel = 4, .CenterPoint = New GeoPoint(43, 15)}
            Me.Controls.Add(map)
            ' Create a layer to load image tiles from OpenStreetMap.
            Dim tileLayer As ImageTilesLayer = New ImageTilesLayer()
            tileLayer.DataProvider = New BingMapDataProvider()
            map.Layers.Add(tileLayer)
            ' Create a layer to display vector items.
            Dim itemsLayer As VectorItemsLayer = New VectorItemsLayer()
            map.Layers.Add(itemsLayer)
            ' Create a storage for map items and generate them.
            Dim storage As MapItemStorage = New MapItemStorage()
            Dim capitals As MapItem() = GetCapitals()
            storage.Items.AddRange(capitals)
            itemsLayer.Data = storage
        End Sub

        ' Create an array of callouts for 5 capital cities.
        Private Function GetCapitals() As MapItem()
            Return New MapItem() {New MapCallout() With {.Text = "London", .Location = New GeoPoint(51.507222, -0.1275)}, New MapCallout() With {.Text = "Rome", .Location = New GeoPoint(41.9, 12.5)}, New MapCallout() With {.Text = "Paris", .Location = New GeoPoint(48.8567, 2.3508)}, New MapCallout() With {.Text = "Berlin", .Location = New GeoPoint(52.52, 13.38)}, New MapCallout() With {.Text = "Madrid", .Location = New GeoPoint(40.4, -3.68)}}
        End Function
    End Class
End Namespace
