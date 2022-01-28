using System.Xml.Linq;

namespace XMLSamples
{
  /// <summary>
  /// Demos on using Aggregate functions with LINQ to XML
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
    /// Write a LINQ query to count all elements in an XML document
    /// </summary>
    public int Count()
    {
      XElement elem = XElement.Load(XmlFileName);

      // TODO: Write Query Here
      int value = 0;

      // Display Count
      Console.WriteLine(value);

      return value;
    }
    #endregion

    #region Sum Method
    /// <summary>
    /// Write a LINQ query to sum all LineTotal element values in an XML document
    /// </summary>
    public decimal Sum()
    {
      XElement elem = XElement.Load(XmlFileName);

      // TODO: Write Query Here
      decimal value = 0;

      // Display Sum
      Console.WriteLine(value.ToString("c"));

      return value;
    }
    #endregion

    #region Average Method
    /// <summary>
    /// Write a LINQ query to find the average value of all LineTotal element values in an XML document
    /// </summary>
    public decimal Average()
    {
      XElement elem = XElement.Load(XmlFileName);

      // TODO: Write Query Here
      decimal value = 0;

      // Display Average
      Console.WriteLine(value.ToString("c"));

      return value;
    }
    #endregion

    #region Minimum Method
    /// <summary>
    /// Write a LINQ query to find the minimum value of all LineTotal element values in an XML document
    /// </summary>
    public decimal Minimum()
    {
      XElement elem = XElement.Load(XmlFileName);

      // TODO: Write Query Here
      decimal value = 0;

      // Display Minimum
      Console.WriteLine(value.ToString("c"));

      return value;
    }
    #endregion

    #region Maximum Method
    /// <summary>
    /// Write a LINQ query to find the maximum value of all LineTotal element values in an XML document
    /// </summary>
    public decimal Maximum()
    {
      XElement elem = XElement.Load(XmlFileName);

      // TODO: Write Query Here
      decimal value = 0;

      // Display Maximum
      Console.WriteLine(value.ToString("c"));

      return value;
    }
    #endregion
  }
}
