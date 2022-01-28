using System.Xml.Linq;
using System.Xml.XPath;

namespace XMLSamples
{
  /// <summary>
  /// Demos of Aggregate functions with XPath queries
  /// </summary>
  public class AggregateViewModel
  {
    public AggregateViewModel()
    {
      XmlFileName = FileNameHelper.SalesOrderDetailsFile;
    }

    private readonly string XmlFileName;

    #region Count Method
    /// <summary>
    /// Write an XPath query to count all sales order details
    /// </summary>
    public double Count()
    {
      XElement elem = XElement.Load(XmlFileName);
      XPathNavigator nav = elem.CreateNavigator();
      double value;

      // Write Query Here
      value = (double)nav.Evaluate("count(/SalesOrderDetail)");
      
      // Display Count
      Console.WriteLine(value);

      return value;
    }
    #endregion

    #region Sum Method
    /// <summary>
    /// Write an XPath query to provide a sum of all values in the LineTotal element
    /// </summary>
    public double Sum()
    {
      XElement elem = XElement.Load(XmlFileName);
      XPathNavigator nav = elem.CreateNavigator();
      double value;

      // Write Query Here
      value = (double)nav.Evaluate("sum(/SalesOrderDetail/LineTotal)");

      // Display Sum
      Console.WriteLine(value.ToString("c"));

      return value;
    }
    #endregion

    #region Average Method
    /// <summary>
    /// Write an XPath query to provide the average value of all LineTotal elements
    /// </summary>
    public double Average()
    {
      XElement elem = XElement.Load(XmlFileName);
      XPathNavigator nav = elem.CreateNavigator();

      // Write Query Here
      string query = "sum(/SalesOrderDetail/LineTotal) div count(/SalesOrderDetail)";

      double value = (double)nav.Evaluate(query);

      // Display Average
      Console.WriteLine(value.ToString("c"));

      return value;
    }
    #endregion

    #region Minimum Method
    /// <summary>
    /// Write an XPath query to provide the minimum value of all LineTotal elements
    /// </summary>
    public double Minimum()
    {
      XElement elem = XElement.Load(XmlFileName);
      double value = 0;

      // Write Query Here
      string query = "/SalesOrderDetail/LineTotal[";
      query += "     not(. >=../preceding-sibling::SalesOrderDetail/LineTotal)";
      query += " and not(. >=../following-sibling::SalesOrderDetail/LineTotal)]";

      XElement minValue = elem.XPathSelectElement(query);
      if (minValue != null)
      {
        value = Convert.ToDouble(minValue.Value);
      }

      // Display Mimimum
      Console.WriteLine(value.ToString("c"));

      return value;
    }
    #endregion

    #region Maximum Method
    /// <summary>
    /// Write an XPath query to provide the maximum value of all LineTotal elements
    /// </summary>
    public double Maximum()
    {
      XElement elem = XElement.Load(XmlFileName);
      double value = 0;

      // Write Query Here
      string query = "/SalesOrderDetail/LineTotal[";
      query += "     not(. <=../preceding-sibling::SalesOrderDetail/LineTotal)";
      query += " and not(. <=../following-sibling::SalesOrderDetail/LineTotal)]";
      XElement maxValue = elem.XPathSelectElement(query);

      if (maxValue != null)
      {
        value = Convert.ToDouble(maxValue.Value);
      }

      // Display Maximum
      Console.WriteLine(value.ToString("c"));

      return value;
    }
    #endregion
  }
}
