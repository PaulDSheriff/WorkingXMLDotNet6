using System.Xml.Linq;

namespace XMLSamples
{
  /// <summary>
  /// Demos of how to add, edit and delete nodes from an XML document
  /// </summary>
  public class AddEditDeleteViewModel
  {
    #region AddNewNode Method
    /// <summary>
    /// Write code to create a new XElement object and add it to an existing XML document
    /// </summary>
    public XDocument AddNewNode()
    {
      // Get a Product XML string
      string xml = XmlStringHelper.CreateProductXmlString();
      // Create XML Document using Parse()
      XDocument doc = XDocument.Parse(xml);

      // TODO: Create a new XElement object to add
     

      // TODO: Add the new XElement object to the root
      

      // Display Document
      Console.WriteLine(doc);

      return doc;
    }
    #endregion

    #region UpdateNode Method
    /// <summary>
    /// Write code to retrieve a single node from a document, edit some elements, then display the changed elements
    /// </summary>
    public XElement UpdateNode()
    {
      // Get a Product XML string
      string xml = XmlStringHelper.CreateProductXmlString();
      // Create XML Document using Parse()
      XDocument doc = XDocument.Parse(xml);

      // TODO: Get the First product element
      XElement elem = null;

      // TODO: Display the Changed Element
      

      return elem;
    }
    #endregion

    #region DeleteNode Method
    /// <summary>
    /// Write code to locate a specific node, then delete that node from the XML document
    /// </summary>
    public XElement DeleteNode()
    {
      // Get a Product XML string
      string xml = XmlStringHelper.CreateProductXmlString();
      // Create XML Document using Parse()
      XDocument doc = XDocument.Parse(xml);

      // TODO: Get the First product element
      XElement elem = null;

      // Display Document
      Console.WriteLine(doc);

      return elem;
    }
    #endregion
  }
}
