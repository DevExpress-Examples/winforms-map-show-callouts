# How to manually generate vector items to display on a map


The following example demonstrates how to create an array of vector items and display on a map.


<h3>Description</h3>

<p>To show vector items on a map, it's necessary to do the following:<br />1. Create a <strong>VectorItemsLayer</strong> and add it to the Map control's <strong>Layers</strong> collection;<br />2. Create a <strong>MapItemStorage</strong>&nbsp;object and assign it to the <strong>VectorItemsLayer.Data</strong> property;<br />3. Generate an array of <strong>MapItem</strong> class descendants and add this array to the <strong>MapItemStorage.Items</strong> property.<br /><br />The code below illustrates how this can be done.</p>

<br/>


