namespace XMLSamples {
  public class NestedViewModel {
    public NestedViewModel() {
      // TODO: MODIFY YOUR FILE LOCATION
      XmlFileName = @"D:\Samples\ProductSales.xml";
    }

    private readonly string XmlFileName;

    #region SerializeProductSales Method
    /// <summary>
    /// Serialize a nested object to XML
    /// </summary>
    public string SerializeProductSales() {
      ProductSales prod = ProductSalesRepository.Get();
      string value = string.Empty;

      // TODO: Serialize the object
      

      // TODO: Write to File
      

      // Display Product
      Console.WriteLine(value);

      return value;
    }
    #endregion

    #region DeserializeProductSales Method
    /// <summary>
    /// Deserialize XML with nested elements back into a C# class
    /// </summary>
    public ProductSales DeserializeProductSales() {
      ProductSales prod = new();
      string value;

      // Read from File
      value = File.ReadAllText(XmlFileName);

      // TODO: Deserialize the object
      

      // Display Product
      Console.WriteLine(prod);

      return prod;
    }
    #endregion
  }
}
