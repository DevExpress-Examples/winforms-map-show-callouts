Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraMap

Namespace AddItemsManually

    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            ' Create a map control with initial settings and add it to the form.
            Dim map As New MapControl() With {.Dock = DockStyle.Fill, .ZoomLevel = 4, .CenterPoint = New GeoPoint(43, 15)}
            Me.Controls.Add(map)

            ' Create a layer to load image tiles from OpenStreetMap.
            Dim tileLayer As New ImageLayer()
            tileLayer.DataProvider = New OpenStreetMapDataProvider()
            map.Layers.Add(tileLayer)

            ' Create a layer to display vector items.
            Dim itemsLayer As New VectorItemsLayer()
            map.Layers.Add(itemsLayer)

            ' Create a storage for map items and generate them.
            Dim storage As New MapItemStorage()
            Dim capitals() As MapItem = GetCapitals()
            storage.Items.AddRange(capitals)
            itemsLayer.Data = storage
        End Sub

        ' Create an array of callouts for 5 capital cities.
        Private Function GetCapitals() As MapItem()
            Return New MapItem() { _
                New MapCallout() With {.Text = "London", .Location = New GeoPoint(51.507222, -0.1275)}, _
                New MapCallout() With {.Text = "Rome", .Location = New GeoPoint(41.9, 12.5)}, _
                New MapCallout() With {.Text = "Paris", .Location = New GeoPoint(48.8567, 2.3508)}, _
                New MapCallout() With {.Text = "Berlin", .Location = New GeoPoint(52.52, 13.38)}, _
                New MapCallout() With {.Text = "Madrid", .Location = New GeoPoint(40.4, -3.68)} _
            }
        End Function
    End Class

End Namespace

