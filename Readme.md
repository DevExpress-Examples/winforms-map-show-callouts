<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128576667/14.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T114954)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))**
<!-- default file list end -->
# How to manually generate vector items to display on a map


The following example demonstrates how to create an array of vector items and display on a map.


<h3>Description</h3>

<p>To show vector items on a map, it's necessary to do the following:<br />1. Create a <strong>VectorItemsLayer</strong> and add it to the Map control's <strong>Layers</strong> collection;<br />2. Create a <strong>MapItemStorage</strong>&nbsp;object and assign it to the <strong>VectorItemsLayer.Data</strong> property;<br />3. Generate an array of <strong>MapItem</strong> class descendants and add this array to the <strong>MapItemStorage.Items</strong> property.<br /><br />The code below illustrates how this can be done.</p>

<br/>


