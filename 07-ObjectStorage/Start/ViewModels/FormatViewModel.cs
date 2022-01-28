using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace XMLSamples {
  public class FormatViewModel {
    public FormatViewModel() {
      // TODO: MODIFY YOUR FILE LOCATION
      XmlFileName = @"D:\Samples\ProductFormatted.xml";
    }

    private readonly string XmlFileName;

    #region SerializeProduct Method
    /// <summary>
    /// Serialize a Product object using XmlSerializer, MemoryStream, XmlWriter and XmlWriterSettings to format the XML
    /// NOTE: XmlWriter is recommended over the XmlTextWriter
    /// </summary>
    public string SerializeProduct() {
      string value = string.Empty;

      // Create a New Product Object
      Product prod = new()
      {
        ProductID = 999,
        Name = "A New Product",
        ProductNumber = "NEW-999",
        Color = "White",
        StandardCost = 10,
        ListPrice = 20,
        Size = "Medium",
        ModifiedDate = Convert.ToDateTime("01-01-2022")
      };

      // TODO: Create XML Serializer
      
      // Create a MemoryStream to write into
      using (MemoryStream ms = new()) {
        // Create a XmlWriterSettings object and add option to Indent
        XmlWriterSettings options = new()
        {
          Indent = true,
          Encoding = Encoding.Unicode
        };

        // Use an XmlWriter so you can format the XML
        using (XmlWriter xw = XmlWriter.Create(ms, options)) {
          // TODO: Serialize the product into a set of bytes
          
          // TODO: Convert the Bytes into a string
          
        }
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
    /// Deserialize formatted XML into a Product object using XmlSerializer and MemoryStream
    /// </summary>
    public Product DeserializeProduct() {
      Product prod = null;
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
