using System.Xml.Linq;

namespace XMLSamples {
  /// <summary>
  /// Demos of using element-based XML documents
  /// </summary>
  public class ElementViewModel {
    public ElementViewModel() {
      XmlFileName = FileNameHelper.ProductsFile;
    }

    private readonly string XmlFileName;

    #region GetAllXDocument Method
    /// <summary>
    /// When loading an XML document using XDocument, you use Descendants() to get all product nodes
    /// </summary>
    public List<XElement> GetAllXDocument() {
      XDocument doc = XDocument.Load(XmlFileName);
      List<XElement> list = new();

      // TODO: Write Query Here
      

      foreach (XElement prod in list) {
        Console.WriteLine($"Product Name: {prod.GetAs<string>("Name")}");
        Console.WriteLine($"   Product Id: {prod.GetAs<int>("ProductID")}");
      }

      Console.WriteLine();
      Console.WriteLine($"Total Products: {list.Count}");

      return list;
    }
    #endregion

    #region GetAllXElement Method
    /// <summary>
    /// When loading an XML document using XElement, you use Elements() to get all product nodes
    /// </summary>
    public List<XElement> GetAllXElement() {
      XElement elem = XElement.Load(XmlFileName);
      List<XElement> list = new();

      // TODO: Write Query Here
      

      foreach (XElement prod in list) {
        Console.WriteLine($"Product Name: {prod.GetAs<string>("Name")}");
        Console.WriteLine($"   Product Id: {prod.GetAs<int>("ProductID")}");
      }

      Console.WriteLine();
      Console.WriteLine($"Total Products: {list.Count}");

      return list;
    }
    #endregion

    #region WhereClause Method
    /// <summary>
    /// Write a LINQ query to get a set of orders using a where clause from the XML file
    /// </summary>
    public List<XElement> WhereClause() {
      XElement elem = XElement.Load(XmlFileName);
      List<XElement> list = new();

      // TODO: Write Query Here
      

      foreach (XElement prod in list) {
        Console.WriteLine($"Product Name: {prod.GetAs<string>("Name")}");
        Console.WriteLine($"   Product Id: {prod.GetAs<int>("ProductID")}");
        Console.WriteLine($"   Color: {prod.GetAs<string>("Color")}");
        Console.Write($"   Cost: {prod.GetAs<decimal>("StandardCost", 0):c}");
        Console.WriteLine($"   Price: {prod.GetAs<decimal>("ListPrice", 0):c}");
      }

      Console.WriteLine();
      Console.WriteLine($"Total Products: {list.Count}");

      return list;
    }
    #endregion

    #region GetASingleNode Method
    /// <summary>
    /// Write a LINQ query to get a single product from the XML file
    /// </summary>
    public XElement GetASingleNode() {
      XElement elem = XElement.Load(XmlFileName);
      XElement product = null;

      // TODO: Write Query Here
      

      if (product != null) {
        Console.WriteLine($"Product Name: {product.GetAs<string>("Name")}");
        Console.WriteLine($"   Product Id: {product.GetAs<int>("ProductID")}");
        Console.WriteLine($"   Color: {product.GetAs<string>("Color")}");
        Console.Write($"   Cost: {product.GetAs<decimal>("StandardCost", 0):c}");
        Console.WriteLine($"   Price: {product.GetAs<decimal>("ListPrice", 0):c}");
      } else {
        Console.WriteLine("Product Not Found");
      }

      return product;
    }
    #endregion

    #region OrderBy Method
    /// <summary>
    /// Write a LINQ query to get all products ordering by Color, ListPrice
    /// </summary>
    public List<XElement> OrderBy() {
      XElement elem = XElement.Load(XmlFileName);
      List<XElement> list = new();

      // TODO: Write Query Here


      foreach (XElement prod in list) {
        Console.WriteLine($"Product Name: {prod.GetAs<string>("Name")}");
        Console.WriteLine($"   Color: {prod.GetAs<string>("Color")}");
        Console.WriteLine($"   Price: {prod.GetAs<decimal>("ListPrice", 0):c}");
      }

      Console.WriteLine();
      Console.WriteLine($"Total Products: {list.Count}");

      return list;
    }
    #endregion

    #region AddToClass Method
    /// <summary>
    /// Write a LINQ query to get all elements and build a collection of Product objects
    /// </summary>
    public List<Product> AddToClass() {
      XElement elem = XElement.Load(XmlFileName);
      List<Product> list = new();

      // TODO: Write Query Here


      // Display products
      foreach (Product prod in list) {
        Console.Write(prod);
      }

      Console.WriteLine();
      Console.WriteLine($"Total Products: {list.Count}");

      return list;
    }
    #endregion

    #region Join Method
    /// <summary>
    /// Write code load two XML files to join products and orders and create a new XML document with a different shape.
    /// </summary>
    public XElement Join() {
      XElement prodElem;
      XElement detailElem;

      // Load products XML File
      prodElem = XElement.Load(XmlFileName);
      // Load Sales Order Detail XML File
      detailElem = XElement.Load(FileNameHelper.SalesOrderDetailsFile);

      // TODO: Write Query Here
      XElement newDoc = null;

      // Display Document
      Console.WriteLine(newDoc);

      return newDoc;
    }
    #endregion

    #region GetSalesWithDetails Method
    /// <summary>
    /// Write a LINQ query to only get those sales orders that have details
    /// </summary>
    public List<XElement> GetSalesWithDetails() {
      XElement elem = XElement.Load(FileNameHelper.SalesAndDetailsFile);
      List<XElement> list = new();

      // TODO: Write Query Here
     

      // Display Elements
      foreach (XElement order in list) {
        Console.WriteLine(order);
        Console.WriteLine();
      }

      Console.WriteLine();
      Console.WriteLine($"Total Items: {list.Count}");

      return list;
    }
    #endregion

    #region GetSalesLineTotalGreaterThan Method
    /// <summary>
    /// Write a LINQ query to only get those orders that have a LineTotal > $5,000
    /// </summary>
    public List<XElement> GetSalesLineTotalGreaterThan() {
      XElement elem = XElement.Load(FileNameHelper.SalesAndDetailsFile);
      List<XElement> list = new();

      // TODO: Write Query Here
      

      // Display Elements
      foreach (XElement order in list) {
        Console.WriteLine(order);
        Console.WriteLine();
      }

      Console.WriteLine();
      Console.WriteLine($"Total Items: {list.Count}");

      return list;
    }
    #endregion
  }
}
