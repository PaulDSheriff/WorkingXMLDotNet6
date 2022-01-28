using System.Xml.Linq;
using System.Xml.XPath;

namespace XMLSamples
{
  /// <summary>
  /// Demos of using element-based XML documents
  /// </summary>
  public class ElementViewModel
  {
    public ElementViewModel()
    {
      XmlFileName = FileNameHelper.ProductsFile;
    }

    private readonly string XmlFileName;

    #region GetAllXDocument Method
    /// <summary>
    /// Write an XPath query to get all product elements using the XDocument class
    /// </summary>
    public List<XElement> GetAllXDocument()
    {
      XDocument doc = XDocument.Load(XmlFileName);
      List<XElement> list = new();

      // TODO: Write Query Here
      

      foreach (XElement prod in list)
      {
        // Console.WriteLine($"Product Name: {prod.Element("Name").Value}");
        // Console.WriteLine($"   Product Id: {prod.Element("ProductID").Value}");

        Console.WriteLine(prod);
      }

      Console.WriteLine();
      Console.WriteLine($"Total products: {list.Count}");

      return list;
    }
    #endregion

    #region GetAllXElement Method
    /// <summary>
    /// Write an XPath query to get all product elements using the XElement class
    /// </summary>
    public List<XElement> GetAllXElement()
    {
      XElement elem = XElement.Load(XmlFileName);
      List<XElement> list = new();

      // TODO: Write Query Here

      foreach (XElement prod in list)
      {
        Console.WriteLine($"Product Name: {prod.Element("Name").Value}");
        Console.WriteLine($"   Product Id: {prod.Element("ProductID").Value}");
        
        // Console.WriteLine(prod);
      }

      Console.WriteLine();
      Console.WriteLine($"Total products: {list.Count}");

      return list;
    }
    #endregion

    #region GetAllWithErrors Method
    /// <summary>
    /// Write an XPath query to load all products and show what happens when there is a null element
    /// </summary>
    public List<XElement> GetAllWithErrors()
    {
      XElement elem = XElement.Load(XmlFileName);
      List<XElement> list = new();

      // TODO: Write Query Here

      // NOTE: The ProductNumber in one of the elements contains a null
      foreach (XElement prod in list)
      {
        Console.WriteLine($"Product Name: {prod.Element("Name").Value}");
        Console.WriteLine($"   Product Id: {prod.Element("ProductID").Value}");
        Console.WriteLine($"   Product Number: {prod.Element("ProductNumber").Value}");
        Console.WriteLine($"   Color: {prod.Element("Color").Value}");
        Console.WriteLine($"   Cost: {prod.Element("StandardCost").Value}   Price: {prod.Element("ListPrice").Value}");
      }

      Console.WriteLine();
      Console.WriteLine($"Total Products: {list.Count}");

      return list;
    }
    #endregion

    #region GetAllUsingExtensionMethod Method
    /// <summary>
    /// Write an XPath query to load all products and use GetAs() to read the data
    /// </summary>
    public List<XElement> GetAllUsingExtensionMethod()
    {
      XElement elem = XElement.Load(XmlFileName);
      List<XElement> list = new();

      // TODO: Write Query Here


      // NOTE: The ProductNumber in one of the elements contains a null
      foreach (XElement prod in list)
      {
        Console.WriteLine($"Product Name: {prod.GetAs<string>("Name")}");
        Console.WriteLine($"   Product Id: {prod.GetAs<string>("ProductID")}");
        Console.WriteLine($"   Product Number: {prod.GetAs<string>("ProductNumber", "N/A")}");
        Console.WriteLine($"   Color: {prod.GetAs<string>("Color")}");
        Console.WriteLine($"   Cost: {prod.GetAs<decimal>("StandardCost", 0):c}   Price: {prod.GetAs<decimal>("ListPrice", 0):c}");
      }

      Console.WriteLine();
      Console.WriteLine($"Total Products: {list.Count}");

      return list;
    }
    #endregion

