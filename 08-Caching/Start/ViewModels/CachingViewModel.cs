namespace XMLSamples {
  /// <summary>
  /// Read data from a database and store into an XML file
  /// </summary>
  public class CachingViewModel {
    public CachingViewModel() {
      // TODO: MODIFY YOUR FILE LOCATION
      XmlFileName = @"D:\Samples\Products.xml";
    }

    private readonly string XmlFileName;

    #region GetData Method
    /// <summary>
    /// Write code to see if an XML file exists. If not, read from a database and store to XML file. If it does, read data from the XML file.
    /// </summary>
    public virtual List<Product> GetData() {
      List<Product> products = new();
      string xml = null;

      // TODO: Attempt to read local XML file
      

      // Check to see if we got any data
      if (!string.IsNullOrEmpty(xml)) {
        // TODO: Deserialize products from XML
        

        Console.WriteLine("Read from XML File");
      } else {
        // TODO: Get data from server        
        

        if (products.Count > 0) {
          // Serialize Collection
          xml = products.Serialize();

          // Write XML to local file
          File.WriteAllText(XmlFileName, xml);

          Console.WriteLine($"Read Product Data from Database Server and Stored in '{XmlFileName}'");
        } else {
          Console.WriteLine("No records retrieved from the server");
        }
      }

      return products;
    }
    #endregion
  }
}
