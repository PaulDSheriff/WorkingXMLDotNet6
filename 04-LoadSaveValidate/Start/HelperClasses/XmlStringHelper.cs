namespace XMLSamples
{
  /// <summary>
  /// Class for working with XML Strings
  /// </summary>
  public class XmlStringHelper
  {
    #region CreateProductXmlString Method
    public static string CreateProductXmlString()
    {
      return @"<Products>
                <Product>
                  <ProductID>706</ProductID>
                  <Name>HL Road Frame - Red, 58</Name>
                  <ProductNumber>FR-R92R-58</ProductNumber>
                  <Color>Red</Color>
                  <StandardCost>1059.3100</StandardCost>
                  <ListPrice>1500.0000</ListPrice>
                  <Size>58</Size>
                </Product>
                <Product>
                  <ProductID>707</ProductID>
                  <Name>Sport-100 Helmet, Red</Name>   
                  <Color>Red</Color>
                  <StandardCost>13.0800</StandardCost>
                  <ListPrice>34.9900</ListPrice>
                  <Size />
                </Product>
              </Products>";
    }
    #endregion
  }
}