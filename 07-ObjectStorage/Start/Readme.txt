To run this project in Visual Studio Code, open the XMLSamples.code-workspace
  When prompted to add "Required Assets", Click the 'Yes' button
  Run the project
  Check the DEBUG CONSOLE window for the output
To run this project in Visual Studio 2022, open the XMLSamples.sln
  Run the project
  A console window shows the output

Added Two Packages
  System.Data.SqlClient
  System.Xml.ReaderWriter

  
Notes About Serialization
--------------------------------------------------
The Serialize method converts the public fields and read/write properties of an object into XML. 
It does not convert methods, indexers, private fields, or read-only properties. 
To serialize all an object's fields and properties, both public and private, use the BinaryFormatter.


SerializeViewModel Samples
--------------------------------------------------
SerializeProduct() - Use XmlSerializer and StringWriter
DeserializeProduct() - Use XmlSerializer and MemoryStream to deserialize an XML document into a Product object


FormatViewModel Samples
--------------------------------------------------
SerializeProduct() - Serialize a Product object using XmlSerializer, MemoryStream, XmlWriter and XmlWriterSettings to format the XML
DeserializeProduct() - Deserialize formatted XML into a Product object using XmlSerializer and MemoryStream


ExtensionViewModel Samples
--------------------------------------------------
SerializeProduct() - Serialize a Product object using an extension method
DeserializeProduct() - Deserialize XML into a Product object using an extension method


AttributesViewModel Samples
--------------------------------------------------
SerializeProduct() - Add [Xml*] attributes to ProductWithAttributes class to help control serialization. Also use Serialize() extension method.
DeserializeProduct() - Deserialize Element/Attribute-based XML into ProductWithAttributes object. Also use Deserialize() extension method.


NestedViewModel Samples
--------------------------------------------------
SerializeProductSales() - Serialize a nested object to XML
DeserializeProductSales() - Deserialize XML with nested elements back into a C# class


DataContractViewModel
--------------------------------------------------
SerializeProductSales() - Add [Data*] attributes to ProductWithDataContract class to control serialization using the DataContractSerializer class
DeserializeProductSales() - Deserialize XML into a ProductWithDataContract object using the [Data*] attributes


BinaryViewModel
--------------------------------------------------
Using the BinaryFormatter
Add [Serializable] to classes
Will store and restore private variables
This formatter is marked as obsolete and will be removed sometime in the future
It is considered an insecure feature
SerializeProduct() - Use BinaryFormatter class to serialize and object. NOTE: This class is marked as Obsolete, so try not to use it
DeserializeProduct() - Use BinaryFormatter class to deserialize text from an XML file and create a new object. NOTE: This class is marked as Obsolete, so try not to use it


Resources
--------------------------------------------------
XmlSerializer
https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlserializer?view=net-6.0

DataContractSerialize
https://docs.microsoft.com/en-us/dotnet/api/system.runtime.serialization.datacontractserializer?view=net-6.0

BinaryFormatter
https://docs.microsoft.com/en-us/dotnet/api/system.runtime.serialization.formatters.binary.binaryformatter?view=net-6.0
