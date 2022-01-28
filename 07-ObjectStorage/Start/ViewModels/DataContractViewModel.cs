using System.Runtime.Serialization;
using System.Text;
using System.Xml;

namespace XMLSamples {
  public class DataContractViewModel {
    public DataContractViewModel() {
      // TODO: MODIFY YOUR FILE LOCATION
      XmlFileName = @"D:\Samples\ProductDataContractFormatted.xml";
    }

    private readonly string XmlFileName;

    #region SerializeProduct Method
    /// <summary>
    /// Serialize a Product using a DataContractSerializer object
    /// </summary>
    public string SerializeProduct() {
      string value;

      // Create a New Product Object
      ProductWithDataContract prod = new()
      {
        ProductID = 999,
        Name = "A New Product",
        ProductNumber = "NEW-999",
        Color = "White",
        StandardCost = 10,
        ListPrice = 20,
        Size = "Medium"
      };

      // Change the private value
      prod.ChangePrivateString("Paul");

      // TODO: Create XML Serializer

      // Create a MemoryStream to write into
      using (MemoryStream ms = new()) {
        // Set options to indent XML
        var options = new XmlWriterSettings()
        {
          Indent = true,
          Encoding = Encoding.Unicode  // NOTE: Default is UTF8
        };

        // Create an XmlWriter with the 'options'
        using (XmlWriter xw = XmlWriter.Create(ms, options)) {
          // TODO: Serialize product object into MemoryStream
          
        }
        // Retrieve the string from the MemoryStream
        value = Encoding.Unicode.GetString(ms.ToArray());
      }

      // Write to File
      File.WriteAllText(XmlFileName, value);

      // Display XML
      Console.WriteLine(value);

      return value;
    }
    #endregion

    #region DeserializeProduct Method
    /// <summary>
    /// Deserialize XML created with DataContractSerializer back into Product object
    /// </summary>
    public ProductWithDataContract DeserializeProduct() {
      ProductWithDataContract prod = new();
      string value;

      // Read from File
      value = File.ReadAllText(XmlFileName);

      // TODO: Create XML Serializer
      
      // Create a MemoryStream with the string read from the file
      using (MemoryStream ms = new(Encoding.Unicode.GetBytes(value))) {
        // TODO: Deserialize the string into a product object
        
      }

      // Display Product
      Console.WriteLine(prod);

      return prod;
    }
    #endregion
  }
}
