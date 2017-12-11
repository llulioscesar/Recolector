# Recolector
Una forma de almacenar temporalmente datos y pasarlos entre clases

```csharp
// Class1
Recolector R = Recolector.Instancia();
.......
R.Tabla = myTabla();

//Class2
Recolector R = Recolector.Instancia();
R.tabla.DataSet = myDataSet();

