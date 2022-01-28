using System.Xml.Linq;
using System.Xml.Schema;

namespace XMLSamples {
  /// <summary>
  /// Demos of validating an XML document using an XML schema
  /// </summary>
  public class ValidateViewModel {
    public ValidateViewModel() {
      XmlFileName = FileNameHelper.ProductsFile;
      XsdFile = FileNameHelper.ProductsXsdFile;
    }

    private readonly string XmlFileName;
    private readonly string XsdFile;

    #region ValidateXml Method
    /// <summary>
    /// Write code to validate XML using an XSD file
    /// </summary>
    public XDocument ValidateXml() {
      XDocument doc = XDocument.Load(XmlFileName);

      // TODO: Create an XmlSchemaSet and add XSD file to it
     
      // TODO: Validate the document

      // Display Message
      Console.WriteLine("XML is valid.");

      return doc;
    }
    #endregion

    #region ValidateXmlWithError Method
    /// <summary>
    /// Write code to create an invalid node, then validate the XML using an XSD file
    /// </summary>
    public XDocument ValidateXmlWithError() {
      XDocument doc = XDocument.Load(XmlFileName);

      // TODO: Create an XmlSchemaSet, add Xsd File Name
      
      // TODO: Create an invalid XElement object to add
     
      
      bool errors = false;
      // TODO: Validate the document

      if (!errors) {
        // Display Success Message
        Console.WriteLine("XML is valid.");
      }

      return doc;
    }
    #endregion
  }
}
