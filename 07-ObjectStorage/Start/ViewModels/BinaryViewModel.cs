using System.Runtime.Serialization.Formatters.Binary;

namespace XMLSamples {
  public class BinaryViewModel {
    public BinaryViewModel() {
      // TODO: MODIFY YOUR FILE LOCATION
      XmlFileName = @"D:\Samples\ProductBinary.xml";
    }

    private readonly string XmlFileName;

    #region SerializeProduct Method
    /// <summary>
    /// Use BinaryFormatter class to serialize and object
    /// NOTE: This class is marked as Obsolete, so try not to use it
    /// </summary>
    public string SerializeProduct() {
      // Create a New Product Object
      ProductSerializable prod = new()
      {
        ProductID = 999,
        Name = "A New Product",
        ProductNumber = "NEW-999",
        Color = "White",
        StandardCost = 10,
        ListPrice = 20,
        Size = "Medium"
      };
      // Change the private variable to show it is serialized
      prod.ChangePrivateString("NEW VALUE");

      // Open a FileStream to write the binary XML to the file
      using (FileStream fs = new(XmlFileName, FileMode.Create)) {
        // TODO: Create a new BinaryFormatter
        
      }

      // Display Message
      string value = $"Binary file written '{XmlFileName}'";
      Console.WriteLine(value);

      return value;
    }
    #endregion

    #region DeserializeProduct Method
    /// <summary>
    /// Use BinaryFormatter class to deserialize text from an XML file and create a new object
    /// NOTE: This class is marked as Obsolete, so try not to use it
    /// </summary>
    public ProductSerializable DeserializeProduct() {
      ProductSerializable prod = new();

      using (FileStream fs = new(XmlFileName, FileMode.Open)) {
        // TODO: Create a new BinaryFormatter
        
      }

      // Display Product
      Console.WriteLine(prod);

      return prod;
    }
    #endregion
  }
}
