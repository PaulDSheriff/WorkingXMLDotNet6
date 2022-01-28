namespace XMLSamples {
  /// <summary>
  /// Provides properties pointing to the various XML files used in this course
  /// </summary>
  public static class FileNameHelper {
    static FileNameHelper() {
      // TODO: Set the path to the XML files
      // NOTE: Normally, this would be in a configuration file
      string path = @"D:\Samples\Xml\";

      ProductsFile = $"{path}Products.xml";
      ProductsXsdFile = $"{path}Products.xsd";
      ProductsAttributesFile = $"{path}ProductsAttributes.xml";
      SalesOrderHeadersFile = $"{path}SalesOrderHeaders.xml";
      SalesOrderDetailsFile = $"{path}SalesOrderDetails.xml";
      SalesAndDetailsFile = $"{path}SalesAndDetails.xml";
    }

    public static string ProductsFile { get; set; }
    public static string ProductsXsdFile { get; set; }
    public static string ProductsAttributesFile { get; set; }
    public static string SalesOrderHeadersFile { get; set; }
    public static string SalesOrderDetailsFile { get; set; }
    public static string SalesAndDetailsFile { get; set; }
  }
}