    #region GetASingleNode Method
    /// <summary>
    /// Write an XPath query to get a single product from the XML document
    /// </summary>
    public XElement GetASingleNode()
    {
      XElement elem = XElement.Load(XmlFileName);
      XElement prod = null;

      // TODO: Write Query Here
      

      if (prod != null)
      {
        Console.WriteLine($"Product Name: {prod.GetAs<string>("Name")}");
        Console.WriteLine($"   Product Id: {prod.GetAs<string>("ProductID")}");
        Console.WriteLine($"   Product Number: {prod.GetAs<string>("ProductNumber", "N/A")}");
        Console.WriteLine($"   Color: {prod.GetAs<string>("Color")}");
        Console.WriteLine($"   Cost: {prod.GetAs<decimal>("StandardCost", 0):c}   Price: {prod.GetAs<decimal>("ListPrice", 0):c}");
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
    /// Write an XPath query to get a set of products where an element's value matches a criteria
    /// </summary>
    public List<XElement> GetACollectionOfNodes()
    {
      XElement elem = XElement.Load(XmlFileName);
      List<XElement> list = new();

      // TODO: Write Query Here
      

      foreach (XElement prod in list)
      {
        Console.WriteLine($"Product Name: {prod.GetAs<string>("Name")}");
        Console.WriteLine($"   Product Id: {prod.GetAs<string>("ProductID")}");
        Console.WriteLine($"   Product Number: {prod.GetAs<string>("ProductNumber", "N/A")}");
        Console.WriteLine($"   Color: {prod.GetAs<string>("Color")}");
        Console.WriteLine($"   Cost: {prod.GetAs<decimal>("StandardCost", 0):c}   Price: {prod.GetAs<decimal>("ListPrice", 0):c}");
      }

      Console.WriteLine();
      Console.WriteLine($"Total Products: {list.Count}");

      return list;
    }
    #endregion

    #region GetLastNode Method
    /// <summary>
    /// Write an XPath query to get the last node in the document
    /// </summary>
    public XElement GetLastNode()
    {
      XElement elem = XElement.Load(XmlFileName);
      XElement prod = null;

      // TODO: Write Query Here


      if (prod != null)
      {
        Console.WriteLine($"Product Name: {prod.GetAs<string>("Name")}");
        Console.WriteLine($"   Product Id: {prod.GetAs<string>("ProductID")}");
        Console.WriteLine($"   Product Number: {prod.GetAs<string>("ProductNumber", "N/A")}");
        Console.WriteLine($"   Color: {prod.GetAs<string>("Color")}");
        Console.WriteLine($"   Cost: {prod.GetAs<decimal>("StandardCost", 0):c}   Price: {prod.GetAs<decimal>("ListPrice", 0):c}");
      }
      else
      {
        Console.WriteLine("Product Not Found");
      }

      return prod;
    }
    #endregion

    #region GetFirstThreeNodes Method
    /// <summary>
    /// Write an XPath query to get the first three nodes in the document
    /// </summary>
    public List<XElement> GetFirstThreeNodes()
    {
      XElement elem = XElement.Load(XmlFileName);
      List<XElement> list = new();

      // TODO: Write Query Here
      

      foreach (XElement prod in list)
      {
        Console.WriteLine($"Product Name: {prod.GetAs<string>("Name")}");
        Console.WriteLine($"   Product Id: {prod.GetAs<string>("ProductID")}");
        Console.WriteLine($"   Product Number: {prod.GetAs<string>("ProductNumber", "N/A")}");
        Console.WriteLine($"   Color: {prod.GetAs<string>("Color")}");
        Console.WriteLine($"   Cost: {prod.GetAs<decimal>("StandardCost", 0):c}   Price: {prod.GetAs<decimal>("ListPrice", 0):c}");
      }

      Console.WriteLine();
      Console.WriteLine($"Total Products: {list.Count}");

      return list;
    }
    #endregion

    #region AddToClass Method
    /// <summary>
    /// Write an XPath query to get some nodes and build a collection of Product objects
    /// </summary>
    public List<Product> AddToClass()
    {
      XElement elem = XElement.Load(XmlFileName);
      List<Product> list = new();

      // TODO: Write Query Here
      IEnumerable<XElement> query = null;

      // Write Query Here
      foreach (XElement prod in query)
      {
        list.Add(new Product
        {
          ProductID = prod.GetAs<int>("ProductID"),
          Name = prod.GetAs<string>("Name", "n/a"),
          Color = prod.GetAs<string>("Color"),
          StandardCost = prod.GetAs<decimal>("StandardCost", 0),
          ListPrice = prod.GetAs<decimal>("ListPrice", 0),
          Size = prod.GetAs<string>("Size", "n/a")
        });
      }

      // Display products
      foreach (Product product in list)
      {
        Console.Write(product);
      }

      Console.WriteLine();
      Console.WriteLine($"Total Products: {list.Count}");

      return list;
    }
    #endregion
  }
}
