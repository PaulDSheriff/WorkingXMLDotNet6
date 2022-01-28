using System.Xml.Linq;

namespace XMLSamples {
  /// <summary>
  /// Demos of using attribute-based XML documents
  /// </summary>
  public class AttributeViewModel {
    public AttributeViewModel() {
      XmlFileName = FileNameHelper.ProductsAttributesFile;
    }

    private readonly string XmlFileName;

    #region GetAll Method
    /// <summary>
    /// Write a LINQ query to get all Products and display the attribute values
    /// </summary>
    public List<XElement> GetAll() {
      XElement elem = XElement.Load(XmlFileName);
      List<XElement> list = new();

      // TODO: Write Query Here
      

      foreach (XElement prod in list) {
        // Use Attribute() method to retrieve values
        Console.WriteLine($"Product Name: {prod.Attribute("Name").Value}");
        Console.WriteLine($"   Product Id: {prod.Attribute("ProductID").Value}");
        Console.WriteLine($"   Product Number: {prod.Attribute("ProductNumber").Value}");
        Console.WriteLine($"   Color: {prod.Attribute("Color").Value}");
        Console.Write($"   Cost: {prod.Attribute("StandardCost").Value}");
        Console.WriteLine($"   Price: {prod.Attribute("ListPrice").Value}");
        Console.WriteLine($"   Size: {prod.Attribute("Size").Value}");
      }

      Console.WriteLine();
      Console.WriteLine($"Total Products: {list.Count}");

      return list;
    }
    #endregion

    #region GetAllUsingExtensionMethod Method
    /// <summary>
    /// Write a LINQ query to get all products and display the attribute values using the extension method GetAttrAs()
    /// </summary>
    public List<XElement> GetAllUsingExtensionMethod() {
      XElement elem = XElement.Load(XmlFileName);
      List<XElement> list = new();

      // TODO: Write Query Here


      foreach (XElement prod in list) {
        // Use GetAttrAs<T> extension method
        Console.WriteLine($"Product Name: {prod.GetAttrAs<string>("Name")}");
        Console.WriteLine($"   Product Id: {prod.GetAttrAs<int>("ProductID")}");
        Console.WriteLine($"   Product Number: {prod.GetAttrAs<string>("ProductNumber")}");
        Console.WriteLine($"   Color: {prod.GetAttrAs<string>("Color")}");
        Console.Write($"   Cost: {prod.GetAttrAs<decimal>("StandardCost"):c}");
        Console.WriteLine($"   Price: {prod.GetAttrAs<decimal>("ListPrice"):c}");
        Console.WriteLine($"   Size: {prod.GetAttrAs<string>("Size", "n/a")}");
      }

      Console.WriteLine();
      Console.WriteLine($"Total Products: {list.Count}");

      return list;
    }
    #endregion

    #region GetASingleNode Method
    /// <summary>
    /// Write a LINQ query to get a single product and display the attribute values
    /// </summary>
    public XElement GetASingleNode() {
      XElement elem = XElement.Load(XmlFileName);
      XElement product = null;

      // TODO: Write Query Here
      // NOTE: Use extension methods


      if (product != null) {
        // Display Product using Attributes
        Console.WriteLine($"Product Name: {product.GetAttrAs<string>("Name")}");
        Console.WriteLine($"   Product Id: {product.GetAttrAs<int>("ProductID")}");
        Console.WriteLine($"   Product Number: {product.GetAttrAs<string>("ProductNumber")}");
        Console.WriteLine($"   Color: {product.GetAttrAs<string>("Color")}");
        Console.Write($"   Cost: {product.GetAttrAs<decimal>("StandardCost"):c}");
        Console.WriteLine($"   Price: {product.GetAttrAs<decimal>("ListPrice"):c}");
        Console.WriteLine($"   Size: {product.GetAttrAs<string>("Size", "n/a")}");
      } else {
        Console.WriteLine("Product Not Found");
      }

      return product;
    }
    #endregion

    #region OrderBy Method
    /// <summary>
    /// Write a LINQ query to order the products by Color, then by ListPrice
    /// </summary>
    public List<XElement> OrderBy() {
      XElement elem = XElement.Load(XmlFileName);
      List<XElement> list = new();

      // TODO: Write Query Here


      foreach (XElement prod in list) {
        // Display Product using Attributes
        Console.WriteLine($"Product Name: {prod.GetAttrAs<string>("Name")}");
        Console.WriteLine($"   Product Id: {prod.GetAttrAs<int>("ProductID")}");
        Console.WriteLine($"   Product Number: {prod.GetAttrAs<string>("ProductNumber")}");
        Console.WriteLine($"   Color: {prod.GetAttrAs<string>("Color")}");
        Console.Write($"   Cost: {prod.GetAttrAs<decimal>("StandardCost"):c}");
        Console.WriteLine($"   Price: {prod.GetAttrAs<decimal>("ListPrice"):c}");
        Console.WriteLine($"   Size: {prod.GetAttrAs<string>("Size", "n/a")}");
      }

      Console.WriteLine($"Total Products: {list.Count}");

      return list;
    }
    #endregion
  }
}
