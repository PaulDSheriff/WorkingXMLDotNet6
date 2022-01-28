using System.Xml.Linq;
using System.Xml.XPath;

namespace XMLSamples
{
  /// <summary>
  /// Demos of using attribute-based XML documents
  /// </summary>
  public class AttributeViewModel
  {
    public AttributeViewModel()
    {
      XmlFileName = FileNameHelper.ProductsAttributesFile;
    }

    private readonly string XmlFileName;

    #region GetAll Method
    /// <summary>
    /// Write an XPath query to get all Products and display the attribute values
    /// </summary>
    public List<XElement> GetAll()
    {
      XElement elem = XElement.Load(XmlFileName);
      List<XElement> list;

      // Write Query Here
      list = elem.XPathSelectElements("/Product").ToList();

      foreach (XElement prod in list)
      {
        // Use Attribute() method to retrieve values
        Console.WriteLine($"Product Name: {prod.Attribute("Name").Value}");
        Console.WriteLine($"   Product Id: {prod.Attribute("ProductID").Value}");
        Console.WriteLine($"   Product Number: {prod.Attribute("ProductNumber").Value}");
        Console.WriteLine($"   Color: {prod.Attribute("Color").Value}");
        Console.WriteLine($"   Cost: {prod.Attribute("StandardCost").Value}   Price: {prod.Attribute("ListPrice").Value}");
        Console.WriteLine($"   Size: {prod.Attribute("Size").Value}");
      }

      Console.WriteLine();
      Console.WriteLine($"Total Products: {list.Count}");

      return list;
    }
    #endregion

    #region GetASingleNode Method
    /// <summary>
    /// Write an XPath query to get a single product and display the attribute values
    /// </summary>
    public XElement GetASingleNode()
    {
      XElement elem = XElement.Load(XmlFileName);
      XElement prod;

      // Write Query Here
      prod = elem.XPathSelectElement("/Product[@ProductID='706']");

      if (prod != null)
      {
        // Display Product using GetAttrAs<T> extension method
        Console.WriteLine($"Product Name: {prod.GetAttrAs<string>("Name")}");
        Console.WriteLine($"   Product Id: {prod.GetAttrAs<string>("ProductID")}");
        Console.WriteLine($"   Product Number: {prod.GetAttrAs<string>("ProductNumber")}");
        Console.WriteLine($"   Color: {prod.GetAttrAs<string>("Color")}");
        Console.WriteLine($"   Cost: {prod.GetAttrAs<decimal>("StandardCost"):c}   Price: {prod.GetAttrAs<decimal>("ListPrice"):c}");
        Console.WriteLine($"   Size: {prod.GetAttrAs<string>("Size")}");
      }
      else
      {
        Console.WriteLine("Product Not Found");
      }

      return prod;
    }
    #endregion

    #region GetACollectionOfNodes Method
    /// <summary>
    /// Write an XPath query to search for a specific attribute value
    /// </summary>
    public List<XElement> GetACollectionOfNodes()
    {
      XElement elem = XElement.Load(XmlFileName);
      List<XElement> list;

      // Write Query Here
      list = elem.XPathSelectElements("/Product[@Color='Red']").ToList();

      foreach (XElement prod in list)
      {
        Console.WriteLine($"Product Name: {prod.GetAttrAs<string>("Name")}");
        Console.WriteLine($"   Product Id: {prod.GetAttrAs<string>("ProductID")}");
        Console.WriteLine($"   Product Number: {prod.GetAttrAs<string>("ProductNumber")}");
        Console.WriteLine($"   Color: {prod.GetAttrAs<string>("Color")}");
        Console.WriteLine($"   Cost: {prod.GetAttrAs<decimal>("StandardCost"):c}   Price: {prod.GetAttrAs<decimal>("ListPrice"):c}");
        Console.WriteLine($"   Size: {prod.GetAttrAs<string>("Size")}");
      }

      Console.WriteLine();
      Console.WriteLine($"Total Products: {list.Count}");

      return list;
    }
    #endregion
  }
}
